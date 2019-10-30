using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua:Botella
    {
        #region Campos
        /// <summary>
        /// Constante MEDIDA
        /// </summary>
        private const int MEDIDA = 400;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor, inicializa capacidad, contenido y marca llamando constructor base
        /// </summary>
        /// <param name="capacidadML"></param>
        /// <param name="marca"></param>
        /// <param name="contenidoML"></param>
        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {
            
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Sobrecarga del método GenerarInforme en clase base
        /// </summary>
        /// <returns>información del Agua</returns>
        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder(base.GenerarInforme());//tenia puesto base.ToString

            cadena.AppendFormat($" - Medida Agua: {Agua.MEDIDA} ml\n");

            return cadena.ToString();
        }
        #endregion

        #region Sobrecarga de Métodos
        /// <summary>
        /// Sobrecarga del método Servir medida
        /// Llama al método ServirMedida que recibe una int medida
        /// </summary>
        /// <returns></returns>
        public override int ServirMedida()
        {
            return this.ServirMedida(Agua.MEDIDA);
            //if (MEDIDA <= this.contenidoML)//tenia puesto base.contenidoML
            //{
            //    return this.contenidoML - MEDIDA;
            //}
            //else
            //{
            //    return this.contenidoML;
            //}
        }
        /// <summary>
        /// Recibe una medida, si es mayor al contenido, resta el contenido
        /// Caso contrario, resta la medida recida
        /// </summary>
        /// <param name="medida"></param>
        /// <returns>Medida Servida</returns>
        public int ServirMedida(int medida)
        {
            int medidaServida = 0;
            if (Agua.MEDIDA <= this.Contenido)
            {
                medidaServida = medida;
            }
            else
            {
                medidaServida = this.Contenido;
            }
            this.Contenido -= medidaServida;
            return medidaServida;
        }
        #endregion
    }
}
