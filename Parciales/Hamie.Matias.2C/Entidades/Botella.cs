using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Botella
    {
        #region Campos
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Botella
        /// Inicializa marca, capacidad y contenido
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="capacidadML"></param>
        /// <param name="contenidoML"></param>
        protected Botella(string marca,int capacidadML, int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;

            if (capacidadML < contenidoML)
            {
                this.contenidoML = capacidadML;
                //this.capacidadML = capacidadML;
            }
            else
            {
                this.contenidoML = contenidoML;
            }
        }
        #endregion

        #region Enumerado
        /// <summary>
        /// Enumerado tipo de botella
        /// </summary>
        public enum Tipo
        {
            Plastico,
            Vidrio
        }
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve la capacidad en LITROS
        /// </summary>
        public int CapacidadLitros { get { return this.capacidadML / 1000; } }

        /// <summary>
        /// Propiedad que devuelve o setea el contenido en ML
        /// </summary>
        public int Contenido
        {
            get { return this.contenidoML; }
            set { this.contenidoML = value; }
        }

        /// <summary>
        /// Propiedad que devuelve el porcentaje restante de líquido
        /// </summary>
        public float PorcentajeContenido { get { return this.contenidoML*100/this.capacidadML; } }
        #endregion

        #region Métodos
        /// <summary>
        /// Método virtual del método GenerarInforme
        /// </summary>
        /// <returns>Información base de la botella</returns>
        protected virtual string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat($"- Marca: {this.marca}\n");
            cadena.AppendFormat($"- Capacidad (Lts): {this.CapacidadLitros} Lts\n");
            cadena.AppendFormat($"- Contenido Restante: {this.Contenido} ml\n");
            cadena.AppendFormat($"- Porcentaje Restante: {this.PorcentajeContenido}%\n");

            return cadena.ToString();
        }

        /// <summary>
        /// Método abstracto de ServirMedida
        /// </summary>
        /// <returns></returns>
        public abstract int ServirMedida();
        #endregion

        #region Overrides
        /// <summary>
        /// Sobrecarga del método ToString
        /// </summary>
        /// <returns>Devuelve informacion de GenerarInforme</returns>
        public override string ToString()
        {
            return this.GenerarInforme();
        }
        #endregion
    }
}
