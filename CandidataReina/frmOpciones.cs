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

namespace CapaVisual
{
    public partial class frmOpciones : Form
    {
        private string recibeUsername;
        public frmOpciones()
        {
            InitializeComponent();
            centrarFormulario();
            lblUsuario.Text = "Hola " + recibeUsername + "!!";
            MaximizeBox = false;
            FormClosed += frmOpciones_FormClosed;
        }

        public string RecibeUsername
        {
            get { return lblUsuario.Text; }
            set { lblUsuario.Text = value; }
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
            frmLogin formLogin = new frmLogin();
            string rolUser = formLogin.RolUser.ToString();
            mostrarOpciones(rolUser);

        }

        public void mostrarOpciones(string rol)
        {
            try
            {
                if (rol == "Estudiante")
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

                else if (rol == "Gestor")
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
            catch (Exception ex)
            {

            }

        }

        private void btnAddCandidata_Click(object sender, EventArgs e)
        {
            frmCandidatasCrud frmCandidatas = new frmCandidatasCrud();
            frmCandidatas.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmOpciones_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
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
            pantallaVotaciones.Show();
        }

        private void btnVisitCandidatas_Click(object sender, EventArgs e)
        {
            frmVisitaCandidatas pantallaVisitaCandidata = new frmVisitaCandidatas();
            pantallaVisitaCandidata.Show();
        }
    }
}
