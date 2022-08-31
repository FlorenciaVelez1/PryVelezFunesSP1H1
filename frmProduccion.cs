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
namespace PryVelezFunesSP1H1
{
    public partial class frmProduccion : Form
    {
        public frmProduccion()
        {
            InitializeComponent();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            mskDate.Text = "";
            mskCantidad.Text = "";
            lstCultivo.SelectedIndex = 0;
            lstLocalidad.SelectedIndex = 0; 
        }
    }
}
