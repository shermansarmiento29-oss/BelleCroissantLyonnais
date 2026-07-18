using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Clases_Logicas
{
    public class DireccionDAO : Conexion
    {
      
        public List<Direccion> ObtenerDireccionesPorUsuario(int idUsuario)
        {
            List<Direccion> lista = new List<Direccion>();

            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = @"SELECT ud.IdUsuarioDireccion, d.idDireccion, d.direccion, d.codigoPostal, d.ciudad, d.pais,
                                    ud.Etiqueta, ud.EsPreferida
                                    FROM UsuarioDireccion ud
                                    JOIN Direcciones d ON ud.IdDireccion = d.idDireccion
                                    WHERE ud.IdUsuario = @IdUsuario";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    lista.Add(new Direccion
                    {
                        IdUsuarioDireccion = (int)reader["IdUsuarioDireccion"],
                        IdDireccion = (int)reader["idDireccion"],
                        DireccionTexto = reader["direccion"].ToString(),
                        CodigoPostal = reader["codigoPostal"].ToString(),
                        Ciudad = reader["ciudad"].ToString(),
                        Pais = reader["pais"].ToString(),
                        Etiqueta = reader["Etiqueta"] == DBNull.Value ? "" : reader["Etiqueta"].ToString(),
                        EsPreferida = (bool)reader["EsPreferida"]
                    });
                }
                return lista;
            }
        }

        // Agregar una dirección nueva: primero se crea en Direcciones, luego se enlaza en UsuarioDireccion
        public bool AgregarDireccion(int idUsuario, Direccion d)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string consultaDireccion = @"INSERT INTO Direcciones (direccion, codigoPostal, ciudad, pais)
                                            OUTPUT INSERTED.idDireccion
                                            VALUES (@direccion, @codigoPostal, @ciudad, @pais)";
                SqlCommand comandoDireccion = new SqlCommand(consultaDireccion, conexion);
                comandoDireccion.Parameters.AddWithValue("@direccion", d.DireccionTexto);
                comandoDireccion.Parameters.AddWithValue("@codigoPostal", d.CodigoPostal);
                comandoDireccion.Parameters.AddWithValue("@ciudad", d.Ciudad);
                comandoDireccion.Parameters.AddWithValue("@pais", d.Pais);
                int nuevoIdDireccion = (int)comandoDireccion.ExecuteScalar();

                // Si se marca como preferida, primero quitamos la preferencia de las demás
                if (d.EsPreferida)
                    QuitarPreferidasDe(idUsuario, conexion);

                string consultaRelacion = @"INSERT INTO UsuarioDireccion (IdUsuario, IdDireccion, Etiqueta, EsPreferida)
                                            VALUES (@IdUsuario, @IdDireccion, @Etiqueta, @EsPreferida)";
                SqlCommand comandoRelacion = new SqlCommand(consultaRelacion, conexion);
                comandoRelacion.Parameters.AddWithValue("@IdUsuario", idUsuario);
                comandoRelacion.Parameters.AddWithValue("@IdDireccion", nuevoIdDireccion);
                comandoRelacion.Parameters.AddWithValue("@Etiqueta", d.Etiqueta);
                comandoRelacion.Parameters.AddWithValue("@EsPreferida", d.EsPreferida);
                int filas = comandoRelacion.ExecuteNonQuery();

                return filas > 0;
            }
        }

        // Actualizar una dirección existente
        public bool ActualizarDireccion(Direccion d)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                string consulta = @"UPDATE Direcciones SET direccion=@direccion, codigoPostal=@codigoPostal,
                                    ciudad=@ciudad, pais=@pais WHERE idDireccion=@idDireccion";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@direccion", d.DireccionTexto);
                comando.Parameters.AddWithValue("@codigoPostal", d.CodigoPostal);
                comando.Parameters.AddWithValue("@ciudad", d.Ciudad);
                comando.Parameters.AddWithValue("@pais", d.Pais);
                comando.Parameters.AddWithValue("@idDireccion", d.IdDireccion);
                int filas = comando.ExecuteNonQuery();
                return filas > 0;
            }
        }

        // Eliminar una dirección (primero la relación, luego la dirección en sí)
        public bool EliminarDireccion(int idUsuarioDireccion, int idDireccion)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                string consultaRelacion = "DELETE FROM UsuarioDireccion WHERE IdUsuarioDireccion=@IdUsuarioDireccion";
                SqlCommand comandoRelacion = new SqlCommand(consultaRelacion, conexion);
                comandoRelacion.Parameters.AddWithValue("@IdUsuarioDireccion", idUsuarioDireccion);
                comandoRelacion.ExecuteNonQuery();

                string consultaDireccion = "DELETE FROM Direcciones WHERE idDireccion=@idDireccion";
                SqlCommand comandoDireccion = new SqlCommand(consultaDireccion, conexion);
                comandoDireccion.Parameters.AddWithValue("@idDireccion", idDireccion);
                int filas = comandoDireccion.ExecuteNonQuery();

                return filas > 0;
            }
        }

        // Marcar una dirección como preferida (y quitar la marca de las demás del mismo usuario)
        public bool MarcarComoPreferida(int idUsuario, int idUsuarioDireccion)
        {
            using (SqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();
                QuitarPreferidasDe(idUsuario, conexion);

                string consulta = "UPDATE UsuarioDireccion SET EsPreferida=1 WHERE IdUsuarioDireccion=@Id";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@Id", idUsuarioDireccion);
                int filas = comando.ExecuteNonQuery();
                return filas > 0;
            }
        }

        private void QuitarPreferidasDe(int idUsuario, SqlConnection conexionAbierta)
        {
            string consulta = "UPDATE UsuarioDireccion SET EsPreferida=0 WHERE IdUsuario=@IdUsuario";
            SqlCommand comando = new SqlCommand(consulta, conexionAbierta);
            comando.Parameters.AddWithValue("@IdUsuario", idUsuario);
            comando.ExecuteNonQuery();
        }
    }
}