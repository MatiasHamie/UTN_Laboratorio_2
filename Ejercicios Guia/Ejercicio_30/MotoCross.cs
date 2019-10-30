using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class MotoCross:VehiculoDeCarrera
    {
        #region Campos
        private short cilindrada;
        #endregion

        #region Constructores
        public MotoCross(short numero,string escuderia)
            : base(numero, escuderia)
        {
        }

        public MotoCross(short numero,string escuderia,short cilindrada)
            : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        #endregion

        #region Propiedades
        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }
        #endregion
        
        #region Métodos
        public override string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder(base.MostrarDatos());

            cadena.AppendFormat($"Cilindrada: {this.cilindrada}\n");

            return cadena.ToString();
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(MotoCross a1, MotoCross a2)
        {
            if(a1.Equals(a2) && (a1.cilindrada == a2.cilindrada))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(MotoCross a1, MotoCross a2)
        {
            return !(a1 == a2);
        }
        #endregion

    }
}
