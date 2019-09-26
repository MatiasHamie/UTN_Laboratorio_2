using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Camion:VehiculoTerrestre
    {
        protected short cantidadMarchas;
        protected int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.pesoCarga = pesoCarga;
            this.cantidadMarchas = cantidadMarchas;
        }
    }
}
