using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Entidades;

namespace FrmCantina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
            this.barra1.SetCantina = Cantina.GetCantina(10);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Botella botella;
            Enum.TryParse<Botella.Tipo>(cmbTipo.SelectedValue.ToString(), out tipo);
            if (txtMarca.Text != "" && nudContenido.Value >=1 && nudContenido.Value <= 1500 && nudCapacidad.Value >= 1 && nudCapacidad.Value <=1500)
            {
                if (rbtnAgua.Checked == true)
                {
                    botella = new Agua((int)nudCapacidad.Value,txtMarca.Text,(int)nudContenido.Value);
                }
                else
                {
                    botella = new Cerveza((int)nudCapacidad.Value, txtMarca.Text, tipo, (int)nudContenido.Value);
                }

                barra1.AgregarBotella(botella);
            }
            else
            {
                MessageBox.Show("Campos con valor invalido!\n (Medida o contenido máximo: 1500)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
