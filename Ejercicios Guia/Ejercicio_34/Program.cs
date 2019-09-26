using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto1 = new Automovil(4, 5, VehiculoTerrestre.Colores.Azul, 6, 5);
            Camion camion1 = new Camion(6, 2, VehiculoTerrestre.Colores.Blanco, 7, 120000);
            Moto moto1 = new Moto(2, 0, VehiculoTerrestre.Colores.Gris, 1100);
        }
    }
}
