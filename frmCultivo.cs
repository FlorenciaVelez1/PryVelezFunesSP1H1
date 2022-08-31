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
    public partial class frmCultivos : Form
    {
        public frmCultivos()
        {
            InitializeComponent();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            mskIdentificador.Text = "";
            txtCultivo.Text = "";
        }
        private void mskIdentidicador_TextChanged(object sender, EventArgs e)
        {
            if (txtCultivo.Text != "" & mskIdentificador.MaskCompleted)
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }
        private void txtCultivo_TextChanged(object sender, EventArgs e)
        {
            if (txtCultivo.Text != "" & mskIdentificador.MaskCompleted)
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            StreamWriter Cultivo = new StreamWriter("./cultivos.txt", true);
            Cultivo.WriteLine(mskIdentificador.Text + " " + txtCultivo.Text);
            MessageBox.Show("Se han cargado correctamente los datos ingresados.");
            Cultivo.Close();
            txtCultivo.Text = "";
            mskIdentificador.Text = "";
        }
    }
}
