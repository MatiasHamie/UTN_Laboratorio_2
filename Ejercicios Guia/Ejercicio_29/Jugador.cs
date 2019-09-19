using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_29
{
    class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;

        #region Constructores
        private Jugador()
        {
            this.partidosJugados = 0;
            this.promedioGoles = 0;
            this.totalGoles = 0;
        }

        public Jugador(int dni, string nombre)
        {
            this.dni = dni;
            this.nombre = nombre;
        }

        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos):this(dni,nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }
        #endregion

        #region Getter
        public float GetPromedioGoles()
        {
            promedioGoles = (float)totalGoles / partidosJugados;
            return this.promedioGoles;
        }
        #endregion

        #region MostrarDatos
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Insert(0, "Datos del jugador: ");
            stringBuilder.AppendFormat("\nNombre: {0}, Dni: {1}",this.nombre,this.dni);
            stringBuilder.AppendFormat("\nPartidos Jugados: {0} ", this.partidosJugados);
            stringBuilder.AppendFormat("Promedio Goles: {0}", this.promedioGoles);
            stringBuilder.AppendFormat("\nTotal Goles: {0}", this.totalGoles);

            return stringBuilder.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Jugador j1, Jugador j2)
        {
            return j1.dni == j2.dni;
        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1==j2);
        }
        #endregion
    }
}
