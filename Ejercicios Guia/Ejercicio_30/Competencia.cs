using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class Competencia
    {
        #region Campos
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private TipoCompetencia tipo;
        #endregion

        #region Enumerado
        public enum TipoCompetencia
        {
            F1,
            MotoCross
        }
        #endregion
        
        #region Constructores
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores, TipoCompetencia tipo) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
            this.tipo = tipo;
        }
        #endregion

        #region Propiedades
        public VehiculoDeCarrera this[int index]//Indexador
        {
            get
            { 
                return competidores[index];
            }
        }

        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        #endregion

        #region Métodos
        public string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendLine("--- Competencia ---");
            cadena.AppendFormat("Cant. Competidores: {0}, Cant. Vueltas: {1}\n", this.cantidadCompetidores, this.cantidadVueltas);

            cadena.AppendLine("- Competidores -");
            foreach (VehiculoDeCarrera auxCompetidor in competidores)
            {
                if(auxCompetidor is AutoF1)
                {
                    cadena.AppendLine(((AutoF1)auxCompetidor).MostrarDatos());
                }
                else
                {
                    cadena.AppendLine(((MotoCross)auxCompetidor).MostrarDatos());
                }
            }
            return cadena.ToString();
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;
            
            if(c.cantidadCompetidores > c.competidores.Count())
            {
                if (c != a)//Ya al tener el == y != sobrecargados, ahi tengo el for q se fija si ya existe o no el auto
                {
                    if(c.tipo == Competencia.TipoCompetencia.MotoCross)
                    {

                    }
                    c.competidores.Add(a);
                    int indexDelAuto = c.competidores.IndexOf(a);
                    Random random = new Random();
                    c.competidores[indexDelAuto].EnCompetencia = true;
                    c.competidores[indexDelAuto].CantidadCombustible = ((short)random.Next(15, 100));
                    retorno = true;
                }
            }

            return retorno;
        }

        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            bool retorno = false;

            if (c == a)//Ya al tener el == y != sobrecargados, ahi tengo el for q se fija si ya existe o no el auto
            {
                c.competidores.Remove(a);
            }

            return retorno;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
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

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }
        #endregion
    }
}
