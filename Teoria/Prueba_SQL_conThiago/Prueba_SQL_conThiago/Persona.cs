using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Prueba_SQL_conThiago
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre { get { return this.nombre; } set { this.nombre = value; } }
        public int Edad { get { return this.edad; } set { this.edad = value; } }

        public Persona()
        {
            string mensaje = "MENSAJE DESDE CONSTRUCTOR VACIO";
            //Thread t = new Thread(new ParameterizedThreadStart(verPatente.Invoke));
            Thread t = new Thread(new ParameterizedThreadStart(DisparandoOtroThread2));
            t.Start(mensaje);
        }

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
            MostrarModal.InvocarModal("Mensaje desde el CONSTRUCTOR PERSONA");
            Thread t = new Thread(DisparandoOtroThread);
            t.Start();
        }

        public void DisparandoOtroThread()
        {
            MostrarModal.InvocarModal("Mensaje desde el MÉTODO DISPARANDO OTRO THREAD");
        }

        public void DisparandoOtroThread2(object mensaje)
        {
            MostrarModal.InvocarModal(mensaje.ToString());
        }
    }
}
