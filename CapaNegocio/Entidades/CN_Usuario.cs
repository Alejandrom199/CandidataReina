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
    public class CN_Usuario
    {
        private ManageSQL obj_capa_datos = new ManageSQL();
        private string cedula;
        private string nombres;
        private string username;
        private string email;
        private string clave;
        private bool estado;
        private string perfilUsuario;

        public CN_Usuario()
        {
            cedula = string.Empty;
            nombres = string.Empty;
            username = string.Empty;
            email = string.Empty;
            clave = string.Empty;
            estado = false;
        }

        public CN_Usuario(string cedula, string nombres, string username, string clave, string email, bool estado, string perfilUsuario)
        {
            cedula = cedula;
            nombres = nombres;
            username = username;
            email = email;
            clave = clave;
            estado = estado;
            perfilUsuario = perfilUsuario;
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }
        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public string PerfilUsuario
        {
            get { return perfilUsuario; }
            set { perfilUsuario = value; }
        }

        public bool ValidarUsuario(CN_Usuario usuario)
        {
            try
            {
                string nombreStoredProcedure = "SP_VALIDAR_USER";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@username", usuario.username ),
                    new SqlParameter("@clave", usuario.clave)
                };

                return obj_capa_datos.EjecutarSPValidarCredenciales(nombreStoredProcedure, parametros);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al validar usuario: " + ex.Message);
            }
        }

        public string ObtenerCedulaPorUsuario(CN_Usuario user)
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_CEDULA_USER";

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@username", user.Username)
                };

                return obj_capa_datos.ObtenerDatoPorUsuario(nombreStoredProcedure, parametros,"cedula");
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public string ObtenerRolPorUsuario(CN_Usuario user)
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_ROL_USER";

                SqlParameter[] parametros = new SqlParameter[]
                {
                     new SqlParameter("@username", user.Username)
                };

                return obj_capa_datos.ObtenerDatoPorUsuario(nombreStoredProcedure, parametros,"id_rol");
            }
            catch (Exception ex)
            {
                // Manejar otras excepciones generales
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }

        public bool Votar(string nombre, string apellido, string cedula)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREAR_VOTO";

                // Llamar al método en la capa de datos
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@nombre", nombre),
                new SqlParameter("@apellido", apellido),
                new SqlParameter("@cedula_usuario", cedula)
                };

                return obj_capa_datos.CrearVoto(nombreStoredProcedure, parametros);
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus requisitos
                Console.WriteLine($"Error al votar: {ex.Message}");
                return false;
            }
        }

        // Método para obtener el estado de votación
        public bool ObtenerEstadoVotacion(string cedula)
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_ESTADO_VOTACION";

                // Llamar al método en la capa de datos
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@cedula_usuario", cedula)
                };

                return obj_capa_datos.ObtenerEstadoVotacion(nombreStoredProcedure, parametros);
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus requisitos
                Console.WriteLine($"Error al obtener el estado de votación: {ex.Message}");
                return false;
            }
        }
    }
}
