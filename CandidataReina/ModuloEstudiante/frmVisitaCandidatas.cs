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
    public partial class frmVisitaCandidatas : Form
    {
        CN_Candidatas obj_candidatas = new CN_Candidatas();
        private VScrollBar vScrollBar1;
        public frmVisitaCandidatas()
        {
            InitializeComponent();
            dgvCandidatasInfo.CellPainting += dgvCandidatasInfo_CellPainting;
            dgvListaCadidatasConfig();
        }

        private void frmVisitaCandidatas_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCandidatasInfo.AllowUserToAddRows = false;
                dgvCandidatasInfo.DataSource = obj_candidatas.GetListaCandidata();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int valor = dgvCandidatasInfo.ColumnCount;
            int mitadAlto = dgvCandidatasInfo.Height / 3;
            int mitadAncho = dgvCandidatasInfo.Width / 2;

            for (int i = 0; i < valor; i++)
            {
                if (i != 1 && i != 12)
                {
                    dgvCandidatasInfo.Columns[i].Visible = false;

                }
            }
            foreach (DataGridViewRow fila in dgvCandidatasInfo.Rows)
            {
                fila.Height = mitadAlto;

                foreach (DataGridViewColumn columna in dgvCandidatasInfo.Columns)
                {
                    columna.Width = mitadAncho;

                }
            }
        }


        private void dgvCandidatasInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*try
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
            }*/
        }

        private void dgvCandidatasInfo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvCandidatasInfo.Columns[12].Index)
            {
                // Obtén la imagen original en formato byte[]
                byte[] datosImagen = (byte[])dgvCandidatasInfo[12, e.RowIndex].Value;

                // Convierte los datos en byte[] a una imagen
                Image imagenOriginal;
                using (MemoryStream ms = new MemoryStream(datosImagen))
                {
                    imagenOriginal = Image.FromStream(ms);
                }

                // Obtén las dimensiones de la celda
                int celdaAncho = e.CellBounds.Width;
                int celdaAlto = e.CellBounds.Height;

                // Dibuja la imagen en la celda utilizando el modo StretchImage
                e.Graphics.DrawImage(imagenOriginal, e.CellBounds, new Rectangle(0, 0, imagenOriginal.Width, imagenOriginal.Height), GraphicsUnit.Pixel);

                // Indica que la celda ha sido pintada, evitando que el valor original se dibuje
                e.Handled = true;

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListaCadidatasConfig()
        {
            dgvCandidatasInfo.AllowUserToResizeColumns = false;
            dgvCandidatasInfo.AllowUserToResizeRows = false;
            dgvCandidatasInfo.AllowUserToOrderColumns = false;
            dgvCandidatasInfo.ColumnHeadersVisible = false;
            dgvCandidatasInfo.RowHeadersVisible = false;
            dgvCandidatasInfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvCandidatasInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
