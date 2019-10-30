using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia c = new Competencia(20, 5);

            AutoF1 auto1 = new AutoF1(87, "Mercedes Benz");
            AutoF1 auto2 = new AutoF1(80, "Ferrari");
            AutoF1 auto3 = new AutoF1(82, "Renault");
            AutoF1 auto4 = new AutoF1(84, "RedBull");
            AutoF1 auto5 = new AutoF1(87, "Mercedes Benz");//No se debe agregar por ser igual al auto 1
            AutoF1 auto6 = new AutoF1(88, "Fiat");
            AutoF1 auto7 = new AutoF1(81, "Mercedes Benz");//No se debe agregar por no haber lugar

            Console.WriteLine("[AGREGAR AUTO 1]");
            if (c + auto1)
            {
                Console.WriteLine("Se agregó auto 1");
            }
            else
            {
                Console.WriteLine("No se agrego auto 1");
            }

            Console.WriteLine("\n[AGREGAR AUTO 2]");
            if (c + auto2)
            {
                Console.WriteLine("Se agregó auto 2");
            }
            else
            {
                Console.WriteLine("No se agrego auto 2");
            }

            Console.WriteLine("\n[AGREGAR AUTO 3]");
            if (c + auto3)
            {
                Console.WriteLine("Se agregó auto 3");
            }
            else
            {
                Console.WriteLine("No se agrego auto 3");
            }

            Console.WriteLine("\n[AGREGAR AUTO 4]");
            if (c + auto4)
            {
                Console.WriteLine("Se agregó auto 4");
            }
            else
            {
                Console.WriteLine("No se agrego auto 4");
            }

            Console.WriteLine("\n[AGREGAR AUTO 5]");
            if (c + auto5)
            {
                Console.WriteLine("Se agregó auto 5");
            }
            else
            {
                Console.WriteLine("No se agrego auto 5");
            }

            Console.WriteLine("\n[AGREGAR AUTO 6]");
            if (c + auto6)
            {
                Console.WriteLine("Se agregó auto 6");
            }
            else
            {
                Console.WriteLine("No se agrego auto 6");
            }

            Console.WriteLine("\n[AGREGAR AUTO 7]");
            if (c + auto6)
            {
                Console.WriteLine("Se agregó auto 7");
            }
            else
            {
                Console.WriteLine("No se agrego auto 7");
            }

            Console.WriteLine(c.MostrarDatos());

            Console.ReadKey();
        }
    }
}
