using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryVelezFunesSP1H1
{
    public partial class frmAgricultura : Form
    {
        public frmAgricultura()
        {
            InitializeComponent();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalidad Localidad = new frmLocalidad();
            Localidad.ShowDialog();
        }
        private void cultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCultivos Cultivos = new frmCultivos();
            Cultivos.ShowDialog();
        }
        private void producciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduccion Produccion = new frmProduccion();
            Produccion.ShowDialog();
        }
        private void localidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaLocalidades ConsultaLocalidades = new frmConsultaLocalidades();
            ConsultaLocalidades.ShowDialog();
        }
        private void cultivosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCultivos ConsultaCultivo = new frmConsultaCultivos();
            ConsultaCultivo.ShowDialog();
        }
        private void producciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaProduccion ConsultaProduccion = new frmConsultaProduccion();
            ConsultaProduccion.ShowDialog();
        }
    }
}
