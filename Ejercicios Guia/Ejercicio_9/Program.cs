using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 9. Escribir un programa que imprima por pantalla una pirámide como la siguiente:
 * *
 * *** 
 * ***** 
 * ******* 
 * *********
 * El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo.
 * Para el ejemplo anterior la altura ingresada fue de 5. 
 * Nota: Utilizar estructuras repetitivas y selectivas.
 */

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int alto = 0;
            string ast = "**";

            Console.WriteLine("Ingrese alto de la pirámide..");
            if(int.TryParse(Console.ReadLine(),out alto))
            {
                for (int i = 0; i < alto; i++)
                {
                    if (i == 0)
                    {
                        Console.WriteLine("*");
                    }
                    else
                    {
                        Console.WriteLine("*{0}",ast);
                        ast += "*";
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR, Reingrese el alto..");
            }

            Console.ReadKey();
        }
    }
}
