using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_47
{
    public class Torneo<T>where T:Equipo
    {
        #region Campos
        public List<T> equipos;
        private string nombre;
        Random random;

        public string JugarPartido
        {
            get
            {
                return CalcularPartido(
                    this.equipos[this.random.Next(this.equipos.Count())],
                    this.equipos[this.random.Next(this.equipos.Count())]
                    );
            }

        }
        #endregion
        


        #region Constructores
        public Torneo(string nombre)
        {
            this.random = new Random();
            this.equipos = new List<T>();
            this.nombre = nombre;
        }
        #endregion

        #region Métodos
        public static bool operator ==(T e, Torneo<T> t)
        {
            foreach (T aux in t.equipos)
            {
                if(aux == e)
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator !=(T e, Torneo<T> t)
        {
            return !(e == t);
        }

        public static Torneo<T> operator +(Torneo<T> t, T e)
        {
            if (e != t)
            {
                t.equipos.Add(e);
            }

            return t;
        }

        public string Mostrar()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendFormat($"--- Torneo {this.nombre} ---\n");

            foreach (T item in this.equipos)
            {
                cadena.AppendFormat(item.Ficha());
            }

            return cadena.ToString();
        }

        private string CalcularPartido(T e1, T e2)
        {
            

            return ($"[{e1.Nombre}] [{this.random.Next(1, 5)}] – [{this.random.Next(1, 5)}] [{e2.Nombre}]");
        }
        #endregion
    }
}
