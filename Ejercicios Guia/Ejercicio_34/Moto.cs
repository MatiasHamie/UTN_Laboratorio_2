using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Moto:VehiculoTerrestre
    {
        protected int cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, int cilindrada) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
