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
            bool chequeo = false;
            if (File.Exists("./Cultivos.txt"))
            {
                StreamReader srControlCultivo = new StreamReader("./Cultivos.txt");
                while (!srControlCultivo.EndOfStream)
                {
                    string auxCultivos = srControlCultivo.ReadLine();
                    string[] Cultivos = auxCultivos.Split(',');
                    if (mskIdentificador.Text == Cultivos[0])
                    {
                        MessageBox.Show("El ID del cultivo se ha repetido, intentelo nuevamente");
                        mskIdentificador.Text = "";
                        mskIdentificador.Focus();
                        chequeo = true;
                    }
                }
                srControlCultivo.Close();
            }
            if(chequeo == false)
            {
                StreamWriter Cultivo = new StreamWriter("./Cultivos.txt", true);
                Cultivo.WriteLine(mskIdentificador.Text + "," + txtCultivo.Text);
                MessageBox.Show("Se han cargado correctamente los datos ingresados.");
                Cultivo.Close();
                txtCultivo.Text = "";
                mskIdentificador.Text = "";
            }
            
        }
    }
}
