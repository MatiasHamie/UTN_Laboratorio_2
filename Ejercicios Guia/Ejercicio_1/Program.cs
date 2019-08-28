using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 1. Ingresar 5 números por consola, guardándolos en una variable escalar.
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.
 */

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int valorMaximo = 0;
            int valorMinimo = 0;
            int contador = 0;
            float promedio = 0;
            float acumulador = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el #{0} numero:",i+1);

                if(int.TryParse(Console.ReadLine(),out num))
                {
                    acumulador += num;
                    contador++;
                    if (i == 0)
                    {
                        valorMaximo = num;
                        valorMinimo = num;
                    }
                    else
                    {
                        if (num > valorMaximo)
                        {
                            valorMaximo = num;
                        }
                        else
                        {
                            if (num < valorMinimo)
                            {
                                valorMinimo = num;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR, Reingrese el #{0} numero:", i + 1);
                    i--;
                }
            }

            promedio = acumulador / contador;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valor Maximo: {0}", valorMaximo);
            Console.WriteLine("Valor Minimo: {0}", valorMinimo);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Valor promedio: {0}", promedio);

            Console.ReadKey();
        }
    }
}
