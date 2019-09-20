using System;
using System.Collections.Generic;
using System.Text;

namespace CentralitaHerencia
{
    class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum TipoLlamada { Local, Provincial, Todas };
        public float Duracion { get { return duracion; } }
        public string NroDestino { get { return nroDestino; } }
        public string NroOrigen { get { return nroOrigen; } }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n[Llamada]-> ");
            stringBuilder.AppendFormat("Duración: {0}\n",this.duracion);
            stringBuilder.AppendFormat("Nro. Origen: {0}, Nro Destino: {1}", this.nroOrigen, this.nroDestino);

            return stringBuilder.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno;
            
            if (llamada1.duracion > llamada2.duracion)
            {
                retorno = 1;
            }
            else if(llamada1.duracion == llamada2.duracion)
            {
                retorno = 0;
            }
            else
            {
                retorno = -1;
            }

            return retorno;
        }
    }
}
