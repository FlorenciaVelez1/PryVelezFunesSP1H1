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
        private void frmProduccion_Load(object sender, EventArgs e)
        {
            //Se agregan a los lst los datos anteriormente registrados
            StreamReader LectorLocalidades = new StreamReader("./Localidades.txt");
            while (!LectorLocalidades.EndOfStream)
            {
                string Informacion = LectorLocalidades.ReadLine();
                lstLocalidad.Items.Add(Informacion.Substring(6));
            }
            LectorLocalidades.Close();
            StreamReader LectorCultivo = new StreamReader("./Cultivos.txt");
            while (!LectorCultivo.EndOfStream)
            {
                string Informacion = LectorCultivo.ReadLine();
                lstCultivo.Items.Add(Informacion.Substring(6));
            }
            LectorCultivo.Close();
        }
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            StreamWriter Produccion = new StreamWriter("./Produccion.txt", true);
            Produccion.WriteLine(mskDate.Text + "," + lstLocalidad.SelectedItem + "," + lstCultivo.SelectedItem + "," + mskCantidad.Text);
            MessageBox.Show("Se han cargado correctamente los datos ingresados.");
            Produccion.Close();
            mskDate.Text = "";
            lstLocalidad.SelectedIndex = -1;
            lstCultivo.SelectedIndex = -1;
            mskCantidad.Text = "";
        }
    }
}
