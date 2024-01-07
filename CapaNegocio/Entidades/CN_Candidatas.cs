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

        private int id;
        private string nombre, apellidos;
        private int edad;
        private string telefono;
        private string provincia;
        private string pasatiempos, habilidades, intereses, aspiraciones;
        private int semestre;
        private int id_Carrera;
        private byte[] imagenBytes;

        private string titulo1, descripcion1, titulo2, descripcion2, titulo3, descripcion3, titulo4, descripcion4;
        private byte[] foto1, foto2, foto3, foto4;


        public CN_Candidatas(int id, string nombre, string apellidos, int edad, string telefono, string provincia, string pasatiempos, string habilidades, string intereses, string aspiraciones, int semestre, int id_carrera,
            string titulo1, string descripcion1, string titulo2, string descripcion2, string titulo3, string descripcion3, string titulo4, string descripcion4)
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
            this.titulo1 = titulo1;
            this.descripcion1 = descripcion1;
            this.titulo2 = titulo2;
            this.descripcion2 = descripcion2;
            this.titulo3 = titulo3;
            this.descripcion3 = descripcion3;
            this.titulo4 = titulo4;
            this.descripcion4 = descripcion4;
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
            titulo1 = string.Empty;
            descripcion1 = string.Empty;
            foto1 = null;
            titulo2 = string.Empty;
            descripcion2 = string.Empty;
            foto2 = null;
            titulo3 = string.Empty;
            descripcion3 = string.Empty;
            foto3 = null;
            titulo4 = string.Empty;
            descripcion4 = string.Empty;
            foto4 = null;
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

        public string Titulo1
        {
            get { return titulo1; } set { titulo1 = value; }
        }

        public string Descripcion1
        {
            get { return descripcion1; } set { descripcion1 = value; }
        }

        public byte[] Foto1
        {
            get { return foto1; } set { foto1 = value; }
        }

        public string Titulo2
        {
            get { return titulo2; } set { titulo2 = value; }
        }

        public string Descripcion2
        {
            get { return descripcion2; } set { descripcion2 = value; }
        }

        public byte[] Foto2
        {
            get { return foto2; } set { foto2 = value; }
        }

        public string Titulo3
        {
            get { return titulo3; }  set { titulo3 = value; }
        }

        public string Descripcion3
        {
            get { return descripcion3; } set { descripcion3 = value; }
        }

        public byte[] Foto3
        {
            get { return foto3; } set { foto3 = value; }
        }

        public string Titulo4
        {
            get { return titulo4; } set { titulo4 = value; }
        }

        public string Descripcion4
        {
            get { return descripcion4; } set { descripcion4 = value; }
        }

        public byte[] Foto4
        {
            get { return foto4; } set { foto4 = value; }
        }

        public DataTable GetListaCandidata()
        {
            Console.WriteLine("entro al lista Candidatas");
            try
            {

                return obj_capa_datos.EjecutarSelect("SELECT * FROM tb_Candidata;");
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
                var sql = "INSERT INTO tb_Candidata(nombre, apellidos, edad, telefono, provincia, pasatiempos, habilidades, intereses, aspiraciones, semestre, id_carrera, imagen, foto1, titulo1, descripcion1,  foto2, titulo2, descripcion2, foto3, titulo3, descripcion3 , foto4, titulo4, descripcion4)" +
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
                    "@imagen, @foto1, @titulo1, @descripcion1,  @foto2, @titulo2, @descripcion2, @foto3, @titulo3, @descripcion3 , @foto4, @titulo4, @descripcion4 )";

                // Agrega el parámetro de imagen a la consulta SQL
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@imagen", SqlDbType.VarBinary) { Value = candidata.imagenBytes },

                    new SqlParameter("@foto1", SqlDbType.VarBinary) { Value = candidata.foto1 },
                    new SqlParameter("@titulo1", SqlDbType.VarChar) { Value = candidata.titulo1 },
                    new SqlParameter("@descripcion1", SqlDbType.VarChar) { Value = candidata.descripcion1 },

                    new SqlParameter("@foto2", SqlDbType.VarBinary) { Value = candidata.foto2 },
                    new SqlParameter("@titulo2", SqlDbType.VarChar) { Value = candidata.titulo2 },
                    new SqlParameter("@descripcion2", SqlDbType.VarChar) { Value = candidata.descripcion2 },

                    new SqlParameter("@foto3", SqlDbType.VarBinary) { Value = candidata.foto3 },
                    new SqlParameter("@titulo3", SqlDbType.VarChar) { Value = candidata.titulo3 },
                    new SqlParameter("@descripcion3", SqlDbType.VarChar) { Value = candidata.descripcion3 },

                    new SqlParameter("@foto4", SqlDbType.VarBinary) { Value = candidata.foto4 },
                    new SqlParameter("@titulo4", SqlDbType.VarChar) { Value = candidata.titulo4 },
                    new SqlParameter("@descripcion4", SqlDbType.VarChar) { Value = candidata.descripcion4 },
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
