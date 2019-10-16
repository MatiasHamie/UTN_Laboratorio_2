using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza:Botella
    {
        #region Constantes
        /// <summary>
        /// Constante MEDIDA
        /// </summary>
        private const int MEDIDA = 330;
        #endregion

        #region Campos
        /// <summary>
        /// Campo del tipo Enum
        /// </summary>
        private Tipo tipo;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor de la clase Cerveza que llama a otro constructor de la clase
        /// Inicializa capacidad, marca y contenido
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="contenidoML"></param>
        public Cerveza(int capacidadML, string marca, int contenidoML):this(capacidadML, marca,Tipo.Vidrio, contenidoML)
        {
            
        }

        /// <summary>
        /// Constructor que llama al constructor base
        /// Inicializa capacidad, marca, tipo y contenido
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="tipo"></param>
        /// <param name="contenidoML"></param>
        public Cerveza(int capacidadML, string marca,Tipo tipo, int contenidoML):base(marca,capacidadML,contenidoML)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Sobrecarga del método GenerarInforme
        /// </summary>
        /// <returns>Informacion de la botella y de la cerveza</returns>
        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder(base.GenerarInforme());

            cadena.AppendFormat($" - Medida Cerveza: {MEDIDA} ml \n");
            cadena.AppendFormat($" - Tipo: {this.tipo}\n");

            return cadena.ToString();
        }

        /// <summary>
        /// Sobrecarga del método ServirMedida
        /// Si la MEDIDA es <= al contenido de restante
        /// Sirve el 80% de la const MEDIDA
        /// Caso contrario, sirve una medida = contenido restante
        /// </summary>
        /// <returns>Medida Servida</returns>
        public override int ServirMedida()
        {
            int medidaServida = 0;
            if (Cerveza.MEDIDA <= this.Contenido)
            {
                medidaServida = ((Cerveza.MEDIDA * 80) / 100);
            }
            else
            {
                medidaServida = this.Contenido;
            }
            this.Contenido -= medidaServida;
            return medidaServida;
        }
        #endregion

        #region Conversion Implicita
        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }
        #endregion
    }
}
