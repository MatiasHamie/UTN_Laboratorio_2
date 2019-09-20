using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        #region Constructores
        private Equipo()
        {
            jugadores = new List<Jugador>();
        }

        public Equipo(short cantidad, string nombre): this()
        {
            this.cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        #endregion

        #region operador
        public static bool operator +(Equipo e, Jugador j)
        {
            int i = 0;//Declaro i afuera del for, porque si no, cuando este termina, se elimina la variable, y como es igual a jugadores.count no entra nunca
            bool retorno = false;
            if (e.cantidadDeJugadores > e.jugadores.Count) 
            {
                for(; i < e.jugadores.Count; i++)
                {
                    if(j == e.jugadores[i])
                    {
                        break;
                    }
                }

                if (i == e.jugadores.Count)//Ojo, al principio i = e.jugadores.Count, nunca entraria al for, por eso se considera el primer caso de este if.
                                           //Ya que i = 0 y e.jugadores.Count = 0 tmb
                {
                    e.jugadores.Add(j);
                    retorno = true;
                }
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }
        #endregion
    }
}
