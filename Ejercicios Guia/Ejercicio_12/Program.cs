using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 12. Realizar un programa que sume números enteros hasta que el usuario lo determine, 
 * por medio de un mensaje "¿Continuar? (S/N)". 
 * En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de opciones.
 * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 */

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, acum = 0;
            char c = ' ';

            do
            {
                Console.WriteLine("Ingrese un número..");

                if (int.TryParse(Console.ReadLine(), out num))
                {
                    acum += num;
                    Console.WriteLine("¿Continuar (S/N)?");

                    if (!char.TryParse(Console.ReadLine(),out c))
                    {
                        Console.WriteLine("Error, Reingrese la respuesta");
                    }

                    /*
                    ConsoleKeyInfo objetoChar = Console.ReadKey();
                    c = objetoChar.KeyChar;//KeyChar es el caracter leído guardado en el objeto
                    */
                }
                else
                {
                    Console.WriteLine("ERROR, Reingrese número..");
                    c = 'S';
                }
            } while (ValidarRespuesta.ValidaS_N(c));

            Console.WriteLine("La suma total de los numeros ingresados es: {0}",acum);
            Console.ReadKey();
        }
    }
}
