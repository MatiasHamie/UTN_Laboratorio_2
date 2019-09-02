using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador a = new Sumador(10);
            Sumador b = new Sumador();

            Console.WriteLine($"Suma numeros: {a.Sumar(5,6)}");
            Console.WriteLine($"Suma strings: {b.Sumar("ab","cd")}");

            Console.WriteLine($"Cantidad de sumas iguales? : {a | b}");
            Console.WriteLine($"Suma cantidad de sumas: {a+b}");
            
            Console.ReadKey();
        }
    }
}
