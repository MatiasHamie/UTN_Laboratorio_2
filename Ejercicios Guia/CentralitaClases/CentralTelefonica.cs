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
    public partial class CentralTelefonica : Form
    {
        Centralita centralita;
        public CentralTelefonica()
        {
            InitializeComponent();
            centralita = new Centralita();
        }

        private void BtnGenerarLlamada_Click(object sender, EventArgs e)
        {
            //Instancio por primera vez el formLlamador nuevo
            FrmLlamador formLlamador = new FrmLlamador(centralita);
            formLlamador.ShowDialog();
        }

        private void BtnFacturacionTotal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita,Llamada.TipoLlamada.Todas);
        }

        private void BtnFacturacionLocal_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita, Llamada.TipoLlamada.Local);
        }

        private void BtnFacturacionProvincial_Click(object sender, EventArgs e)
        {
            FrmMostrar frmMostrar = new FrmMostrar(centralita, Llamada.TipoLlamada.Provincial);
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();//acordarme de usar this, para referirme a este form
        }
    }
}
