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

namespace Evaluacion2Vista.Pregunta1Vistas
{
    public partial class Pregunta1Vista : Form
    {
        public Pregunta1Vista()
        {
            InitializeComponent();
        }
        Preg1Bss bss = new Preg1Bss();
        private void Pregunta1Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.PregBss1(); 
        }
    }
}
