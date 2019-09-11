using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double num)
        {
            string cadena = "";

            while (num > 0)
            {
                if (num % 2 == 0) 
                {
                    cadena += "0";
                }
                else if (num == 0)
                {
                    cadena = "0";
                }
                else
                {
                    cadena += "1";
                }

                num = num / 2;
            }

            return cadena;
        }

        public static double BinarioDecimal(string bin)
        {
            // paso de string a array de chars
            char[] array = bin.ToCharArray();
            // Invierto ya que se va incrementando de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            int acumulador = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    acumulador += (int)Math.Pow(2, i); //parseo a int ya que math.pow usa flotante
                }
            }
            return acumulador;
        }
    }
}
