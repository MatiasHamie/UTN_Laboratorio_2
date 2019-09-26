using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    class VehiculoTerrestre
    {
        #region Campos
        public enum Colores { Rojo, Blanco, Azul, Gris, Negro };
        protected Colores color;
        protected short cantidadRuedas;
        protected short cantidadPuertas;
        #endregion

        #region Constructores
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color; 
        }
        #endregion

        #region Métodos
        public Mostrar()
        {
            StringBuilder strBldr = new StringBuilder();
            strBldr.AppendLine("\n-- Vehículo --\n");
            strBldr.AppendFormat($"Cantidad Ruedas: {this.cantidadRuedas}, Cantidad Puertas: {this.cantidadPuertas}\n");
            strBldr.AppendLine($"Color: {this.color}");

            return strBldr.ToString();
        }
        #endregion

    }
}
