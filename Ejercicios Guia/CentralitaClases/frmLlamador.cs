using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_40CentralitaClases
{
    public partial class FrmLlamador : Form
    {
        Centralita centralitaLlamador;
        public Centralita CentralLlamador { get { return this.centralitaLlamador; } }

        public FrmLlamador(Centralita centralitaRecibida)
        {
            InitializeComponent();
            this.centralitaLlamador = centralitaRecibida;
            cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            txtNroDestino.ReadOnly = true;
        }

        #region Boton Llamar
        private void BtnLlamar_Click(object sender, EventArgs e)
        {
            //En la consigna nos piden que haya duracion y costo random
            Random random = new Random();
            int duracion = random.Next(1, 50);
            float costo = random.Next(5, 56) / 10; //Lo divido por 10 porque no me deja float

            if(txtNroOrigen.Text != "" && txtNroDestino.Text != "")
            {
                if (txtNroDestino.Text[0] == '#')
                {
                    //Hay que brindarle los datos a los combo box de esta forma
                    Provincial provincial;
                    Provincial.Franja franjas;
                   
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

                    switch (franjas)
                    {
                        case Provincial.Franja.Franja_1:
                            provincial = new Provincial(txtNroOrigen.Text, Provincial.Franja.Franja_1, duracion, txtNroDestino.Text);
                            //centralitaLlamador.Llamadas.Add((Llamada)provincial); si no tuviera la sobrecarga de op haria esto
                            centralitaLlamador += provincial;
                            break;
                        case Provincial.Franja.Franja_2:
                            provincial = new Provincial(txtNroOrigen.Text, Provincial.Franja.Franja_2, duracion, txtNroDestino.Text);
                            centralitaLlamador += provincial;
                            break;
                        case Provincial.Franja.Franja_3:
                            provincial = new Provincial(txtNroOrigen.Text, Provincial.Franja.Franja_3, duracion, txtNroDestino.Text);
                            centralitaLlamador += provincial;
                            break;
                        default:
                            MessageBox.Show("No ingresó Franja válida", "Error", MessageBoxButtons.OK);
                            break;
                    }
                }
                else
                {
                    cmbFranja.Enabled = false;//Deshabilito el comboBox
                    Local local = new Local(txtNroDestino.Text, duracion, txtNroOrigen.Text, costo);
                    centralitaLlamador += local;
                }

                MessageBox.Show("Llamada realizada con éxito..!!","Llamada procesada",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Números de origen o destino faltantes", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }
        #endregion


        #region Botones Pad Numérico
        private void Btn1_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "9";
        }

        private void BtnAsterisco_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + ".";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "0";
        }

        private void BtnNumeral_Click(object sender, EventArgs e)
        {
            txtNroDestino.Text = txtNroDestino.Text + "#";
        }
        #endregion


        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroOrigen.Text = "";
            txtNroDestino.Text = "";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
