using CapaDatos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Entidades
{
    public class CN_Candidata
    {
        private ManageSQL obj_capa_datos = new ManageSQL();

        private int id;
        private string nombre, apellidos;
        private int edad;
        private string telefono;
        private string provincia;
        private string pasatiempos, habilidades, intereses, aspiraciones;
        private int semestre;
        private int id_Carrera;
        private byte[] imagenBytes;


        public CN_Candidata(int id, string nombre, string apellidos, int edad, string telefono, string provincia, string pasatiempos, string habilidades, string intereses, string aspiraciones, int semestre, int id_carrera)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.edad = edad;
            this.telefono = telefono;
            this.provincia = provincia;
            this.pasatiempos = pasatiempos;
            this.habilidades = habilidades;
            this.intereses = intereses;
            this.aspiraciones = aspiraciones;
            this.semestre = semestre;
            this.id_Carrera = id_carrera;
        }

        public CN_Candidata()
        {
            id = 0;
            nombre = string.Empty;
            apellidos = string.Empty;
            edad = 0;
            telefono = string.Empty;
            provincia = string.Empty;
            pasatiempos = string.Empty;
            habilidades = string.Empty;
            intereses = string.Empty;
            aspiraciones = string.Empty;
            semestre = -1;
            id_Carrera = -1;
            imagenBytes = null;
        }
        public int Id
        {
            get { return id; } set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; } set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; } set { apellidos = value; }
        }

        public int Edad
        {
            get { return edad; } set { edad = value; }
        }

        public string Telefono
        {
            get { return telefono; } set { telefono = value; }
        }
        public string Provincia
        {
            get { return provincia; }  set { provincia = value; }
        }

        public string Pasatiempos
        {
            get { return pasatiempos; } set { pasatiempos = value; }
        }

        public string Habilidades
        {
            get { return habilidades; } set { habilidades = value; }
        }

        public string Intereses
        {
            get { return intereses; } set { intereses = value; }
        }

        public string Aspiraciones
        {
            get { return aspiraciones; } set { aspiraciones = value; }
        }

        public int Semestre
        {
            get { return semestre; } set { semestre = value; }
        }

        public int Id_Carrera
        {
            get { return id_Carrera; } set { id_Carrera = value; }
        }

        public byte[] ImagenByte
        {
            get { return imagenBytes; } set { imagenBytes = value; }
        }

        /**
         * Método para obtener las lista de las candidatas
         **/
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

        /**
         * Método para realizar una inserción de una candidata
         **/
        public bool CrearCandidata(CN_Candidata candidata)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_CANDIDATA";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", candidata.Nombre),
                    new SqlParameter("@apellidos", candidata.Apellidos),
                    new SqlParameter("@edad", candidata.Edad),
                    new SqlParameter("@telefono", candidata.Telefono),
                    new SqlParameter("@provincia", candidata.Provincia),
                    new SqlParameter("@pasatiempos", candidata.Pasatiempos),
                    new SqlParameter("@habilidades", candidata.Habilidades),
                    new SqlParameter("@intereses", candidata.Intereses),
                    new SqlParameter("@aspiraciones", candidata.Aspiraciones),
                    new SqlParameter("@semestre", candidata.Semestre),
                    new SqlParameter("@id_carrera", candidata.Id_Carrera),
                    new SqlParameter("@imagen", candidata.ImagenByte),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Candidata: " + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de una candidata
         **/
        public bool ModificarCandidata(CN_Candidata candidata)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_CANDIDATA";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", candidata.Id),
                    new SqlParameter("@nombre", candidata.Nombre),
                    new SqlParameter("@apellidos", candidata.Apellidos),
                    new SqlParameter("@edad", candidata.Edad),
                    new SqlParameter("@telefono", candidata.Telefono),
                    new SqlParameter("@provincia", candidata.Provincia),
                    new SqlParameter("@pasatiempos", candidata.Pasatiempos),
                    new SqlParameter("@habilidades", candidata.Habilidades),
                    new SqlParameter("@intereses", candidata.Intereses),
                    new SqlParameter("@aspiraciones", candidata.Aspiraciones),
                    new SqlParameter("@semestre", candidata.Semestre),
                    new SqlParameter("@id_carrera", candidata.Id_Carrera),
                    new SqlParameter("@imagen", candidata.ImagenByte),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Candidata: " + e.Message);
            }
        }

        /**
         * Método para realizar una eliminación de una candidata
         **/
        public bool EliminarCandidata(CN_Candidata candidata)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_CANDIDATA";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", candidata.Id),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Candidata: " + e.Message);
            }
        }

        /**
         * Método para obtener el ID de una candidata
         **/
        public DataRow getCandidataById(CN_Candidata candidata)
        {
            try
            {
                string nombreStoredProcedure = "SP_GET_CANDIDATA_BY_ID";

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@id", candidata.id)
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

        public DataRow getAllCandidataById(CN_Candidata candidata)
        {
            try
            {
                string nombreStoredProcedure = "SP_GET_ALL_CANDIDATA_BY_ID";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", candidata.id)
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
