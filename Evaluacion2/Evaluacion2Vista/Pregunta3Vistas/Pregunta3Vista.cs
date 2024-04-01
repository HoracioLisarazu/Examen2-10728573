using Evalucion_2_Bss;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion2Vista.Pregunta3Vistas
{
    public partial class Pregunta3Vista : Form
    {
        public Pregunta3Vista()
        {
            InitializeComponent();
        }
        Preg3Bss bss = new Preg3Bss();
        private void Pregunta3Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.PregBss3(); 
        }
    }
}
