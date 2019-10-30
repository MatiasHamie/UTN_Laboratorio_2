using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class EquipoBasquet:Equipo
    {
        private string nombre;
        private DateTime dateTime;

        public EquipoBasquet(string nombre,DateTime dateTime)
            : base(nombre, dateTime) { }

    }
}
