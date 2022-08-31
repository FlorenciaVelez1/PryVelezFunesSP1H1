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
    public partial class frmLocalidad : Form
    {
        public frmLocalidad()
        {
            InitializeComponent();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            mskIdentificador.Text = "";
            txtLocalidad.Text = "";
        }
        private void txtLocalidad_TextChanged(object sender, EventArgs e)
        {
            if (mskIdentificador.Text != "" & txtLocalidad.Text != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }
        private void mskIdentificador_TextChanged(object sender, EventArgs e)
        {
            if (mskIdentificador.Text != "" & txtLocalidad.Text != "")
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
            StreamWriter Localidad = new StreamWriter("./localidades.txt", true);
            Localidad.WriteLine(mskIdentificador.Text + " " + txtLocalidad.Text);
            MessageBox.Show("Se han cargado correctamente los datos ingresados.");
            Localidad.Close();
            txtLocalidad.Text = "";
            mskIdentificador.Text = "";
        }
    }
}
