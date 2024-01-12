using CapaNegocio;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;


namespace CapaDatos
{
    public class ManageSQL
    {
        private ConnectionDB conn = new ConnectionDB();

        public bool EjecutarSQL(string sql, List<SqlParameter> parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;

            // Agrega los parámetros a la consulta SQL
            if (parameters != null && parameters.Any())
            {
                command.Parameters.AddRange(parameters.ToArray());
            }

            command.Connection = conn.AbrirConexion();

            try
            {
                var resultado = command.ExecuteNonQuery();
                return resultado > 0;
            }
            catch (Exception ex)
            {
                // Maneja la excepción, imprímela o regístrala según sea necesario
                throw new Exception("Error al ejecutar la consulta SQL: " + ex.Message);
            }
            finally
            {
                // Cierra la conexión en el bloque finally para asegurar que siempre se cierre
                conn.CerrarConexion();
            }
        }


        public CN_Usuario retornarUserObjecto(string username, string clave)
        {
            string sql = "SELECT * FROM tb_Usuarios WHERE username = @Username AND clave = @Clave ";
            try
            {
                var command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Clave", clave);

                command.Connection = conn.AbrirConexion();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CN_Usuario user = new CN_Usuario
                    {
                        Nombres = reader["nombre"].ToString(),
                        Username = reader["username"].ToString(),
                        Clave = reader["clave"].ToString(),
                        Email = reader["mail"].ToString(),
                        Estado = Convert.ToBoolean(reader["estado"]),
                        PerfilUsuario = reader["id_rol"].ToString()
                    };
                    return user;
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }


        public bool ValidarCredenciales(string username, string clave)
        {
            string sql = "SELECT COUNT(*) FROM tb_Usuarios WHERE username = @Username AND clave = @Clave ";
            try
            {
                var command = new SqlCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = sql;

                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Clave", clave);

                command.Connection = conn.AbrirConexion();
                int count = (int)command.ExecuteScalar();

                conn.CerrarConexion();

                // Devolver true si se encontró al menos una fila
                return count > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable EjecutarSelect(string sql)
        {

            var command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }
        //STORE PROCEDURES
        public bool EjecutarSPSql(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            var resultado = command.ExecuteNonQuery();
            conn.CerrarConexion();

            if (resultado > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable EjecutarSPSelect(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();
            SqlDataReader reader = command.ExecuteReader();
            using (var tabla = new DataTable())
            {
                tabla.Load(reader);
                reader.DisposeAsync();
                conn.CerrarConexion();
                return tabla;
            }
        }
    }
}
