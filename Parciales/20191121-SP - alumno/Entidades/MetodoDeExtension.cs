using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoDeExtension
    {
        public static string EstadoSimulacion(this string estadoSimulacion, bool botonApretado)
        {
            if (botonApretado == true)
            {
                return "Orbitando";
            }
            else
            {
                return "Detenido";
            }
        }
    }
}
