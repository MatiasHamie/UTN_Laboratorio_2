using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_40CentralitaClases
{
    public class Local : Llamada
    {
        #region Campos
        protected float costo;
        #endregion

        #region Propiedades
        public override float CostoLlamada { get { return CalcularCosto(); } }
        #endregion

        #region Constructores
        public Local(string destino, float duracion, string origen, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo) : this(llamada.NroDestino, llamada.Duracion, llamada.NroOrigen, costo) { }
        #endregion

        #region Métodos
        private float CalcularCosto()
        {
            return this.costo * base.duracion;
        }

        protected override string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder(base.Mostrar());//Llamamos al metodo mostrar de la clase padre
            stringBuilder.AppendFormat("\nCosto llamada LOCAL: {0}", CostoLlamada);

            return stringBuilder.ToString();
        }

        public override bool Equals(object obj)
        {
            return (obj is Local);
        }

        public override string ToString()
        {
            return Mostrar();
        }
        #endregion
    }
}
