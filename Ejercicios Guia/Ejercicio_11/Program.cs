using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 11. Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la siguiente firma: bool Validar(int valor, int min, int max):
 * a. valor: dato a validar
 * b. min y max: rango en el cual deberá estar la variable valor.
 * Pedir al usuario que ingrese 10 números enteros. 
 * Validar con el método desarrollado anteriormente que esten dentro del rango -100 y 100. 
 * Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio. 
 * Nota: Utilizar variables escalares, NO utilizar vectores.
 * 
 */

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, max = 100, min = -100, valorMin = 0, valorMax = 0;
            double promedio = 0, acum = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese el #{0} Numero",i+1);

                if (int.TryParse(Console.ReadLine(), out num) && Validacion.Validar(num, min, max))
                {
                    acum += num;
                    promedio = acum / (i+1);

                    if (i == 0)
                    {
                        valorMin = num;
                        valorMax = valorMin;
                    }
                    else
                    {
                        if (num > valorMax)
                        {
                            valorMax = num;
                        }
                        else if (num < valorMin)
                        {
                            valorMin = num;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR, reingrese el #{0} Numero",i+1);
                    i--;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valor Mínimo: {0}",valorMin);
            Console.WriteLine("Valor Máximo: {0}",valorMax);
            Console.WriteLine("Promedio: {0:#,###.00}",promedio);
            Console.ReadKey();
        }
    }
}
