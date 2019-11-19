using Prueba_SQL_conThiago;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prueba_SQL_conThiago.MostrarModal;

namespace PracticaSP
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            MostrarModal.mensajeDeError += AbrirModal;
        }

        public void AbrirModal(string msj)
        {
            
            if (this.InvokeRequired)
            {
                MiDelegado d = new MiDelegado(AbrirModal);
                this.Invoke(d, new object[] { msj });
            }
            else
            {
                MessageBox.Show(msj, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = msj;
                label1.Text = msj;
            }
        }

        public void InstanciandoPersona()
        {
            Persona p = new Persona("Thiago", 18);
        }
        public void InstanciandoPersona2()
        {
            Persona p = new Persona();
        }

        

        private void Button1_Click(object sender, EventArgs e)
        {
            MostrarModal.InvocarModal("Mensaje desde el boton");

            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //Siempre que inicio un nuevo thread necesito pasarle un p.metodo como parametro
            Thread t = new Thread(InstanciandoPersona);
            t.Start();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //Siempre que inicio un nuevo thread necesito pasarle un p.metodo como parametro
            Thread t = new Thread(InstanciandoPersona2);
            t.Start();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Prestar atencion a poner como minimo 2 items al array
            string[] objetoParaPasarUnMensaje = new string[] { "Invocando desde Form a un evento de instancia a un metodo que llama a otro evento que llama a otro método", "" };

            ClaseSoloParaDispararEvento c = new ClaseSoloParaDispararEvento();
            Thread t = new Thread(new ParameterizedThreadStart(c.Invocar));
            t.Start(objetoParaPasarUnMensaje);
        }
    }
}
