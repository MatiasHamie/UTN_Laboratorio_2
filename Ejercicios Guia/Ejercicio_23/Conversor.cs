using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Moneda
{
    public partial class Conversor : Form
    {
        public Conversor()
        {
            InitializeComponent();
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            Euro.SetCotizacion(txtCotizacionEuro.Text);//No olvidar agregarlo en properties->events->leave
        }
        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            Dolar.SetCotizacion(txtCotizacionDolar.Text);
        }
        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            Pesos.SetCotizacion(txtCotizacionPeso.Text);
        }

        private void BtnLockCotizacion_Click(object sender, EventArgs e)
        {
            if (txtCotizacionEuro.Enabled)
            {
                btnLockCotizacion.Image = imageList1.Images[0];
                txtCotizacionEuro.Enabled = false;
                txtCotizacionDolar.Enabled = false;
                txtCotizacionPeso.Enabled = false;
            }
            else
            {
                btnLockCotizacion.Image = imageList1.Images[1];
                txtCotizacionEuro.Enabled = true;
                txtCotizacionDolar.Enabled = true;
                txtCotizacionPeso.Enabled = true;
            }
        }

        private void BtnConvertEuro_Click(object sender, EventArgs e)
        {
            if (txtEuro.Text!="" && 
                txtCotizacionEuro.Text!="" && 
                double.Parse(txtEuro.Text) > 0 && 
                double.Parse(txtCotizacionEuro.Text)>0)
            {
                Euro moneda = new Euro(double.Parse(txtEuro.Text));
                //Explícitamente convierto la moneda (que esta en euros) a la moneda que quiero mostrar
                txtEuroAEuro.Text = moneda.GetCantidad().ToString();
                txtEuroADolar.Text = ((Dolar)moneda).GetCantidad().ToString();
                txtEuroAPeso.Text = ((Pesos)moneda).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Error! Datos incorrectos!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConverDolar_Click(object sender, EventArgs e)
        {
            if (txtDolar.Text != "" &&
                txtCotizacionDolar.Text != "" &&
                double.Parse(txtDolar.Text) > 0 &&
                double.Parse(txtCotizacionDolar.Text) > 0)
            {
                Dolar moneda = new Dolar(double.Parse(txtDolar.Text));

                txtDolarAEuro.Text = ((Euro)moneda).GetCantidad().ToString();
                txtDolarADolar.Text = moneda.GetCantidad().ToString();
                txtDolarAPeso.Text = ((Pesos)moneda).GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Error! Datos incorrectos!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnConvertPeso_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text != "" &&
                txtCotizacionPeso.Text != "" &&
                double.Parse(txtPeso.Text) > 0 &&
                double.Parse(txtCotizacionPeso.Text) > 0)                                                                                                                                                                                        
            {
                Pesos moneda = new Pesos(double.Parse(txtPeso.Text));

                txtPesoAEuro.Text = ((Euro)moneda).GetCantidad().ToString();
                txtPesoADolar.Text = ((Dolar)moneda).GetCantidad().ToString();
                txtPesoAPeso.Text = moneda.GetCantidad().ToString();
            }
            else
            {
                MessageBox.Show("Error! Datos incorrectos!!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
