using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Clase_23
{
    class Reloj
    {
        public delegate void EventTiempo(DateTime tiempo);
        public event EventTiempo EventoTiempo;

        public void ThreadRun()
        {
            while (true)
            {
                EventoTiempo(DateTime.Now);

                try
                {
                    Thread.Sleep(1000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
