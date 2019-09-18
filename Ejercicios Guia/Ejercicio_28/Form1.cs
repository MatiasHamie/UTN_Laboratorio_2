using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio_28;

namespace Ejercicio_28
{
    public partial class formContadorDePalabras : Form
    {
        public formContadorDePalabras()
        {
            InitializeComponent();
        }

       
        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = Palabras.ContadorDePalabras(richTextBox1.Text);
        }
    }
}
