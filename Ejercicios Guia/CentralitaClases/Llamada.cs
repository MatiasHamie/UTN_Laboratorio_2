using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_40CentralitaClases
{
    public abstract class Llamada
    {
        #region Campos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion

        #region Propiedades
        public float Duracion { get { return duracion; } }
        public string NroDestino { get { return nroDestino; } }
        public string NroOrigen { get { return nroOrigen; } }
        public abstract float CostoLlamada { get; }
        #endregion

        #region Enumerado
        public enum TipoLlamada
        {
            Local, Provincial, Todas
        }
        #endregion

        #region Constructores
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion

        #region Métodos
        protected virtual string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("[Llamada]-> ");
            stringBuilder.AppendFormat("Duración: {0}\n", this.duracion);
            stringBuilder.AppendFormat("Nro. Origen: {0}, Nro Destino: {1}", this.nroOrigen, this.nroDestino);
            //stringBuilder.AppendFormat($"Costo Llamada: {CostoLlamada}");

            return stringBuilder.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;

            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if (llamada1.duracion == llamada2.duracion)
            {
                retorno = 0;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Llamada l1, Llamada l2)
        {
            return (l1.Equals(l2) && 
                    l1.nroDestino == l2.nroDestino && 
                    l1.nroOrigen == l2.nroOrigen);
        }

        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
        #endregion
    }
}
