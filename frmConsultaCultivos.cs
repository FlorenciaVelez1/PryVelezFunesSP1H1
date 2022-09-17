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
    public partial class frmConsultaCultivos : Form
    {
        public frmConsultaCultivos()
        {
            InitializeComponent();
        }
        private void cmdListar_Click(object sender, EventArgs e)
        {
            StreamReader ConsultaCultivos = new StreamReader("./Cultivos.txt");
            while (!ConsultaCultivos.EndOfStream)
            {
                string DatosCultivos = ConsultaCultivos.ReadLine();
                string[] vectorDatosCultivos = DatosCultivos.Split((','));
                grillaCultivos.Rows.Add(vectorDatosCultivos[0], vectorDatosCultivos[1]);
            }
        }
        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            grillaCultivos.Rows.Clear();
        }
    }
}
