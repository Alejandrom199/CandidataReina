using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Interfaces
{
    public class ICandidata
    {
        private ManageSQL obj_capa_datos = new ManageSQL();
        public DataTable GetListaCandidata()
        {
            Console.WriteLine("entro al lista Candidatas");
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_CANDIDATA";
                return obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Candidatas." + e.Message);
            }
        }

        public bool CrearCandidata
            (string nombre, string apellidos, int edad, string telefono, string provincia, string pasatiempos, 
            string habilidades, string intereses, string aspiraciones, int semestre, int id_carrera, byte[] imagenBytes)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_CANDIDATA";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", nombre),
                    new SqlParameter("@apellidos", apellidos),
                    new SqlParameter("@edad", edad),
                    new SqlParameter("@telefono", telefono),
                    new SqlParameter("@provincia", provincia),
                    new SqlParameter("@pasatiempos", pasatiempos),
                    new SqlParameter("@habilidades", habilidades),
                    new SqlParameter("@intereses", intereses),
                    new SqlParameter("@aspiraciones", aspiraciones),
                    new SqlParameter("@semestre", semestre),
                    new SqlParameter("@id_carrera", id_carrera),
                    new SqlParameter("@imagen", imagenBytes),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Candidata: " + e.Message);
            }
        }

        public bool ModificarCandidata
            (int id, string nombre, string apellidos, int edad, string telefono, string provincia, string pasatiempos,
            string habilidades, string intereses, string aspiraciones, int semestre, int id_carrera, byte[] imagenBytes)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_CANDIDATA";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", id),
                    new SqlParameter("@nombre", nombre),
                    new SqlParameter("@apellidos", apellidos),
                    new SqlParameter("@edad", edad),
                    new SqlParameter("@telefono", telefono),
                    new SqlParameter("@provincia", provincia),
                    new SqlParameter("@pasatiempos", pasatiempos),
                    new SqlParameter("@habilidades", habilidades),
                    new SqlParameter("@intereses", intereses),
                    new SqlParameter("@aspiraciones", aspiraciones),
                    new SqlParameter("@semestre", semestre),
                    new SqlParameter("@id_carrera", id_carrera),
                    new SqlParameter("@imagen", imagenBytes),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Candidata: " + e.Message);
            }
        }

        public bool EliminarCandidata(int id)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_CANDIDATA";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", id),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Candidata: " + e.Message);
            }
        }

        public DataRow getCandidataById(int id)
        {
            try
            {
                string nombreStoredProcedure = "SP_GET_CANDIDATA_BY_ID";

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@id", id)
                };

                DataTable dataTable = obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    // Devolver la primera fila que contiene los datos de la candidata
                    return dataTable.Rows[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de la candidata por ID. " + ex.Message);
            }
        }

        public DataRow getAllCandidataById(int id)
        {
            try
            {
                string nombreStoredProcedure = "SP_GET_ALL_CANDIDATA_BY_ID";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", id)
                };

                DataTable dataTable = obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, parametros);

                if (dataTable.Rows.Count > 0)
                {
                    // Devolver la primera fila que contiene los datos de la candidata
                    return dataTable.Rows[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de la candidata por ID. " + ex.Message);
            }
        }
    }
}
