using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public string nombre;
        public int legajo;

        public void Estudiar(byte nota1, byte nota2)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public void CalcularFinal()
        {
            if (this.nota1 > 3 && this.nota2 > 3)
            {
                Random objNotaFinal = new Random();
                this.notaFinal = objNotaFinal.Next(4, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        
        public string Mostrar()
        {
            string cadena = "";
            cadena += "Datos del alumno: " + this.nombre + " " + this.apellido +"\n";
            cadena += "Legajo: "+ this.legajo +"\n";
            cadena += "Nota 1: " + this.nota1 + ", Nota 2: " + this.nota2 + "\n";

            if (this.notaFinal > 0)
            {
                cadena += "Nota Final: " + this.notaFinal + "\n";
            }
            else
            {
                cadena += "Nota Final: Desaprobado";
            }

            return cadena;
        }
    }
}
