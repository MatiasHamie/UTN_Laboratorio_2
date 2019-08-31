using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_17Bis;//Uso para la clase boligrafo

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujoAzul;
            string dibujoRojo;

            Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("** Bolígrafo Azul **");

            if (boligrafoAzul.Pintar(-5,out dibujoAzul))
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine(dibujoAzul);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("No se pudo pintar!");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("** Bolígrafo Rojo **");

            if (boligrafoRojo.Pintar(-49, out dibujoRojo))
            {
                
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(dibujoRojo);
            }
            else
            {
                Console.WriteLine("No se pudo pintar!");
            }

            Console.ReadKey();
        }
    }
}
