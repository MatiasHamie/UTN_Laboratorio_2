﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 5. Un centro numérico es un número que separa una lista de números enteros (comenzando en 1)
 * en dos grupos de números, cuyas sumas son iguales. 
 * El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5)
 * y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35,
 * el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
 * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el 
 * usuario ingrese por consola.
 * Nota: Utilizar estructuras repetitivas y selectivas.
 */

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int acumPrev = 0;
            int acumPost = 0;

            Console.WriteLine("Ingrese un numero..");

            if(int.TryParse(Console.ReadLine(),out num))
            {
                for(int i=num; i>1 ; i--)
                {
                    acumPrev = 0;
                    acumPost = 0;

                    for(int j = i - 1; j > 0; j--)
                    {
                        acumPrev += j;
                    }

                    for(int k = i + 1; acumPost < acumPrev; k++)
                    {
                        acumPost += k;
                    }

                    if (acumPrev == acumPost)
                    {
                        Console.WriteLine("Centro Numerico: {0}",i);
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR, Reingrese un numero");
            }

            Console.ReadKey();
        }
    }
}
