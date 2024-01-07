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
        CN_Candidatas obj_capa_negocio = new CN_Candidatas();
        CN_Galeria objGa_capa_negocio = new CN_Galeria();
        public frmGaleriaFotos()
        {
            InitializeComponent();
            dgvCandidatasInfo.CellPainting += dgvCandidatasInfo_CellPainting;
            dgvListaCadidatasConfig();
        }

        private void frmGaleriaFotos_Load(object sender, EventArgs e)
        {
            EnableCampos(false);
            dgvCandidatasInfo.AllowUserToAddRows = false;
            dgvCandidatasInfo.DataSource = obj_capa_negocio.GetListaCandidata();


            try
            {
                dgvEjemplo.DataSource = objGa_capa_negocio.GetListaGaleriaImagenes() ;

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
            dgvCandidatasInfo.RowHeadersWidth = 96;
            dgvCandidatasInfo.AllowUserToResizeColumns = false;
            dgvCandidatasInfo.AllowUserToResizeRows = false;
            dgvCandidatasInfo.AllowUserToOrderColumns = false;
            dgvCandidatasInfo.ColumnHeadersVisible = false;
            dgvCandidatasInfo.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
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

                    // Mostrar la imagen en un control PictureBox u otro componente visual si lo deseas
                    pbxFoto1.Image = Image.FromFile(rutaImagen);

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

                    pbxFoto2.Image = Image.FromFile(rutaImagen);
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

                    pbxFoto3.Image = Image.FromFile(rutaImagen);
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

                    pbxFoto4.Image = Image.FromFile(rutaImagen);
                }
            }
        }

        private void btnFoto5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|*.png";
                openFileDialog.Title = "Seleccionar una imagen";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;

                    pbxFoto5.Image = Image.FromFile(rutaImagen);
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

        private void pbxFoto5_Click(object sender, EventArgs e)
        {
            if (pbxFoto5.Image != null)
            {
                pbxMayor.Image = new Bitmap(pbxFoto5.Image);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            byte[][] imagenesBytes = new byte[5][];
            List<MemoryStream> listaDeMemoryStreams = new List<MemoryStream>();

            MemoryStream ms = new MemoryStream();
            pbxFoto1.Image.Save(ms, ImageFormat.Png);
            imagenesBytes[0] = ms.ToArray();
            listaDeMemoryStreams.Add(ms);

            MemoryStream ms2 = new MemoryStream();
            pbxFoto2.Image.Save(ms, ImageFormat.Png);
            imagenesBytes[1] = ms.ToArray();
            listaDeMemoryStreams.Add(ms2);

            MemoryStream ms3 = new MemoryStream();
            pbxFoto3.Image.Save(ms, ImageFormat.Png);
            imagenesBytes[2] = ms.ToArray();
            listaDeMemoryStreams.Add(ms3);

            MemoryStream ms4 = new MemoryStream();
            pbxFoto4.Image.Save(ms, ImageFormat.Png);
            imagenesBytes[3] = ms.ToArray();
            listaDeMemoryStreams.Add(ms4);

            MemoryStream ms5 = new MemoryStream();
            pbxFoto5.Image.Save(ms, ImageFormat.Png);
            imagenesBytes[4] = ms.ToArray();
            listaDeMemoryStreams.Add(ms5);

            foreach (MemoryStream mse in listaDeMemoryStreams)
            {
                // Realizar operaciones con cada MemoryStream, por ejemplo, convertir a bytes
                byte[] bytes = mse.ToArray();

                // Hacer algo con los bytes...
            }

        }

        private void dgvCandidatasInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EnableCampos(true);
        }

        private void CargarGridGaleria()
        {
            try
            {
                dgvEjemplo.DataSource = objGa_capa_negocio.GetListaGaleriaImagenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void EnableCampos(bool opcion)
        {
            if(opcion)
            {
                tbxTitulo.Enabled = true;
                tbxDescripcion.Enabled = true;
                btnFoto1.Enabled = true;
                btnFoto2.Enabled = true;
                btnFoto3.Enabled = true;
                btnFoto4.Enabled = true;
                btnFoto5.Enabled = true;
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
                btnFoto5.Enabled = false;
                btnGuardar.Enabled = false;
                btnEliminarTodo.Enabled = false;
            }
        }
    }
}
