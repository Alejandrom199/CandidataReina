using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class Usuario
    {
        private string nombres;
        private string username;
        private string email;
        private string clave;
        private bool estado;
        private string perfilUsuario;

        public Usuario()
        {
            nombres = string.Empty;
            username = string.Empty;
            email = string.Empty;
            clave = string.Empty;
            estado = false;
        }

        public Usuario(string nombres, string username, string clave, string email, bool estado, string perfilUsuario)
        {
            nombres = nombres;
            username = username;
            email = email;
            clave = clave;
            estado = estado;
            perfilUsuario = perfilUsuario;
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
        public List<Usuario> getListaUsuarios()
        {
            try
            {

                return null;
                //return obj_capa_datos.EjecutarSelect("SELECT * FROM tb_Usuarios");

            }
            catch (Exception e)
            {
                throw new Exception("Error");
            }
        }
    }
}
