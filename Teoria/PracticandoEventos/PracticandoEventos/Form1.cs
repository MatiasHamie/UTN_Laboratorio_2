using Entidades;
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

namespace PracticandoEventos
{
    public partial class Form1 : Form
    {

        public delegate void Datos(string nombre);
        public event Datos moverDatos;
        Persona persona;

        public Form1()
        {
            InitializeComponent();
            this.moverDatos += Form1_moverDatos;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(persona.MetodoQueDisparaEventoQueEstaEnElForm);
            t.Start();
        }

        //Este es el manejador del evento mover datos
        //Ese evento va a ser disparado por el button1_click
        private void Form1_moverDatos(string nombre)
        {
            persona.Nombre = nombre;
        }

        //public void DisparandoEvento()
        //{

        //}
    }
}
