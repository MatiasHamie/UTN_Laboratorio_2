using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 2. Ingresar un número y mostrar: el cuadrado y el cubo del mismo.
 * Se debe validar que el número sea mayor que cero, 
 * caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!". 
 * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
 */

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            double cuadrado = 0;
            double cubo = 0;

            Console.WriteLine("Ingrese un numero..");

            if (int.TryParse(Console.ReadLine(), out num) && num > 0)
            {
                cuadrado = Math.Pow(num, 2);
                cubo = Math.Pow(num, 3);
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar numero!");
            }

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Numero elevado al cuadrado: {0:#,###.00}",cuadrado);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Numero elevado al cubo: {0:#,###.00}", cubo);

            Console.ReadKey();
        }
    }
}
