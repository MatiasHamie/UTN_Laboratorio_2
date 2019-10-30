using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class AutoF1:VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        #region Propiedades
        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { caballosDeFuerza = value; }
        }
        #endregion

        #region Constructor
        public AutoF1(short numero, string escuderia)
            :base(numero,escuderia)
        {
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.Escuderia == a2.Escuderia) && (a1.Numero == a2.Numero);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region Métodos
        public override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder(base.MostrarDatos());

            cadena.AppendFormat($"Caballos de fuerza: {this.caballosDeFuerza}\n");

            return cadena.ToString();
        }
        #endregion
    }
}
