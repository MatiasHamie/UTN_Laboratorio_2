using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Sumador
    {
        private int cantidadSumas;

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        public Sumador():this(0)
        {
            /* Al poner el :this(0) nos estamos ahorrando la linea de codigo de abajo
             * --> this.cantidadSumas = 0;
             * ya que le estamos pasando al constructor de arriba el 0 como parametro
             */
        }

        public static long operator +(Sumador a, Sumador b)
        {
            return (long)a.cantidadSumas + b.cantidadSumas;
        }

        public static bool operator |(Sumador a, Sumador b)
        {
            return a.cantidadSumas == b.cantidadSumas;
        }

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;

            return a + b;
        }

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;

            return a + b;
        }
    }
}
