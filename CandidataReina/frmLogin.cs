using CapaNegocio;
using CapaVisual;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CandidataReina
{
    public partial class frmLogin : Form
    {
        private ObtenerUsuario objUsuario = new ObtenerUsuario();
        private string username;
        private string clave;
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
            username = tbxUsername.Text;
            clave = tbxClave.Text;

            if (objUsuario.ValidarCredenciales(username, clave))
            {
                MessageBox.Show("Inicio de sesión exitoso de " + username);

                CN_Usuario user = objUsuario.retornarCredencialesUser(username, clave);

                /*if (user != null)
                {
                    MessageBox.Show("nombre: " + user.Nombres + "\n" +
                                    "username: " + user.Username + "\n" +
                                    "clave: " + user.Clave + "\n" +
                                    "Email: " + user.Email + "\n" +
                                    "estado: " + user.Estado.ToString() + "\n" +
                                    "Rol: " + user.PerfilUsuario.ToString());
                }
                else
                {
                    MessageBox.Show("Usuario nulo.");
                }*/

                MandarUsuario(user);

                Hide();
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

        private static string rolUser;
        public void MandarUsuario(CN_Usuario user)
        {
            frmOpciones frmOpciones = new frmOpciones();
            rolUser = MostrarRol(user);

            frmOpciones.RecibeUsername = "Hola " + user.Nombres + "!!\n"
                                        + "User: " + user.Username + "\n"
                                        + "Rol: " + rolUser;
            frmOpciones.Show();

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

        public string RolUser
        {
            get { return rolUser; }
        }
    }
}
