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

        public enum Tipo
        {
            Vidrio,
            Plastico
        }
        #endregion

        #region Properties
        public int CapacidadLitros { get { return this.capacidadML / 1000; } }
        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;
            }
        }
        public float PorcentajeContenido
        {
            get
            {
                return ((this.contenidoML * 100) / this.capacidadML);
            }
        }
        #endregion

        #region Métodos
        protected Botella(string marca,int capacidadML,int contenidoML)
        {
            this.marca = marca;
            this.capacidadML = capacidadML;
            if (capacidadML < contenidoML)
            {
                Contenido = capacidadML;
            }
            else
            {
                Contenido = contenidoML;
            }
        }

        protected virtual string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendLine("--- Botella ---");
            cadena.AppendFormat($"Marca: {this.marca}\n");
            cadena.AppendFormat($"Capacidad: {CapacidadLitros}\n");
            cadena.AppendFormat($"Contenido (ml): {this.contenidoML}\n");

            return cadena.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return GenerarInforme();
        }
        #endregion
    }
}
