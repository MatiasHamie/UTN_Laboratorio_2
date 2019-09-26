using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;
using ComiqueriaApp;

namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Producto productoSeleccionado;
        Comiqueria comiqueria;

        public VentasForm(Producto productoSeleccionado, Comiqueria comiqueria)
        {
            InitializeComponent();
            this.productoSeleccionado = productoSeleccionado;
            this.comiqueria = comiqueria;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            VentasForm.ActiveForm.Close();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDownCantidad.Value > this.productoSeleccionado.Stock) 
            {
                MessageBox.Show("Error, no hay stock suficiente, elija menor cantidad!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.comiqueria.Vender(productoSeleccionado,(int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
