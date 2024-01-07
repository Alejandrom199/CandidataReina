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
    public class CN_Galeria
    {
        private ManageSQL obj_capa_datos = new ManageSQL();

        private int id;
        private byte[] imagenBytes;
        private string titulo, descripcion;
        private int id_Candidata;

        public CN_Galeria (int id, string titulo, string descripcion, int id_Candidta)
        {
            this.id = id;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.id_Candidata = id_Candidta;
        }

        public CN_Galeria()
        {
            id = 0;
            titulo = string.Empty;
            descripcion = string.Empty;
            id_Candidata = -1;
            imagenBytes = null;
        }

        public int Id
        {
            get { return id; }  set { id = value; }
        }

        public byte[] ImagenBytes
        {
            get { return imagenBytes; } set { imagenBytes = value; }
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
        public DataTable GetListaGaleriaImagenes()
        {
            Console.WriteLine("entro al lista imagen");
            try
            {

                return obj_capa_datos.EjecutarSelect("SELECT * FROM tb_GaleriaFotos;");
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Candidatas." + e.Message);
            }
        }

        public bool AgregarImagenAGaleria(int idCandidata, string titulo, string descripcion, byte[] imagenBytes)
        {
            try
            {
                // Modifica la consulta SQL para incluir los parámetros de la galería
                var sql = "INSERT INTO tb_GaleriaFotos (imagen, titulo, descripcion, id_Candidata)" +
                          "VALUES (@imagen, @titulo, @descripcion, @idCandidata)";

                // Agrega los parámetros a la consulta SQL
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@imagen", SqlDbType.VarBinary) { Value = imagenBytes },
                    new SqlParameter("@titulo", SqlDbType.VarChar, 60) { Value = titulo },
                    new SqlParameter("@descripcion", SqlDbType.VarChar, 120) { Value = descripcion },
                    new SqlParameter("@idCandidata", SqlDbType.Int) { Value = idCandidata }
                };

                return obj_capa_datos.EjecutarSQL(sql, parameters);
            }
            catch (Exception e)
            {
                // Manejo de excepciones
                return false;
            }
        }
    }
}
