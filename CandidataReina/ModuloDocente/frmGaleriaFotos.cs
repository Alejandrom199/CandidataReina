using CapaNegocio;
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

namespace CapaVisual.ModuloDocente
{
    public partial class frmGaleriaFotos : Form
    {
        CN_Candidatas obj_candidatas = new CN_Candidatas();
        CN_Fotos obj_fotos = new CN_Fotos();
        public bool isNuevo = true;
        public frmGaleriaFotos()
        {
            InitializeComponent();
            dgvCandidatasInfo.CellPainting += dgvCandidatasInfo_CellPainting;
            dgvListaCadidatasConfig();
        }

        private void frmGaleriaFotos_Load(object sender, EventArgs e)
        {

            try
            {
                EnableCampos(false);
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

        private void btnFoto1_Click(object sender, EventArgs e)
        {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Archivos de imagen|*.png";
                    openFileDialog.Title = "Seleccionar una imagen";

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtener la ruta del archivo seleccionado
                        string rutaImagen = openFileDialog.FileName;
                        try
                        {
                            pbxFoto1.Image = Image.FromFile(rutaImagen);
                        }
                        catch (Exception ex) { MessageBox.Show("Imagen no válida, seleccione otra."); }

                        // Guardar la ruta del archivo en una variable o en un campo para su posterior uso
                        // Puedes usar esta ruta para cargar la imagen en la base de datos
                        // Ejemplo: this.rutaImagenSeleccionada = rutaImagen;
                    }
                }
        }

        private void btnFoto2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.png";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;

                    try
                    {
                        pbxFoto2.Image = Image.FromFile(rutaImagen);
                    }
                    catch (Exception ex) { MessageBox.Show("Imagen no válida, seleccione otra."); }
                }
            }
        }

        private void btnFoto3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.png";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;

                    try
                    {
                        pbxFoto3.Image = Image.FromFile(rutaImagen);
                    }
                    catch (Exception ex) { MessageBox.Show("Imagen no válida, seleccione otra."); }
                }
            }
        }

        private void btnFoto4_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.png";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;

                    try
                    {
                        pbxFoto4.Image = Image.FromFile(rutaImagen);
                    }
                    catch (Exception ex) { MessageBox.Show("Imagen no válida, seleccione otra."); }
                }
            }
        }

        private void pbxFoto1_Click(object sender, EventArgs e)
        {
            if (pbxFoto1.Image != null)
            {
                pbxMayor.Image = new Bitmap(pbxFoto1.Image);
            }
        }

        private void pbxFoto2_Click(object sender, EventArgs e)
        {
            if (pbxFoto2.Image != null)
            {
                pbxMayor.Image = new Bitmap(pbxFoto2.Image);
            }
        }

        private void pbxFoto3_Click(object sender, EventArgs e)
        {
            if (pbxFoto3.Image != null)
            {
                pbxMayor.Image = new Bitmap(pbxFoto3.Image);
            }
        }

        private void pbxFoto4_Click(object sender, EventArgs e)
        {
            if (pbxFoto4.Image != null)
            {
                pbxMayor.Image = new Bitmap(pbxFoto4.Image);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén las imágenes de los PictureBox
                byte[] imagen1 = ImageToByteArray(pbxFoto1.Image);
                byte[] imagen2 = ImageToByteArray(pbxFoto2.Image);
                byte[] imagen3 = ImageToByteArray(pbxFoto3.Image);
                byte[] imagen4 = ImageToByteArray(pbxFoto4.Image);

                // Crea una instancia de CN_Fotos con las imágenes
                CN_Fotos fotos = new CN_Fotos();

                if (dgvCandidatasInfo.SelectedRows.Count > 0)
                {
                    fotos.Id_Candidata = Convert.ToInt32(dgvCandidatasInfo.SelectedRows[0].Cells["id"].Value);
                }

                fotos.Titulo = tbxTitulo.Text;
                fotos.Descripcion = tbxDescripcion.Text;
                fotos.Imagen1 = imagen1;
                fotos.Imagen2 = imagen2;
                fotos.Imagen3 = imagen3;
                fotos.Imagen4 = imagen4;


                // Llama al método AgregarImagenes de tu capa de negocios
                bool resultado = obj_fotos.AgregarImagenes(fotos);

                if (resultado)
                {
                    MessageBox.Show("Imágenes guardadas exitosamente.");
                }
                else
                {
                    MessageBox.Show("Error al guardar las imágenes.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            // Convierte una imagen a un array de bytes
            if (image == null) return null;

            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Png); // Puedes ajustar el formato de imagen según tus necesidades
                return ms.ToArray();
            }
        }

        int candidataId;
        private void dgvCandidatasInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbxMayor.Image = null;
            EnableCampos(true);
            candidataId = Convert.ToInt32(dgvCandidatasInfo.SelectedRows[0].Cells["id"].Value);
            if (candidataId != -1)
            {
                try
                {
                    List<CN_Fotos> fotos = obj_fotos.ObtenerFotosPorCandidata(candidataId);
                    MostrarFotosEnPictureBox(fotos);
                    if(pbxFoto1.Image != null && pbxFoto2.Image != null && pbxFoto3.Image != null && pbxFoto4.Image != null)
                    {
                        btnGuardar.Enabled = false;
                        btnEliminarTodo.Enabled = true;
                    }else
                    {
                        btnGuardar.Enabled = true;
                        btnEliminarTodo.Enabled = false;
                    }
                }
                catch (Exception ex)
                {
                    if (pbxFoto1.Image == null && pbxFoto2.Image == null && pbxFoto3.Image == null && pbxFoto4.Image == null)
                    {
                        btnGuardar.Enabled = true;
                        btnEliminarTodo.Enabled = false;
                    }

                    MessageBox.Show("Esta candidata no contiene fotos.");
                }
            }
        }

        private void EnableCampos(bool opcion)
        {
            if (opcion)
            {
                tbxTitulo.Enabled = true;
                tbxDescripcion.Enabled = true;
                btnFoto1.Enabled = true;
                btnFoto2.Enabled = true;
                btnFoto3.Enabled = true;
                btnFoto4.Enabled = true;
                btnGuardar.Enabled = true;
                btnEliminarTodo.Enabled = true;
            }
            else
            {
                tbxTitulo.Enabled = false;
                tbxDescripcion.Enabled = false;
                btnFoto1.Enabled = false;
                btnFoto2.Enabled = false;
                btnFoto3.Enabled = false;
                btnFoto4.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminarTodo.Enabled = false;
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

        private void btnEliminarTodo_Click(object sender, EventArgs e)
        {

            if (candidataId > 0)
            {
                try
                {
                    CN_Fotos fotosAEliminar = new CN_Fotos();
                    fotosAEliminar.Id_Candidata = candidataId;

                    if (obj_fotos.EliminarFotos(fotosAEliminar))
                    {
                        MessageBox.Show("Fotos eliminadas!");
                    }
                    else
                    {
                        MessageBox.Show("Registro no pudo ser eliminado!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar fotos: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una candidata antes de eliminar.");
            }
        }
    }
}
