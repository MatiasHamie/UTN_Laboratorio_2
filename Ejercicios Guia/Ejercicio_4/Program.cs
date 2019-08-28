using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 4. Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
 * (excluido el mismo) que son divisores del número. 
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
 * Escribir una aplicación que encuentre los 4 primeros números perfectos.
 * Nota: Utilizar estructuras repetitivas y selectivas.
 */

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumDiv = 0;
            int contPerf = 0;

            for(int i = 1; contPerf < 4; i++)
            {
                acumDiv = 0;

                for(int j = 1; j<i ; j++)
                {
                    if (i % j == 0)
                    {
                        acumDiv += j;
                    }
                }

                if (i == acumDiv)
                {
                    contPerf++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero Perfecto: {0}",i);
                }
            }

            Console.ReadKey();
        }
    }
}
