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

        /**
         * Método para centrar el formulario
         **/
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

        /**
         * Método para mostrar opciones según el usuario
         **/
        public void mostrarOpciones(string rol)
        {
            try
            {
                if (rol == "1")
                {
                    lblPerfil.Text = "Rol: Estudiante";
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
                    lblPerfil.Text = "Rol: Docente";
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
                    lblPerfil.Text = "Rol: Administrador";
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

        /**
         * Eventos de clic
         **/
        private void btnAddCandidata_Click(object sender, EventArgs e)
        {
            frmCandidatas frmCandidatas = new frmCandidatas();
            frmCandidatas.Show();
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
            frmVistaCandidatas pantallaVisitaCandidata = new frmVistaCandidatas();
            pantallaVisitaCandidata.Show();
        }

        private void btnConsResultados_Click(object sender, EventArgs e)
        {
            frmConsultaResultados pantallaConsultar = new frmConsultaResultados();
            pantallaConsultar.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas cerrar tu sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Close();
                frmLogin pantallaLogin = new frmLogin();
                pantallaLogin.Show();
            }
            else if (resultado == DialogResult.No)
            {

            }
        }
    }
}
