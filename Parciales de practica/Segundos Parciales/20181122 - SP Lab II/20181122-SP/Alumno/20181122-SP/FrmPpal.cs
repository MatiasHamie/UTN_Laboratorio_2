using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;
using Archivos;
using System.Threading;
using VistaPatentes;
using Patentes;

namespace _20181122_SP
{
    public partial class FrmPpal : Form
    {
        public event MostrarPatente muestroPatente;
        //------------------------------------------
        Queue<Patente> cola;
        List<Thread> threads;

        public FrmPpal()
        {
            InitializeComponent();
            this.cola = new Queue<Patente>();
            this.threads = new List<Thread>();
            muestroPatente += ProximaPatente;
        }
        private void FrmPpal_Load(object sender, EventArgs e)
        {
            //vistaPatente 1 y 2 son del tipo VistaPatente, no estan declarados acá, estan en los dibujos y designer
            muestroPatente += vistaPatente1.MostrarPatente;
            muestroPatente += vistaPatente2.MostrarPatente;
        }

        private void ProximaPatente(object patente)
        {
            if(this.cola.Count > 0)
            {
                //Al invocar el evento muestroPatente, ya tiene asignados los metodos de cada vistaPatente
                Thread thread = new Thread(new ParameterizedThreadStart(muestroPatente.Invoke));
                this.threads.Add(thread);

                //Le paso por parametro la patente que tengo en este momento y NO en el Invoke
                thread.Start(patente);
            }
        }

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.FinalizarSimulacion();
        }

        private void FinalizarSimulacion()
        {
            foreach (Thread thread in this.threads)
            {
                //Si intento parar un thread null, tira error
                if(thread != null)
                {
                    if (thread.IsAlive)
                    {
                        thread.Abort();
                    }
                }
            }
        }

        private void btnXml_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patente> lp = new List<Patente>();
                Xml<List<Patente>> xml = new Xml<List<Patente>>();
                xml.Leer("patentes", out lp);
                this.cola.Clear();
                this.cola = new Queue<Patente>(lp);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo leer XML", "ERROR XML", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.IniciarSimulacion();
        }

        private void btnTxt_Click(object sender, EventArgs e)
        {
            try
            {
                Texto texto = new Texto();
                texto.Leer("patentes", out this.cola);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo leer TEXTO", "ERROR TXT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.IniciarSimulacion();
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            try
            {
                List<Patente> lp = new List<Patente>();

                Sql sql = new Sql();
                sql.Leer("dbo.Patentes", out lp);

                this.cola.Clear();
                this.cola = new Queue<Patente>(lp);

            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo leer BD SQL", "ERROR SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.IniciarSimulacion();
        }

        public void IniciarSimulacion()
        {
            this.FinalizarSimulacion();

            //Mientras haya patentes en la cola
            while(this.cola.Count > 0)
            {
                //Voy sacando de una patente
                this.ProximaPatente(this.cola.Dequeue());
            }
        }
    }
}
