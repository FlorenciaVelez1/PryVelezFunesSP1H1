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
            //Se crea booleano para verificar que no se repita el codigo
            bool chequeo = false;
            if (File.Exists("./Localidades.txt"))
            {
                StreamReader srControlLocalidades = new StreamReader("./Localidades.txt");
                while (!srControlLocalidades.EndOfStream)
                {
                    string auxLocalidad = srControlLocalidades.ReadLine();
                    string[] Localidad = auxLocalidad.Split(',');
                    if (mskIdentificador.Text == Localidad[0])
                    {
                        MessageBox.Show("El ID de la localidad se ha repetido, intentelo nuevamente");
                        mskIdentificador.Text = "";
                        mskIdentificador.Focus();
                        chequeo = true;
                    }
                }
                srControlLocalidades.Close();
            }
            if (chequeo == false)
            { 
                StreamWriter Localidad = new StreamWriter("./Localidades.txt", true);
                Localidad.WriteLine(mskIdentificador.Text + "," + txtLocalidad.Text);
                MessageBox.Show("Se han cargado correctamente los datos ingresados.");
                Localidad.Close();
                txtLocalidad.Text = "";
                mskIdentificador.Text = "";
            }
        }
    }
}
