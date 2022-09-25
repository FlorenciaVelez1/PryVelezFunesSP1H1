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
    public partial class frmConsultaLocalidades : Form
    {
        public frmConsultaLocalidades()
        {
            InitializeComponent();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            grillaLocalidad.Rows.Clear();
        }
        private void cmdListar_Click(object sender, EventArgs e)
        {
            //Agrega datos a la grilla
            StreamReader ConsultaLocalidad = new StreamReader("./Localidades.txt");
            while (!ConsultaLocalidad.EndOfStream)
            {
                string DatosLocalidades = ConsultaLocalidad.ReadLine();
                string[] vectorDatosLocalidades = DatosLocalidades.Split((','));
                grillaLocalidad.Rows.Add(vectorDatosLocalidades[0], vectorDatosLocalidades[1]);
            }
            ConsultaLocalidad.Close();
        }
    }
}
