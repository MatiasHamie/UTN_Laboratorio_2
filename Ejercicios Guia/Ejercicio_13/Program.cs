using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): string DecimalBinario(double).
 * Convierte un número de entero a binario. double BinarioDecimal(string).
 * Convierte un número binario a entero. 
 */

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDecimal = 0, opcion = 0;
            string numeroBinario = "";

            do
            {
                Console.Clear();
                Console.WriteLine("** MENU CONVERSION **");
                Console.WriteLine("1 - Decimal a Binario");
                Console.WriteLine("2 - Binario a Decimal");
                Console.WriteLine("3 - Salir");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese un numero decimal positivo");
                            if (int.TryParse(Console.ReadLine(), out numeroDecimal))
                            {
                                numeroBinario = Conversor.DecimalBinario(numeroDecimal);
                            }
                            else
                            {
                                Console.WriteLine("ERROR, numero ingresado incorrecto..!");
                            }
                            Console.Clear();
                            Console.WriteLine("Numero Decimal: {0:#,###.00} en Binario es: {1}", numeroDecimal, numeroBinario);
                            break;
                        case 2:
                            Console.WriteLine("Ingrese un numero binario positivo");
                            numeroBinario = Console.ReadLine();
                            Conversor.BinarioDecimal(numeroBinario);
                            Console.Clear();
                            Console.WriteLine("Numero Binario: {0} en Decimal es: {1}", numeroBinario, numeroDecimal);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Error, reingrese opcion");
                }
                Console.ReadKey();
            } while (opcion != 3);
        }
    }
}
