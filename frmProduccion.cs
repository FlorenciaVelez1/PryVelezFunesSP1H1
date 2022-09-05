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
             StreamReader LectorLocalidades = new StreamReader("./localidades.txt");
            while (!LectorLocalidades.EndOfStream)
            {
                string Informacion = LectorLocalidades.ReadLine();
                lstLocalidad.Items.Add(Informacion.Substring(6));
            }
            LectorLocalidades.Close();
            StreamReader LectorCultivo = new StreamReader("./cultivos.txt");
            while (!LectorCultivo.EndOfStream)
            {
                string Informacion = LectorCultivo.ReadLine();
                lstCultivo.Items.Add(Informacion.Substring(6));
            }
            LectorCultivo.Close();

        }
        private void cmdCargar_Click(object sender, EventArgs e)
        {

        }
    }
}
