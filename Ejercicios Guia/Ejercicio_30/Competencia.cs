using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class Competencia
    {
        #region Campos
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;
        #endregion

        #region Constructores
        private Competencia()
        {
            competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        #endregion

        #region Métodos
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("--- Competencia ---");
            stringBuilder.AppendFormat("Cant. Competidores: {0}, Cant. Vueltas: {1}\n", this.cantidadCompetidores, this.cantidadVueltas);
            stringBuilder.AppendLine("- Competidores -");

            foreach (AutoF1 auxCompetidor in competidores)
            {
                stringBuilder.AppendLine(auxCompetidor.MostrarDatos());
            }

            return stringBuilder.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator +(Competencia c, AutoF1 a)
        {
            bool retorno = false;
            
            if(c.cantidadCompetidores > c.competidores.Count())
            {
                if (c != a)//Ya al tener el == y != sobrecargados, ahi tengo el for q se fija si ya existe o no el auto
                {

                    c.competidores.Add(a);
                    int indexDelAuto = c.competidores.IndexOf(a);
                    Random random = new Random();
                    c.competidores[indexDelAuto].SetEnCompetencia(true);
                    c.competidores[indexDelAuto].SetCantidadCombustible((short)random.Next(15, 100));
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator -(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            if (c == a)//Ya al tener el == y != sobrecargados, ahi tengo el for q se fija si ya existe o no el auto
            {
                c.competidores.Remove(a);
            }

            return retorno;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
            bool retorno = false;

            for (int i = 0; i < c.competidores.Count(); i++)
            {
                if (c.competidores[i] == a)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {
            return !(c == a);
        }
        #endregion
    }
}
