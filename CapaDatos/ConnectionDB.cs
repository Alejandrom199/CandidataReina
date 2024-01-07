using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class ConnectionDB
    {
        private SqlConnection cadena_conexion = new SqlConnection("server=ALEJANDRO-PC; database=REINA_FACULTAD; User ID=sa; Password=sa;TrustServerCertificate=true");

        public SqlConnection AbrirConexion()
        {
            try
            {
                if (cadena_conexion != null && cadena_conexion.State == System.Data.ConnectionState.Closed)
                {
                    cadena_conexion.Open();
                }
                return cadena_conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion" + ex.Message);
            }

        }

        public SqlConnection CerrarConexion()
        {
            try
            {
                if (cadena_conexion != null && cadena_conexion.State == System.Data.ConnectionState.Open)
                {
                    cadena_conexion.Close();
                }
                return cadena_conexion;
            }
            catch (Exception ex)
            {
                throw new Exception("Error de conexion" + ex.Message);
            }

        }
    }
}
