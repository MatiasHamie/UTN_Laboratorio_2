using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 8. Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas
 * en el mes de N empleados de una fábrica.
 * Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el 
 * valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
 * multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
 * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora,
 * el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
 * Nota: Utilizar estructuras repetitivas y selectivas.
 */

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorHora = 0, antiguedadAños = 0, cantHorasTrab = 0;
            int importeBruto = 0;
            double importeNeto = 0, difBrutoNeto = 0;
            double porcDesc = 0.87;
            string nombre;

            Console.Write("Ingrese su nombre: ");
            nombre=Console.ReadLine();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("** TRABAJADOR {0} **",nombre);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ingrese valor Hora: ");

            if(int.TryParse(Console.ReadLine(),out valorHora))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Ingrese Horas trabajadas en el mes: ");

                if (int.TryParse(Console.ReadLine(), out cantHorasTrab))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Ingrese antigüedad (años): ");

                    if (int.TryParse(Console.ReadLine(), out antiguedadAños))
                    {
                        importeBruto = (valorHora * cantHorasTrab) + (antiguedadAños * 150);
                        importeNeto = importeBruto * porcDesc;
                        difBrutoNeto = importeBruto - importeNeto;

                        Console.Clear();

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("*** RECIBO DE TRABAJADOR {0}",nombre);

                        Console.WriteLine();
                        Console.WriteLine("Antigüedad: {0} (Años)    Valor Hora: ${1}",antiguedadAños,valorHora);

                        Console.WriteLine();
                        Console.WriteLine("** Total a cobrar **");
                        Console.WriteLine("Bruto: ${0:#,###.00}      Neto: ${1:#,###.00}",importeBruto,importeNeto);

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Total descuentos: ${0}",difBrutoNeto);
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("ERROR!, Reingrese antigüedad (años)..");
                    }
                }
                else
                {
                    Console.WriteLine("ERROR!, Reingrese cantidad de horas..");
                }
            }
            else
            {
                Console.WriteLine("ERROR!, Reingrese el valor hora..");
            }
        }
    }
}
