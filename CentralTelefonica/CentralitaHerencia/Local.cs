using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_40CentralitaClases
{
    class Local : Llamada
    {
        protected float costo;

        public float CostoLlamada { get { return CalcularCosto(); } }

        public Local(string destino,float duracion, string origen, float costo):base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo):this(llamada.NroDestino, llamada.Duracion, llamada.NroOrigen,costo){ }

        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder(base.Mostrar());//Llamamos al metodo mostrar de la clase padre
            stringBuilder.AppendFormat("\nCosto llamada LOCAL: {0}", CostoLlamada);

            return stringBuilder.ToString();
        }
        
    }
}
