using CandidataReina;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVisual;
using CapaVisual.ModuloDocente;
using CapaVisual.ModuloEstudiante;
using CapaNegocio.Entidades;

namespace CapaVisual
{
    public partial class frmOpciones : Form
    {

        private string id_rol;
        private string cedula;
        public frmOpciones()
        {
            InitializeComponent();
            centrarFormulario();
            MaximizeBox = false;
            FormClosed += frmOpciones_FormClosed;

        }
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string Id_Rol
        {
            get { return id_rol; }
            set { id_rol = value; }
        }

        public void centrarFormulario()
        {
            StartPosition = FormStartPosition.Manual;

            Location = new Point(

                (Screen.PrimaryScreen.Bounds.Width - Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - Height) / 2
            );
        }

        private void FormGestor_Load(object sender, EventArgs e)
        {
            mostrarOpciones(Id_Rol);
            lblUsuario.Text = "Usuario: " + Cedula;
        }

        public void mostrarOpciones(string rol)
        {
            try
            {
                if (rol == "1")
                {
                    btnVisitCandidatas.Visible = true;
                    btnVotaciones.Visible = true;
                    btnAddCandidata.Visible = false;
                    btnConsResultados.Visible = false;
                    btnGaleria.Visible = false;

                    lblVisitaCandidatas.Visible = true;
                    lblVotaciones.Visible = true;
                    lblAddCandidatas.Visible = false;
                    lblConsulResultados.Visible = false;
                    lblGaleria.Visible = false;
                }

                else if (rol == "2")
                {
                    btnVisitCandidatas.Visible = false;
                    btnVotaciones.Visible = false;
                    btnAddCandidata.Visible = true;
                    btnConsResultados.Visible = true;
                    btnGaleria.Visible = true;

                    lblVisitaCandidatas.Visible = false;
                    lblVotaciones.Visible = false;
                    lblAddCandidatas.Visible = true;
                    lblConsulResultados.Visible = true;
                    lblGaleria.Visible = true;
                }

                else
                {
                    btnVisitCandidatas.Enabled = true;
                    btnVotaciones.Enabled = true;
                    btnAddCandidata.Enabled = true;
                    btnConsResultados.Enabled = true;

                    lblVisitaCandidatas.Visible = true;
                    lblVotaciones.Visible = true;
                    lblAddCandidatas.Visible = true;
                    lblConsulResultados.Visible = true;
                }
            }
            catch (Exception ex) { }

        }

        private void btnAddCandidata_Click(object sender, EventArgs e)
        {
            frmCandidatas frmCandidatas = new frmCandidatas();
            frmCandidatas.Show();
        }

        private void frmOpciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (resultado == DialogResult.No)
            {

            }
        }

        private void btnGaleria_Click(object sender, EventArgs e)
        {
            frmGaleriaFotos pantallaGaleriaFotos = new frmGaleriaFotos();
            pantallaGaleriaFotos.Show();
        }

        private void btnVotaciones_Click(object sender, EventArgs e)
        {
            frmVotacion pantallaVotaciones = new frmVotacion();
            pantallaVotaciones.Cedula = Cedula;
            pantallaVotaciones.Show();
        }

        private void btnVisitCandidatas_Click(object sender, EventArgs e)
        {
            frmVisitaCandidatas pantallaVisitaCandidata = new frmVisitaCandidatas();
            pantallaVisitaCandidata.Show();
        }

        private void btnConsResultados_Click(object sender, EventArgs e)
        {
            frmConsultaResultados pantallaConsultar = new frmConsultaResultados();
            pantallaConsultar.Show();
        }
    }
}
