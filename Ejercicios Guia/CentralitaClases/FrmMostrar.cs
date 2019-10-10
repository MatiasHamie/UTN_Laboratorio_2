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
    public partial class FrmMostrar : Form
    {
        Centralita centralita;
        public FrmMostrar(Centralita centralita,Llamada.TipoLlamada tipo)
        {
            InitializeComponent();
            this.centralita = centralita;
            mostrarGanancias(tipo);
        }

        public void mostrarGanancias(Llamada.TipoLlamada tipo)
        {
            StringBuilder str = new StringBuilder();

            foreach (Llamada llamada in this.centralita.Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.TipoLlamada.Local:
                        if (this.centralita.GananciasPorLocal != -1)
                        {
                            str.Append(llamada.ToString());
                            richTextBox1.Text = str.ToString();
                        }
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if (this.centralita.GananciasPorProvincial != -1)
                        {
                            str.Append(llamada.ToString());
                            richTextBox1.Text = str.ToString();
                        }
                        break;
                    case Llamada.TipoLlamada.Todas:
                        if (this.centralita.GananciasPorTotal != -1)
                        {
                            str.Append(llamada.ToString());
                            richTextBox1.Text = str.ToString();
                        }
                        break;
                    default:
                        break;
                }
            }
            this.ShowDialog();
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "No hay ganancias para mostrar";
        }
    }
}
