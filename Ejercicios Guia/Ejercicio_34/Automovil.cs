using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Automovil:VehiculoTerrestre
    {
        protected int cantidadPasajeros;
        protected short cantidadMarchas;
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadPasajeros = cantidadPasajeros;
            this.cantidadMarchas = cantidadMarchas;
        }


    }
}
