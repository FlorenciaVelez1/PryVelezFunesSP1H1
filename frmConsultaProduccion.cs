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
    public partial class frmConsultaProduccion : Form
    {
        public frmConsultaProduccion()
        {
            InitializeComponent();
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            grillaProduccion.Rows.Clear();
        }
        private void cmdListar_Click(object sender, EventArgs e)
        {
            //Se agrega datos a la grilla
            StreamReader ConsultaProduccion = new StreamReader("./Produccion.txt");
            while (!ConsultaProduccion.EndOfStream)
            {
                string DatosProduccion = ConsultaProduccion.ReadLine();
                string[] vectorDatosProduccion = DatosProduccion.Split((','));
                grillaProduccion.Rows.Add(vectorDatosProduccion[0], vectorDatosProduccion[1], vectorDatosProduccion[2], vectorDatosProduccion[3]);
            }
        }
    }
}
