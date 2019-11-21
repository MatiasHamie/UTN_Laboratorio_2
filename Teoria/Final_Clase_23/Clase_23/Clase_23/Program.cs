using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Clase_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Reloj r = new Reloj();
            r.EventoTiempo += ImprimirReloj;

            Thread clock = new Thread(r.ThreadRun);
            clock.Start();

            Console.ReadKey();
            clock.Abort();
        }

        public static void ImprimirReloj(DateTime fecha)
        {
            Console.Clear();
            Console.WriteLine(fecha);
        }
    }
}
