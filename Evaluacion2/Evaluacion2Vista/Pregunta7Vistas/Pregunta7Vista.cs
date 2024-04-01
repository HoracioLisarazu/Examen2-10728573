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

namespace Evaluacion2Vista.Pregunta7Vistas
{
    public partial class Pregunta7Vista : Form
    {
        public Pregunta7Vista()
        {
            InitializeComponent();
        }
        Preg7Bss bss = new Preg7Bss();
        private void Pregunta7Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.PregBss7();
        }
    }
}
