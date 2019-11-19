using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public abstract class Equipo
    {
        #region Campos
        private string nombre;
        private DateTime dateTime;
        #endregion

        #region Propiedades
        public string Nombre { get { return this.nombre; } }
        public DateTime Fecha { get { return this.dateTime; } }
        #endregion

        #region Constructores
        public Equipo(string nombre, DateTime dateTime)
        {
            this.nombre = nombre;
            this.dateTime = dateTime;
        }
        #endregion

        #region Métodos
        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (e1.nombre == e2.nombre &&
                e1.dateTime == e2.dateTime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

        public string Ficha()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendFormat($"Equipo [{this.nombre}] fundado el [{this.dateTime}]\n");

            return cadena.ToString();
        }
        #endregion
    }
}
