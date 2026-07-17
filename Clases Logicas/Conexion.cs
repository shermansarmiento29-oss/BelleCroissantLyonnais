using Microsoft.Data.SqlClient;
using System.Configuration;


namespace Clases_Logicas
{
    public class Conexion
    {
        private readonly string CadenaConexion;
        public Conexion()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;

        }

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }
}
