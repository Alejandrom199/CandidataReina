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
    public class CN_Voto
    {
        private ManageSQL obj_capa_datos = new ManageSQL();
        private int id;
        private string nombre;
        private string apellido;
        private string cedula_usuario;

        public CN_Voto()
        {
            id = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            cedula_usuario = string.Empty;
        }

        public CN_Voto(int id, string nombre, string apellido, string cedula_usuario)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula_usuario = cedula_usuario;
        }

        public int Id
        {
            get { return id; } set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; } set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; } set { apellido = value; }
        }

        public string Cedula_Usuario
        {
            get { return  cedula_usuario; } set {  cedula_usuario = value;}
        }

        /**
         * Método para la lista de las más votadas
         **/
        public DataTable GetListaVotos()
        {
            try
            {
                string nombreStoredProcedure = "SP_CONSULTAR_TOTAL_VOTOS";

                return obj_capa_datos.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de votos." + e.Message);
            }
        }

        /**
         * Método para crear la votación
         **/
        public bool CrearVoto(CN_Usuario user)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_VOTO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@cedula", user.Cedula)

                };

                return obj_capa_datos.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear voto: " + e.Message);
            }
        }
    }
}
