using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
 * calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema con DateTime.Now).
 * Nota: Utilizar estructuras selectivas.
 * Tener en cuenta los años bisiestos.
 */

namespace Ejercicio_7
{
    class Program
    {
        // Falta el ajuste fino de que no me cuente el primer año de vida completo con 365/6 dias..
        static void Main(string[] args)
        {
            int año = 0, mes = 0, dia = 0, acumDias = 0;

            Console.WriteLine("Ingrese su fecha de nacimiento..");
            Console.Write("Año: ");

            if(int.TryParse(Console.ReadLine(),out año))
            {
                for(int i = año; i < DateTime.Now.Year; i++)
                {
                    if (i % 4 == 0 || (i % 100 != 0 && i % 400 == 0))//Ojo con poner una "&&" en lugar de "||"
                    {
                        acumDias += 366;
                    }
                    else
                    {
                        acumDias += 365;
                    }
                }

                Console.Write("Mes: ");
                
                if (int.TryParse(Console.ReadLine(), out mes))
                {
                    for (int i = mes; i < DateTime.Now.Month; i++)
                    {
                        switch (i)
                        {
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                acumDias += 30;
                                break;
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 8:
                            case 10:
                            case 12:
                                acumDias += 31;
                                break;
                            case 2:
                                acumDias += 28;
                                break;
                        }
                    }

                    Console.Write("Día: ");
                    
                    if (int.TryParse(Console.ReadLine(), out dia))
                    {
                        Console.WriteLine();

                        for(int i = dia; i < DateTime.Now.Day; i++)
                        {
                            acumDias += i;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error, Reingrese el día de nacimiento..");
                    }
                }
                else
                {
                    Console.WriteLine("Error, Reingrese el mes de nacimiento..");
                }
            }
            else
            {
                Console.WriteLine("Error, Reingrese el año de nacimiento..");
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Cantidad de dias vividos: {0}",acumDias);
            Console.ReadKey();
        }
    }
}
