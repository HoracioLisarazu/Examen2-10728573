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

namespace Evaluacion2Vista.Pregunta8Vistas
{
    public partial class Pregunta8Vista : Form
    {
        public Pregunta8Vista()
        {
            InitializeComponent();
        }
        Preg8Bss bss = new Preg8Bss();
        private void Pregunta8Vista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.PregBss8(); 
        }
    }
}
