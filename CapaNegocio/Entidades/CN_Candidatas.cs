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
    public class CN_Candidatas
    {
        private ManageSQL obj_capa_datos = new ManageSQL();
        private ConnectionDB obj_conn = new ConnectionDB();

        private int id;
        private string nombre, apellidos;
        private int edad;
        private string telefono;
        private string provincia;
        private string pasatiempos, habilidades, intereses, aspiraciones;
        private int semestre;
        private int id_Carrera;
        private byte[] imagenBytes;


        public CN_Candidatas(int id, string nombre, string apellidos, int edad, string telefono, string provincia, string pasatiempos, string habilidades, string intereses, string aspiraciones, int semestre, int id_carrera)
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

        public CN_Candidatas()
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
            get { return pasatiempos; }  set { pasatiempos = value; }
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

        public DataTable GetListaCandidata()
        {
            Console.WriteLine("entro al lista Candidatas");
            try
            {

                return obj_capa_datos.EjecutarSelect("SELECT * FROM tb_candidata;");
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Candidatas." + e.Message);
            }
        }

        public bool CrearCandidata(CN_Candidatas candidata)
        {
            try
            {
                // Modifica la consulta SQL para incluir el parámetro de imagen
                var sql = "INSERT INTO tb_Candidata(nombre, apellidos, edad, telefono, provincia, pasatiempos, habilidades, intereses, aspiraciones, semestre, id_carrera, imagen)" +
                    "VALUES(" +
                    "'" + candidata.nombre + "'," +
                    "'" + candidata.apellidos + "'," +
                    "" + candidata.edad + "," +
                    "'" + candidata.telefono + "'," +
                    "'" + candidata.provincia + "'," +
                    "'" + candidata.pasatiempos + "'," +
                    "'" + candidata.habilidades + "'," +
                    "'" + candidata.intereses + "'," +
                    "'" + candidata.aspiraciones + "'," +
                    "" + candidata.semestre + "," +
                    "" + candidata.id_Carrera + "," +
                    "@imagen)";

                // Agrega el parámetro de imagen a la consulta SQL
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@imagen", SqlDbType.VarBinary) { Value = candidata.imagenBytes }
                };

                return obj_capa_datos.EjecutarSQL(sql, parameters);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ModificarCandidata(CN_Candidatas candidata)
        {
            try
            {
                var sql = "UPDATE tb_Candidata " +
                          "SET nombre = @nombre, " +
                          "apellidos = @apellidos, " +
                          "edad = @edad, " +
                          "telefono = @telefono, " +
                          "provincia = @provincia, " +
                          "pasatiempos = @pasatiempos, " +
                          "habilidades = @habilidades, " +
                          "intereses = @intereses, " +
                          "aspiraciones = @aspiraciones, " +
                          "semestre = @semestre, " +
                          "id_carrera = @id_carrera, " +
                          "imagen = @imagen " +
                          "WHERE id = @id";

                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@nombre", SqlDbType.NVarChar) { Value = candidata.nombre },
                    new SqlParameter("@apellidos", SqlDbType.NVarChar) { Value = candidata.apellidos },
                    new SqlParameter("@edad", SqlDbType.Int) { Value = candidata.edad },
                    new SqlParameter("@telefono", SqlDbType.NVarChar) { Value = candidata.telefono },
                    new SqlParameter("@provincia", SqlDbType.NVarChar) { Value = candidata.provincia },
                    new SqlParameter("@pasatiempos", SqlDbType.NVarChar) { Value = candidata.pasatiempos },
                    new SqlParameter("@habilidades", SqlDbType.NVarChar) { Value = candidata.habilidades },
                    new SqlParameter("@intereses", SqlDbType.NVarChar) { Value = candidata.intereses },
                    new SqlParameter("@aspiraciones", SqlDbType.NVarChar) { Value = candidata.aspiraciones },
                    new SqlParameter("@semestre", SqlDbType.Int) { Value = candidata.semestre },
                    new SqlParameter("@id_carrera", SqlDbType.Int) { Value = candidata.id_Carrera },
                    new SqlParameter("@imagen", SqlDbType.VarBinary) { Value = candidata.imagenBytes },
                    new SqlParameter("@id", SqlDbType.Int) { Value = candidata.id }
                };

                return obj_capa_datos.EjecutarSQL(sql, parameters);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Candidata: " + e.Message);
            }
        }

        public bool EliminarCandidata(CN_Candidatas candidata)
        {
            try
            {
                var sql = "DELETE FROM tb_Candidata " +
                          "WHERE id = @id";

                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@id", SqlDbType.Int) { Value = candidata.id }
                };

                return obj_capa_datos.EjecutarSQL(sql, parameters);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Candidata: " + e.Message);
            }
        }

    }
}
