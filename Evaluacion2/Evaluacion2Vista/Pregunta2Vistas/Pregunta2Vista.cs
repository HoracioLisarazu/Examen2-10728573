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

namespace Evaluacion2Vista.Pregunta2Vistas
{
    public partial class Pregunta2Vista : Form
    {
        public Pregunta2Vista()
        {
            InitializeComponent();
        }
        Preg2Bss bss = new Preg2Bss();
        private void Pregunta2Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.PregBss2();
        }
    }
}
