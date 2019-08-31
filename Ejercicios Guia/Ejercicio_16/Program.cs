using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno[] arrayAlumnos = new Alumno[3];
            
            for(int i = 0; i < arrayAlumnos.Length; i++)
            {
                arrayAlumnos[i] = new Alumno();
                Random randomNota1 = new Random();
                Random randomNota2 = new Random();

                byte nota1 = (byte) randomNota1.Next(0, 10);
                byte nota2 = (byte) randomNota1.Next(0, 10);

                Console.Write("Ingrese nombre del #{0} alumno: ",i+1);
                arrayAlumnos[i].nombre = Console.ReadLine();

                Console.Write("Ingrese apellido del #{0} alumno: ",i+1);
                arrayAlumnos[i].apellido = Console.ReadLine();

                Console.Write("Ingrese legajo del #{0} alumno: ",i+1);
                while(!int.TryParse(Console.ReadLine(),out arrayAlumnos[i].legajo))
                {
                    Console.Write("ERROR, Reingrese legajo del #{0} alumno: ", i + 1);
                }

                arrayAlumnos[i].Estudiar(nota1, nota2);
                Console.Clear();
            }

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("** DATOS DE ALUMNOS INGRESADOS **");


            Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < arrayAlumnos.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(arrayAlumnos[i].Mostrar());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
