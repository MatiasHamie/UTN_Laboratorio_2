using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 3. Mostrar por pantalla todos los números primos que haya 
 * hasta el número que ingrese el usuario por consola.
 * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
 */

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool esPrimo;

            Console.WriteLine("Ingrese un número..");
            
            if(int.TryParse(Console.ReadLine(),out num))
            {
                for (int i = num; i > 2; i--)
                {
                    esPrimo = true;

                    for(int j = i - 1; j > 1; j--)
                    {
                        if (i % j == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if (esPrimo)
                    {
                        Console.WriteLine("Numero Primo: {0}", i);
                    }
                }
            }
            else
            {
                Console.WriteLine("ERROR, Reingrese un número..");
            }

            Console.ReadKey();
        }
    }
}
