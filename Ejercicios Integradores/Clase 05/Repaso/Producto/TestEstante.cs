using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
    class TestEstante
    {
        static void Main(string[] args)
        {
            // Creo un estante
            Estante estante = new Estante(3, 1);
            // Creo 4 productos
            Producto p1 = new Producto("Pepsi", "PESDS97413", (float)18.5);
            Producto p2 = new Producto("Coca-Cola", "COSDS55752", (float)11.5);
            Producto p3 = new Producto("Manaos", "MASDS51292", (float)20.5);
            Producto p4 = new Producto("Crush", "CRSDS54861", (float)10.75);
            // Agrego los productos al estante
            if (estante + p1)//Agrega por primera vez p1, "Pepsi"
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p1)//Intenta agregar por segunda vez p1, tiene que fallar porque ya existe
            {
                Console.WriteLine("Agregó {0} {1} {2}", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p1.GetMarca(), (string)p1, p1.GetPrecio());
            }
            if (estante + p2)//Primera vez p2, hay lugar, lo agrega
            {
                Console.WriteLine("Agregó {0} {1} {2}", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p2.GetMarca(), (string)p2, p2.GetPrecio());
            }
            if (estante + p3)//Primera vez p3, hay lugar, lo agrega
            {
                Console.WriteLine("Agregó {0} {1} {2}", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p3.GetMarca(), (string)p3, p3.GetPrecio());
            }
            if (estante + p4)//Primera vez p4, pero el estante fue creado con 3 de cantidad, no hay lugar
            {
                Console.WriteLine("Agregó {0} {1} {2}", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            else
            {
                Console.WriteLine("¡NO agregó {0} {1} {2}!", p4.GetMarca(), (string)p4, p4.GetPrecio());
            }
            // Muestro todo el estante
            Console.WriteLine();
            Console.WriteLine("<------------------------------------------------->");
            Console.WriteLine(Estante.MostrarEstante(estante));
            Console.ReadKey();
        }
    }
}
