using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 14. Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
 * cálculo del área que corresponda:
 * a. double CalcularCuadrado(double)
 * b. double CalcularTriangulo(double, double)
 * c. double CalcularCirculo(double)
 * El ingreso de los datos como la visualización se deberán realizar desde el método Main().
 */

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double lado = 0, h = 0, b = 0, radio = 0, area = 0;

            do
            {
                area = 0;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Ingrese una opcion para calcular el area de:");
                Console.WriteLine("1- Cuadrado");
                Console.WriteLine("2- Triángulo");
                Console.WriteLine("3- Círculo");
                Console.WriteLine("4- Salir");
                Console.Write("Opcion elegida: ");

                if (int.TryParse(Console.ReadLine(),out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.Write("Ingrese el valor del lado: ");
                            while(!double.TryParse(Console.ReadLine(),out lado))
                            {
                                Console.Write("Error! Ingrese nuevamente el lado: ");
                            }

                            area = CalculoDeArea.CalcularCuadrado(lado);

                            Console.Clear();
                            Console.WriteLine("El área del cuadrado es: {0:#,###.00}",area);
                            break;
                        case 2:
                            Console.Clear();
                            Console.Write("Ingrese el valor la base: ");
                            while (!double.TryParse(Console.ReadLine(), out b))
                            {
                                Console.Write("Error! Ingrese nuevamente la base: ");
                            }

                            Console.Write("Ingrese el valor la altura: ");
                            while (!double.TryParse(Console.ReadLine(), out h))
                            {
                                Console.Write("Error! Ingrese nuevamente la altura: ");
                            }

                            area = CalculoDeArea.CalcularTriangulo(b,h);

                            Console.Clear();
                            Console.WriteLine("El área del triángulo es: {0:#,###.00}", area);
                            break;
                        case 3:
                            Console.Clear();
                            Console.Write("Ingrese el valor del radio: ");
                            while (!double.TryParse(Console.ReadLine(), out radio))
                            {
                                Console.Write("Error! Ingrese nuevamente el radio..!");
                            }

                            area = CalculoDeArea.CalcularCirculo(radio);

                            Console.Clear();
                            Console.WriteLine("El área del círculo es: {0:#,###.00}", area);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ERROR, opcion inválida");
                }
                Console.ReadKey();
            } while (opcion != 4);
        }
    }
}
