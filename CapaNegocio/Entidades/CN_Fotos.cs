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
    public class CN_Fotos
    {
        private ManageSQL obj_capa_datos = new ManageSQL();
        private ConnectionDB obj_conn = new ConnectionDB();

        private int id;
        private byte[] imagen1, imagen2, imagen3, imagen4;
        private string titulo, descripcion;
        private int id_Candidata;

        public CN_Fotos (int id, string titulo, string descripcion, int id_Candidta)
        {
            this.id = id;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.id_Candidata = id_Candidta;
        }

        public CN_Fotos()
        {
            id = 0;
            titulo = string.Empty;
            descripcion = string.Empty;
            id_Candidata = -1;
            imagen1 = null;
            imagen2 = null;
            imagen3 = null;
            imagen4 = null;
        }

        public int Id
        {
            get { return id; }  set { id = value; }
        }

        public byte[] Imagen1
        {
            get { return imagen1; } set { imagen1 = value; }
        }

        public byte[] Imagen2
        {
            get { return imagen2; }
            set { imagen2 = value; }
        }

        public byte[] Imagen3
        {
            get { return imagen3; }
            set { imagen3 = value; }
        }

        public byte[] Imagen4
        {
            get { return imagen4; }
            set { imagen4 = value; }
        }
        public string Titulo 
        { 
            get {  return titulo; } set {  titulo = value; } 
        }
        public string Descripcion 
        {
            get { return descripcion; }   set { descripcion = value; } 
        } 
        public int Id_Candidata
        { 
            get {  return id_Candidata; } set {  id_Candidata = value; } 
        }

        public bool AgregarImagenes(CN_Fotos fotos)
        {
            try
            {
                // Modifica la consulta SQL para incluir el parámetro de imagen
                var sql = "INSERT INTO tb_fotos(id_candidata, titulo, descripcion, imagen1, imagen2, imagen3, imagen4)" +
                    "VALUES(" +
                    "'" + fotos.Id_Candidata + "'," +
                    "'" + fotos.Titulo + "'," + // Agrega comillas simples alrededor de fotos.Titulo
                    "'" + fotos.Descripcion + "'," + // Agrega comillas simples alrededor de fotos.Descripcion
                    "@imagen1, @imagen2, @imagen3, @imagen4)";

                // Agrega el parámetro de imagen a la consulta SQL
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@imagen1", SqlDbType.VarBinary) { Value = fotos.Imagen1 },
                    new SqlParameter("@imagen2", SqlDbType.VarBinary) { Value = fotos.Imagen2 },
                    new SqlParameter("@imagen3", SqlDbType.VarBinary) { Value = fotos.Imagen3 },
                    new SqlParameter("@imagen4", SqlDbType.VarBinary) { Value = fotos.Imagen4 }
                };

                return obj_capa_datos.EjecutarSQL(sql, parameters);
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool ModificarImagenes(CN_Fotos fotos)
        {

            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_FOTOS";

                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@titulo", fotos.Titulo),
                new SqlParameter("@descripcion", fotos.Descripcion),
                new SqlParameter("@imagen1", fotos.Imagen1),
                new SqlParameter("@imagen2", fotos.Imagen2),
                new SqlParameter("@imagen3", fotos.Imagen3),
                new SqlParameter("@imagen4", fotos.Imagen4),
                new SqlParameter("@id_candidata", fotos.Id_Candidata)
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar galeria: " + e.Message);
            }

        }

        public List<CN_Fotos> ObtenerFotosPorCandidata(int id_candidata)
        {
            List<CN_Fotos> fotos = new List<CN_Fotos>();

            string query = "SELECT * FROM tb_fotos WHERE id_candidata = @id_candidata";

            using (SqlCommand cmd = new SqlCommand(query, obj_conn.AbrirConexion()))
            {
                cmd.Parameters.AddWithValue("@id_candidata", id_candidata);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        CN_Fotos foto = new CN_Fotos
                        {
                            Id_Candidata = (int)reader["id_candidata"],
                            Titulo = reader["titulo"].ToString(),
                            Descripcion = reader["descripcion"].ToString(),
                            Imagen1 = (byte[])reader["imagen1"],
                            Imagen2 = (byte[])reader["imagen2"],
                            Imagen3 = (byte[])reader["imagen3"],
                            Imagen4 = (byte[])reader["imagen4"]
                        };

                        fotos.Add(foto);
                    }
                }
            }

            // Agrega mensajes de depuración
            Console.WriteLine("Cantidad de fotos obtenidas: " + fotos.Count);

            return fotos;
        }

        public bool EliminarFotos(CN_Fotos fotos)
        {

            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_GALERIA";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id_candidata", fotos.id_Candidata),
                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar fotos: " + e.Message);
            }

        }
    }
}
