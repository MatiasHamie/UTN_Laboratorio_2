using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometria;

/*
 *    v1-----------v2
 *    |             |
 *    |             |
 *    v4-----------v3
 */
namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto punto1 = new Punto(0, 5);
            Punto punto3 = new Punto(10, 0);

            Rectangulo rectangulo1 = new Rectangulo(punto1, punto3);

            rectangulo1.Area();
            rectangulo1.Perimetro();

            Console.WriteLine("Area: {0} Perímetro: {1}",rectangulo1.GetArea(),rectangulo1.GetPerimetro());
            Console.ReadKey();
        }
    }
}
