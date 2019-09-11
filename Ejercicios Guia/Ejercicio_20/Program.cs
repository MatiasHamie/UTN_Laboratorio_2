using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Billetes;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 20";

            /*
             * Como ya tengo conversiones implicita de double a Dolar lo que hago es 
             * asigno un numero 10, que para C# por default es double y se convierte a 
             * 
             */
            //Dolar d = 10;
            //Euro e = 10;
            //Pesos p = 10;

            Dolar d = new Dolar(10,1);
            Euro e = new Euro(10,1.16);
            Pesos p = new Pesos(10,38.33);

            Console.WriteLine("Cantidad de billetes por moneda cargados");
            Console.WriteLine($"Cantidad de Dolares: {d.GetCantidad()}");
            Console.WriteLine($"Cantidad de Euros: {e.GetCantidad()}");
            Console.WriteLine($"Cantidad de Pesos: {p.GetCantidad()}");

            Console.WriteLine("\nCotizacion de billetes por moneda respecto dolar");
            Console.WriteLine($"1 Dolar = {Euro.GetCotizacion():##0.00} Euros");
            Console.WriteLine($"1 Dolar = {Pesos.GetCotizacion():##0.00} Pesos");

            Dolar aux1 = d + e;
            Console.WriteLine($"\n{d.GetCantidad()} u$s + {e.GetCantidad()} EU = {aux1.GetCantidad():##0.00}");

            Dolar aux2 = d + p;
            Console.WriteLine($"{d.GetCantidad()} u$s + {e.GetCantidad()} ARS$ = {aux2.GetCantidad():##0.00}");

            Euro aux3 = e + p;
            Console.WriteLine($"{e.GetCantidad()} EU + {p.GetCantidad()} ARS$ = {aux3.GetCantidad():##0.00}");
            Console.ReadKey();

        }
    }
}
