using CapaNegocio;
using CapaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual.ModuloEstudiante
{
    public partial class frmVotacion : Form
    {
        CN_Candidata obj_candidata = new CN_Candidata();
        CN_Usuario obj_usuario = new CN_Usuario();

        CN_Voto obj_voto = new CN_Voto();
        private string cedula;
        public frmVotacion()
        {
            InitializeComponent();
            centrarFormulario();
        }

        private void frmVotacion_Load(object sender, EventArgs e)
        {
            InitCampos();
        }

        public void centrarFormulario()
        {
            StartPosition = FormStartPosition.Manual;

            Location = new Point(
                (Screen.PrimaryScreen.Bounds.Width - Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - Height) / 2
            );
        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        private void InitCampos()
        {

            tbxNombre.ReadOnly = true;
            tbxApellidos.ReadOnly = true;
            tbxCarrera.ReadOnly = true;
            tbxEdad.ReadOnly = true;
            tbxPasatiempos.ReadOnly = true;
            tbxHabilidades.ReadOnly = true;
            tbxAspiraciones.ReadOnly = true;
            tbxIntereses.ReadOnly = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Candidata candidata = new CN_Candidata();
                candidata.Id = Convert.ToInt32(tbxId.Text);

                DataRow dataRow = obj_candidata.getCandidataById(candidata);

                if (dataRow != null)
                {
                    // Mostrar los valores en los controles de tu formulario
                    tbxNombre.Text = dataRow["nombre"].ToString();
                    tbxApellidos.Text = dataRow["apellidos"].ToString();
                    tbxCarrera.Text = CarreraValorToValor(dataRow["id_carrera"].ToString());
                    tbxEdad.Text = dataRow["edad"].ToString();
                    tbxPasatiempos.Text = dataRow["pasatiempos"].ToString();
                    tbxHabilidades.Text = dataRow["habilidades"].ToString();
                    tbxAspiraciones.Text = dataRow["aspiraciones"].ToString();
                    tbxIntereses.Text = dataRow["intereses"].ToString();

                    byte[] imagenBytes = (byte[])dataRow["imagen"];
                    if (imagenBytes != null && imagenBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            pbxFotoCandidata.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pbxFotoCandidata.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para el ID proporcionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese el ID de la candidata");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string CarreraValorToValor(string carrera)
        {
            if (carrera == "1") { return "CIVIL"; }
            else if (carrera == "2") { return "SOFTWARE"; }
            else if (carrera == "3") { return "TICS"; }
            else { return "NULL"; }
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = tbxNombre.Text;
                string apellido = tbxApellidos.Text;

                bool yaVoto = obj_usuario.ObtenerEstadoVotacion(Cedula);

                if (!yaVoto)
                {
                    bool resultadoVoto = obj_usuario.Votar(nombre, apellido, Cedula);

                    if (resultadoVoto)
                    {
                        MessageBox.Show("Voto registrado con éxito.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el voto.");
                    }
                }
                else
                {
                    MessageBox.Show("Este usuario ya ha votado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}