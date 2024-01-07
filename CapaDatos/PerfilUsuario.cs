using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class PerfilUsuario
    {
        private string[] perfilesUsuario = { "administrador", "gestor", "estudiante" };

        public string[] PerfilesUsuario
        {
            get { return perfilesUsuario; }
            set { perfilesUsuario = value; }
        }
    }
}
