using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*6. Escribir un programa que determine si un año es bisiesto. Un año es bisiesto si es múltiplo de 4.
 * Los años múltiplos de 100 no son bisiestos, salvo si ellos también son múltiplos de 400.
 * Por ejemplo: el año 2000 es bisiesto pero 1900 no.
 * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
 */

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int añoInicial = 0;
            int añoFinal = 0;

            Console.WriteLine("** AÑOS BISIESTOS **");
            Console.WriteLine("Ingrese el año inicial..");

            if (int.TryParse(Console.ReadLine(),out añoInicial))
            {
                Console.WriteLine("Ingrese el año final..");

                if (int.TryParse(Console.ReadLine(), out añoFinal))
                {
                    for(int i = añoInicial; i <= añoFinal; i++)
                    {
                        if(i % 4 == 0 || (i % 100 !=0 && i % 400 == 0))//Ojo con poner una "&&" en lugar de "||"
                        {
                            Console.WriteLine("Año Bisiesto: {0}",i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR, Reingrese el año final");
                }
            }
            else
            {
                Console.WriteLine("ERROR, Reingrese el año inicial");
            }

            Console.ReadKey();
        }
    }
}
