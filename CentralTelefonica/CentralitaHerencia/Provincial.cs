using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_40CentralitaClases
{
    class Provincial: Llamada
    {
        #region Campos
        private Franja franja;
        public enum Franja { Franja_1, Franja_2, Franja_3 };
        //Quise asignar Franja_1 = 0.99 pero no acepta flotante, solo int
        //Asi que opto por un switch
        #endregion

        #region Propiedades
        public float CostoLlamada { get { return CalcularCosto(); } }
        #endregion

        #region Constructores
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
        {
            this.franja = miFranja;
        }

        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen, miFranja, llamada.Duracion, llamada.NroDestino) { }
        #endregion

        #region Métodos
        private float CalcularCosto()
        {
            double rtn = 0;

            switch (this.franja)
            {
                case Franja.Franja_1:
                    rtn = 0.99 * base.duracion;
                    break;
                case Franja.Franja_2:
                    rtn = 1.25 * base.duracion;
                    break;
                case Franja.Franja_3:
                    rtn = 0.66 * base.duracion;
                    break;
            }

            return (float)rtn;
        }
        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder(base.Mostrar());//Llamamos al metodo mostrar de la clase padre
            stringBuilder.AppendFormat("\nCosto llamada PROVINCIAL: {0}", CostoLlamada);

            return stringBuilder.ToString();
        }
        #endregion
    }
}
