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
        CN_Candidatas obj_candidata = new CN_Candidatas();
        public frmVotacion()
        {
            InitializeComponent();
        }

        private void frmVotacion_Load(object sender, EventArgs e)
        {
            InitCampos();
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
                CN_Candidatas candidata = new CN_Candidatas();
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
                        // Si la imagen está vacía, podrías establecer un valor predeterminado o dejar el PictureBox vacío.
                        pbxFotoCandidata.Image = null;
                    }
                }
                else
                {
                    // No se encontraron resultados para el id proporcionado.
                    MessageBox.Show("No se encontraron datos para el id proporcionado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar datos: " + ex.Message);
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
    }
}
