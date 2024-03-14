using CapaNegocio.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVisual.ModuloEstudiante
{
    public partial class frmVistaCandidatas : Form
    {
        CN_Candidata obj_candidatas = new CN_Candidata();
        CN_Fotos obj_fotos = new CN_Fotos();
        public frmVistaCandidatas()
        {
            InitializeComponent();
            centrarFormulario();
            dgvCandidatasInfo.CellPainting += dgvCandidatasInfo_CellPainting;
            dgvListaCadidatasConfig();
        }

        public void centrarFormulario()
        {
            StartPosition = FormStartPosition.Manual;

            Location = new Point(
                (Screen.PrimaryScreen.Bounds.Width - Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - Height) / 2
            );
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
            int mitadAlto = dgvCandidatasInfo.Height / 4;
            int mitadAncho = dgvCandidatasInfo.Width / 3;

            for (int i = 0; i < valor; i++)
            {
                if (i != 0 && i != 1 && i != 12)
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
            try
            {
                CN_Candidata candidata = new CN_Candidata();
                candidata.Id = Convert.ToInt32(dgvCandidatasInfo.SelectedRows[0].Cells["id"].Value);

                DataRow dataRow = obj_candidatas.getCandidataById(candidata);

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
                            pbxMaster.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Si la imagen está vacía, podrías establecer un valor predeterminado o dejar el PictureBox vacío.
                        pbxMaster.Image = null;
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

        private string CarreraValorToValor(string carrera)
        {
            if (carrera == "1") { return "CIVIL"; }
            else if (carrera == "2") { return "SOFTWARE"; }
            else if (carrera == "3") { return "TICS"; }
            else { return "NULL"; }
        }

        int candidataId;

        private void dgvCandidatasInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CN_Candidata candidata = new CN_Candidata();
                candidata.Id = Convert.ToInt32(dgvCandidatasInfo.SelectedRows[0].Cells["id"].Value);

                DataRow dataRow = obj_candidatas.getAllCandidataById(candidata);

                if (dataRow != null)
                {
                    // Mostrar los valores en los controles de tu formulario
                    tbxNombre.Text = dataRow["nombre"].ToString();
                    tbxApellidos.Text = dataRow["apellidos"].ToString();
                    tbxEdad.Text = dataRow["edad"].ToString();
                    tbxTelefono.Text = dataRow["telefono"].ToString();
                    tbxProvincia.Text = dataRow["provincia"].ToString();
                    tbxCarrera.Text = CarreraValorToValor(dataRow["id_carrera"].ToString());
                    tbxSemestre.Text = dataRow["semestre"].ToString();
                    tbxPasatiempos.Text = dataRow["pasatiempos"].ToString();
                    tbxHabilidades.Text = dataRow["habilidades"].ToString();
                    tbxAspiraciones.Text = dataRow["aspiraciones"].ToString();
                    tbxIntereses.Text = dataRow["intereses"].ToString();

                    byte[] imagenBytes = (byte[])dataRow["imagen"];
                    if (imagenBytes != null && imagenBytes.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(imagenBytes))
                        {
                            pbxMaster.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        // Si la imagen está vacía, podrías establecer un valor predeterminado o dejar el PictureBox vacío.
                        pbxMaster.Image = null;
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

            candidataId = Convert.ToInt32(dgvCandidatasInfo.SelectedRows[0].Cells["id"].Value);
            if (candidataId != -1)
            {
                try
                {
                    List<CN_Fotos> fotos = obj_fotos.ObtenerFotosPorCandidata(candidataId);
                    MostrarFotosEnPictureBox(fotos);
                    
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void MostrarFotosEnPictureBox(List<CN_Fotos> fotos)
        {
            // Limpia las imágenes anteriores
            pbxFoto1.Image = null;
            pbxFoto2.Image = null;
            pbxFoto3.Image = null;
            pbxFoto4.Image = null;

            pbxFoto1.Image = ByteArrayToImage(fotos[0].Imagen1);
            pbxFoto2.Image = ByteArrayToImage(fotos[0].Imagen2);
            pbxFoto3.Image = ByteArrayToImage(fotos[0].Imagen3);
            pbxFoto4.Image = ByteArrayToImage(fotos[0].Imagen4);

            tbxTitulo.Text = fotos[0].Titulo;
            tbxDescripcion.Text = fotos[0].Descripcion;
        }

        //Metodo para transformar bytes a imagen
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null || byteArrayIn.Length == 0)
            {
                return null;
            }

            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
    }
}
