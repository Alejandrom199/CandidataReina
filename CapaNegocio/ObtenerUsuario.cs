using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Globalization;

namespace CapaNegocio
{
    public class ObtenerUsuario
    {
        
        private ManageSQL manejoSql = new ManageSQL();

        public bool ValidarCredenciales(string username, string clave)
        {
            return manejoSql.ValidarCredenciales(username, clave);
        }

        public Usuario retornarCredencialesUser(string username, string clave)
        {
            return manejoSql.retornarUserObjecto(username, clave);
        }

    }
}
