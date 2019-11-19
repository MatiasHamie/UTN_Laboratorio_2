using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_SQL_conThiago
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            List<Persona> personas2 = new List<Persona>();

            for (int i = 0; i < 5; i++)
            {
                personas.Add(new Persona("Sarasa"+i,i+10));
            }

            Sql sql = new Sql();

            //sql.Guardar(personas);


            sql.Leer(out personas2);

            foreach (var item in personas2)
            {
                Console.WriteLine(item.Nombre, item.Edad);
            }

            Console.ReadKey();
        }
    }
}
