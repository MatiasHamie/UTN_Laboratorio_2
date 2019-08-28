using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 15. Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
 * multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
 * operación que desea realizar (pulsando el caracter +, -, * ó /).
 * El usuario decidirá cuándo finalizar el programa.
 * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
 * a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
 * operación matemática. El método devolverá el resultado de la operación.
 * b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
 * utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
 * TRUE si el número es distinto de CERO.
 */

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcion = ' ';
            char seguir = 'S';
            string cadena = "";
            double primero = 0, segundo = 0, resultado = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("** Calculadora **");

                Console.Write("Ingrese el primer valor: ");
                while(!double.TryParse(Console.ReadLine(),out primero))
                {
                    Console.Write("ERROR, Reingrese el primer numero: ");
                }
                
                Console.Write("Ingrese el segundo valor: ");
                while (!double.TryParse(Console.ReadLine(), out segundo))
                {
                    Console.Write("ERROR, Reingrese el segundo numero: ");
                }

                Console.Clear();
                Console.WriteLine("+ -> Para sumar");
                Console.WriteLine("- -> Para restar");
                Console.WriteLine("* -> Para multiplicar");
                Console.WriteLine("/ -> Para dividir");

                Console.Write("Ingrese el operador deseado: ");
                while (!char.TryParse(Console.ReadLine(),out opcion))
                {
                    Console.Write("ERROR, Reingrese opcion");
                }

                resultado = Calculadora.Calcular(primero, segundo, opcion);

                if (resultado != -999.999)
                {
                    Console.Clear();
                    Console.WriteLine("El resultado de {0} {1} {2} = {3}", primero, opcion, segundo, resultado);
                }

                Console.ReadKey();

            } while (seguir=='S');
        }
    }
}
