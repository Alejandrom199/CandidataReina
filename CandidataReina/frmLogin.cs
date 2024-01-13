using CapaDatos;
using CapaNegocio;
using CapaNegocio.Entidades;
using CapaVisual;
using CapaVisual.ModuloEstudiante;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CandidataReina
{
    public partial class frmLogin : Form
    {
        CN_Usuario obj_usuario = new CN_Usuario();
        
        public bool flagVerClave;
        public frmLogin()
        {
            InitializeComponent();
            centrarFormulario();
            MaximizeBox = false;

            tbxClave.PasswordChar = '*';
            flagVerClave = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CN_Usuario user = new CN_Usuario();
            user.Username = tbxUsername.Text;
            user.Clave = tbxClave.Text;

            if (obj_usuario.ValidarUsuario(user))
            {
                // Ahora que has validado el usuario, asigna el nombre de usuario al objeto obj_usuario
                obj_usuario.Username = user.Username;

                // Llama al método ObtenerCedulaPorUsuario y muestra la cédula
                string cedula = obj_usuario.ObtenerCedulaPorUsuario(obj_usuario);
                string rol = obj_usuario.ObtenerRolPorUsuario(obj_usuario);

                if (cedula != null || rol != null)
                {
                    // Continúa con el flujo de tu aplicación
                    frmOpciones pantallaOpciones = new frmOpciones();
                    pantallaOpciones.Cedula = cedula;
                    pantallaOpciones.Id_Rol = rol;


                    pantallaOpciones.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("No se pudo obtener la cédula del usuario.");
                }
            }
            else
            {
                MessageBox.Show("Credenciales inválidas");
            }
        }

        public void centrarFormulario()
        {
            StartPosition = FormStartPosition.Manual;
            Location = new Point(
                (Screen.PrimaryScreen.Bounds.Width - Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - Height) / 2
            );
        }

        public string MostrarRol(CN_Usuario user)
        {
            if (Convert.ToInt32(user.PerfilUsuario) == 1) { return "Estudiante"; }
            else if (Convert.ToInt32(user.PerfilUsuario) == 2) { return "Gestor"; }
            else { return "Administrador"; }
        }

        private void btnVerClave_Click(object sender, EventArgs e)
        {
            
            if(flagVerClave){
                tbxClave.PasswordChar = '\0';
                flagVerClave = false;
            }else
            {
                tbxClave.PasswordChar = '*';
                flagVerClave = true;
            }
        }
    }
}
