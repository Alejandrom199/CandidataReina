
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

        public object EjecutarSPSelectScalar(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();

            // Utiliza ExecuteScalar para obtener un solo valor
            object result = command.ExecuteScalar();

            conn.CerrarConexion();

            return result;
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


        public bool EjecutarSPValidarCredenciales(string storedProcedureName, SqlParameter[] parameters)
        {
            try
            {
                var command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = storedProcedureName;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

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

        public string ObtenerDatoPorUsuario(string storedProcedureName, SqlParameter[] parameters, string tipoDato)
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

            string dato = null;

            if (reader.Read())
            {
                // Asumiendo que la columna en la base de datos es de tipo VARCHAR
                dato = reader[tipoDato].ToString();
            }

            reader.Dispose();
            conn.CerrarConexion();

            return dato;
        }

        public bool CrearVoto(string storedProcedureName, SqlParameter[] parameters)
        {
            var command = new SqlCommand();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = storedProcedureName;

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.Connection = conn.AbrirConexion();

            try
            {
                // Ejecutar el stored procedure para crear un voto
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // Manejar excepciones, mostrar mensaje o registrar en un log según sea necesario
                Console.WriteLine($"Error al crear el voto: {ex.Message}");
                return false;
            }
            finally
            {
                conn.CerrarConexion();
            }
        }

        public bool ObtenerEstadoVotacion(string storedProcedureName, SqlParameter[] parameters)
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

            bool dato = false;

            try
            {
                if (reader.Read())
                {
                    // Asumiendo que la columna en la base de datos es de tipo BIT
                    dato = reader.GetBoolean(reader.GetOrdinal("isVoto"));
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones, mostrar mensaje o registrar en un log según sea necesario
                Console.WriteLine($"Error al obtener el estado de votación: {ex.Message}");
            }
            finally
            {
                reader.Dispose();
                conn.CerrarConexion();
            }

            return dato;
        }


    }
}
