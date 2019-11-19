using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio_47;

namespace Ejercicio47_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Libertadores");
            Torneo<EquipoBasquet> torneoBasquet = new Torneo<EquipoBasquet>("NBA");

            Random random = new Random();

            EquipoFutbol equipoFutbol1 = new EquipoFutbol("Boca Juniors", DateTime.Now.AddDays(random.Next(-365,365)));
            EquipoFutbol equipoFutbol2 = new EquipoFutbol("River Plate", DateTime.Now.AddDays(random.Next(-365, 365)));
            EquipoFutbol equipoFutbol3 = new EquipoFutbol("Independiente", DateTime.Now.AddDays(random.Next(-365, 365)));

            EquipoBasquet equipoBasquet1 = new EquipoBasquet("Spurs", DateTime.Now.AddDays(random.Next(-365, 365)));
            EquipoBasquet equipoBasquet2 = new EquipoBasquet("Cleveland", DateTime.Now.AddDays(random.Next(-365, 365)));
            EquipoBasquet equipoBasquet3 = new EquipoBasquet("Bulls", DateTime.Now.AddDays(random.Next(-365, 365)));

            torneoFutbol += equipoFutbol1;
            torneoFutbol += equipoFutbol2;
            torneoFutbol += equipoFutbol3;

            torneoBasquet += equipoBasquet1;
            torneoBasquet += equipoBasquet2;
            torneoBasquet += equipoBasquet3;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.WriteLine(torneoBasquet.Mostrar());
            Console.WriteLine("\n");
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);
            Console.WriteLine(torneoFutbol.JugarPartido);

            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);
            Console.WriteLine(torneoBasquet.JugarPartido);

            Console.ReadKey();
            


        }
    }
}
