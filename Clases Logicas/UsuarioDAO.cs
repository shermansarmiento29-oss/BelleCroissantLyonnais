using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Clases_Logicas
{
    public class UsuarioDAO : Conexion
    {

        public string CalcularHash(string textoPlano)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(textoPlano));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        public bool Login(string correo, string contrasena)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE correo=@Correo AND contraseña=@Contrasena";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Correo", correo);
                comando.Parameters.AddWithValue("@Contrasena", CalcularHash(contrasena));
                int cantidad = (int)comando.ExecuteScalar();
                return cantidad > 0;
            }
        }

        //  Verificar correo duplicado //
        public bool ExisteCorreo(string correo)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE correo=@Correo";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Correo", correo);
                int cantidad = (int)comando.ExecuteScalar();
                return cantidad > 0;
            }
        }

        public bool InsertarUser(Usuario user)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = @"INSERT INTO Usuarios (nombre, apellido, correo, [contraseña], suscripcion)
                            VALUES (@nombre, @apellido, @correo, @contrasena, @suscripcion)";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nombre", user.Nombre);
                comando.Parameters.AddWithValue("@apellido", user.Apellido);
                comando.Parameters.AddWithValue("@correo", user.Correo);
                comando.Parameters.AddWithValue("@contrasena", CalcularHash(user.Contraseña));
                comando.Parameters.AddWithValue("@suscripcion", user.Suscripcion);
                int filas = comando.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public bool EmailExiste(string email)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE correo = @Email";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@Email", email);
                int cantidad = (int)cmd.ExecuteScalar();
                return cantidad > 0;
            }
        }

        public bool InsertarPreguntaSeguridad(string correo, int idPregunta, string respuesta)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = @"INSERT INTO UsuarioPregunta (IdUsuario, IdPregunta, Respuesta)
                            SELECT idUsuario, @IdPregunta, @Respuesta
                            FROM Usuarios WHERE correo = @Correo";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdPregunta", idPregunta);
                comando.Parameters.AddWithValue("@Respuesta", CalcularHash(respuesta));
                comando.Parameters.AddWithValue("@Correo", correo);
                int filas = comando.ExecuteNonQuery();
                return filas > 0;
            }
        }

        public List<PreguntaSeguridad> ObtenerPreguntasCatalogo()
        {
            List<PreguntaSeguridad> lista = new List<PreguntaSeguridad>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = "SELECT IdPregunta, Pregunta FROM PreguntasSeguridad";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new PreguntaSeguridad
                    {
                        IdPregunta = (int)reader["IdPregunta"],
                        Pregunta = reader["Pregunta"].ToString()
                    });
                }

                return lista;
            }
        }

    }
}