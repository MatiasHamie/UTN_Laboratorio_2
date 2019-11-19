using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public class Aeropuerto<T>
    {
        private List<T> vuelos;

        public Aeropuerto()
        { }

        public void FinalizarVuelos()
        { }

        public static int operator +(Aeropuerto<T> a, T vuelo)
        {
            a.vuelos.Add(vuelo);
            return a.vuelos.Count * 50;
        }
    }
}
