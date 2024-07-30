using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using CapaNegocio.Entidades;

namespace CapaVisual
{
    public partial class frmCandidatas : Form
    {
        CN_Candidata obj_capa_negocio = new CN_Candidata(); 


        public frmCandidatas()
        {
            InitializeComponent();
            centrarFormulario();
            btnCancelar.Enabled = true;
            MaximizeBox = false;
            btnExaminar.Enabled = false;
        }

        public void centrarFormulario()
        {
            StartPosition = FormStartPosition.Manual;

            Location = new Point(
                (Screen.PrimaryScreen.Bounds.Width - Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - Height) / 2
            );
        }

        /**
         * Método para Habilidar o Deshabilitar campos
         **/
        private void DisableCampos(bool valor)
        {
            if (valor)
            {
                tbxId.Enabled = false;
                tbxNombre.Enabled = false;
                tbxApellidos.Enabled = false;
                tbxEdad.Enabled = false;
                tbxTelefono.Enabled = false;
                cbxProvincia.Enabled = false;
                cbxCarrera.Enabled = false;
                cbxSemestre.Enabled = false;
                tbxPasatiempos.Enabled = false;
                tbxHabilidades.Enabled = false;
                tbxAspiraciones.Enabled = false;
                tbxIntereses.Enabled = false;
                tbxApellidos.Enabled = false;
            }
            else
            {
                tbxId.Enabled = true;
                tbxNombre.Enabled = true;
                tbxApellidos.Enabled = true;
                tbxEdad.Enabled = true;
                tbxTelefono.Enabled = true;
                cbxProvincia.Enabled = true;
                cbxCarrera.Enabled = true;
                cbxSemestre.Enabled = true;
                tbxPasatiempos.Enabled = true;
                tbxHabilidades.Enabled = true;
                tbxAspiraciones.Enabled = true;
                tbxIntereses.Enabled = true;
                tbxApellidos.Enabled = true;
            }
        }
        private void frmCandidatasCrud_Load(object sender, EventArgs e)
        {

            try
            {
                dgvCandidatas.AllowUserToAddRows = false;
                dgvCandidatas.DataSource = obj_capa_negocio.GetListaCandidata();
                dgvCandidatas.Columns[12].Visible = false;

                DisableCampos(true);

                btnNuevo.Enabled = true;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnCancelar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivos de imagen|*.png;|Todos los archivos|*.*";

            // Muestra el cuadro de diálogo
            DialogResult result = file.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    pbxCandidata.Image = Image.FromFile(file.FileName);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message);
                }
            }
        }


        private bool isNuevo;
        CN_Candidata obj_cn_candidatas = new CN_Candidata();

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            isNuevo = true;
            SetearCampos();

            btnNuevo.Enabled = false;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            btnExaminar.Enabled = true;

            DisableCampos(false);

        }

        /**
         * Método para setear o encerar valores
         **/
        private void SetearCampos()
        {
            tbxId.Text = string.Empty;
            tbxNombre.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            tbxEdad.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
            cbxProvincia.Text = string.Empty;
            cbxCarrera.Text = string.Empty;
            cbxSemestre.Text = string.Empty;
            tbxPasatiempos.Text = string.Empty;
            tbxHabilidades.Text = string.Empty;
            tbxAspiraciones.Text = string.Empty;
            tbxIntereses.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            pbxCandidata.Image = null;
        }

        /**
         * Método para actualizar el DataGridView
         **/
        private void CargarGridCandidatas()
        {
            try
            {
                dgvCandidatas.DataSource = obj_capa_negocio.GetListaCandidata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (isNuevo)
            {
                try
                {
                    obj_cn_candidatas.Nombre = tbxNombre.Text;
                    obj_cn_candidatas.Apellidos = tbxApellidos.Text;

                    try { obj_cn_candidatas.Edad = Convert.ToInt32(tbxEdad.Text); }
                    catch (FormatException ex) { MessageBox.Show("El valor de edad es númerico"); return; }

                    if (tbxTelefono.Text.Length == 10) { obj_cn_candidatas.Telefono = tbxTelefono.Text; }
                    else { MessageBox.Show("El número de telefono solo puede tener 10 caracteres"); return; }

                    obj_cn_candidatas.Provincia = cbxProvincia.Text;
                    obj_cn_candidatas.Semestre = Convert.ToInt32(cbxSemestre.Text);
                    obj_cn_candidatas.Id_Carrera = CarreraValorToNum(cbxCarrera.Text);
                    obj_cn_candidatas.Pasatiempos = tbxPasatiempos.Text;
                    obj_cn_candidatas.Habilidades = tbxHabilidades.Text;
                    obj_cn_candidatas.Intereses = tbxIntereses.Text;
                    obj_cn_candidatas.Aspiraciones = tbxAspiraciones.Text;

                    try
                    {
                        MemoryStream ms = new MemoryStream();

                        if(pbxCandidata.Image != null)
                        {
                            pbxCandidata.Image.Save(ms, ImageFormat.Png);
                            obj_cn_candidatas.ImagenByte = ms.ToArray();
                        }
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show("Imagen Nula");
                    }

                    var resultado = obj_cn_candidatas.CrearCandidata(obj_cn_candidatas);

                    if (resultado)
                    {
                        MessageBox.Show("Registro Creado con Éxito.");
                        CargarGridCandidatas();
                        DisableCampos(true);

                        btnExaminar.Enabled = false;

                        btnNuevo.Enabled = true;
                        btnAgregar.Enabled = false;
                        btnModificar.Enabled = false;
                        btnEliminar.Enabled = false;
                    }
                    else { }

                    isNuevo = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Rellene todos los datos");
                }

            }

        }

        private void dgvCandidatas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisableCampos(false);
            btnExaminar.Enabled = true;
            isNuevo = false;

            if (e.RowIndex != -1)
            {
                tbxId.Text = dgvCandidatas.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxNombre.Text = dgvCandidatas.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbxApellidos.Text = dgvCandidatas.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxEdad.Text = dgvCandidatas.Rows[e.RowIndex].Cells[3].Value.ToString();
                tbxTelefono.Text = dgvCandidatas.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbxProvincia.Text = dgvCandidatas.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbxPasatiempos.Text = dgvCandidatas.Rows[e.RowIndex].Cells[6].Value.ToString();
                tbxHabilidades.Text = dgvCandidatas.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbxIntereses.Text = dgvCandidatas.Rows[e.RowIndex].Cells[8].Value.ToString();
                tbxAspiraciones.Text = dgvCandidatas.Rows[e.RowIndex].Cells[9].Value.ToString();
                cbxSemestre.Text = dgvCandidatas.Rows[e.RowIndex].Cells[10].Value.ToString();
                cbxCarrera.Text = CarreraValorToValor(dgvCandidatas.Rows[e.RowIndex].Cells[11].Value.ToString());

                try
                {
                    byte[] imagenBytes = (byte[])dgvCandidatas.Rows[e.RowIndex].Cells[12].Value;
                    MostrarImagen(imagenBytes);
                } catch (Exception ex) { }


                btnNuevo.Enabled = false;
                btnAgregar.Enabled = false;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else { }

        }

        /**
         * Método para mostrar la imagenes del arreglo de bytes
         **/
        private void MostrarImagen(byte[] imagenBytes)
        {
            if (imagenBytes != null && imagenBytes.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(imagenBytes))
                {
                    pbxCandidata.Image = Image.FromStream(ms);
                }
            }
            else
            {
                // Puedes mostrar una imagen predeterminada o dejar el PictureBox vacío
                pbxCandidata.Image = null;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!isNuevo)
            {
                obj_cn_candidatas.Id = Convert.ToInt16(tbxId.Text);
                obj_cn_candidatas.Nombre = tbxNombre.Text;
                obj_cn_candidatas.Apellidos = tbxApellidos.Text;
                obj_cn_candidatas.Edad = Convert.ToInt32(tbxEdad.Text);
                obj_cn_candidatas.Telefono = tbxTelefono.Text;
                obj_cn_candidatas.Provincia = cbxProvincia.Text;
                obj_cn_candidatas.Semestre = Convert.ToInt32(cbxSemestre.Text);
                obj_cn_candidatas.Id_Carrera = CarreraValorToNum(cbxCarrera.Text);
                obj_cn_candidatas.Pasatiempos = tbxPasatiempos.Text;
                obj_cn_candidatas.Habilidades = tbxHabilidades.Text;
                obj_cn_candidatas.Intereses = tbxIntereses.Text;
                obj_cn_candidatas.Aspiraciones = tbxAspiraciones.Text;

                MemoryStream ms = new MemoryStream();
                pbxCandidata.Image.Save(ms, ImageFormat.Png);
                obj_cn_candidatas.ImagenByte = ms.ToArray();

                if (obj_cn_candidatas.ModificarCandidata(obj_cn_candidatas))
                {
                    MessageBox.Show("Registro actualizado!");
                    CargarGridCandidatas();
                    DisableCampos(true);

                    btnNuevo.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser actualizado!");
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            obj_cn_candidatas.Id = Convert.ToInt16(tbxId.Text);

            try
            {
                if (obj_cn_candidatas.EliminarCandidata(obj_cn_candidatas))
                {
                    MessageBox.Show("Registro eliminado!");
                    CargarGridCandidatas();

                    btnNuevo.Enabled = true;
                    btnAgregar.Enabled = false;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                    DisableCampos(true);
                }
                else
                {
                    MessageBox.Show("Registro no pudo ser eliminado!");
                }
            }catch(Exception ex) { MessageBox.Show("Primero debes eliminar las fotografias de la candidata"); }

        }

        /**
         * Métodos de transformación de información
         **/
        private int CarreraValorToNum(string carrera)
        {
            if (carrera == "CIVIL") { return 1; }
            else if (carrera == "SOFTWARE") { return 2; }
            else if (carrera == "TICS") { return 3; }
            else { return -1; }
        }

        private string CarreraValorToValor(string carrera)
        {
            if (carrera == "1") { return "CIVIL"; }
            else if (carrera == "2") { return "SOFTWARE"; }
            else if (carrera == "3") { return "TICS"; }
            else { return "NULL"; }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
