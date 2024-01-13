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

namespace CapaVisual.ModuloDocente
{
    public partial class frmConsultaResultados : Form
    {
        CN_Voto obj_voto = new CN_Voto();
        public frmConsultaResultados()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            //Rellenar todo el datagridview ampliando las columnas
            dgvCandidatas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void frmConsultaResultados_Load(object sender, EventArgs e)
        {
            try
            {
                CargarGridCandidatas();
            }
            catch (Exception ex) { }
        }

        private void CargarGridCandidatas()
        {
            try
            {
                dgvCandidatas.DataSource = obj_voto.GetListaVotos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
