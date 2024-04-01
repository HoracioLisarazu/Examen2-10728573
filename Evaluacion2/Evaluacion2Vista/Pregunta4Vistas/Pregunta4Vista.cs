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

namespace Evaluacion2Vista.Pregunta4Vistas
{
    public partial class Pregunta4Vista : Form
    {
        public Pregunta4Vista()
        {
            InitializeComponent();
        }
        Preg4Bss bss = new Preg4Bss();
        private void Pregunta4Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.PregBss4();
        }
    }
}
