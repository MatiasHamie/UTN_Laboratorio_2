using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class EquipoFutbol:Equipo
    {
        private string nombre;
        private DateTime dateTime;

        public EquipoFutbol(string nombre, DateTime dateTime)
            : base(nombre, dateTime) { }
    }
}
