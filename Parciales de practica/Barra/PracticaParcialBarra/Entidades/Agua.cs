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
        private const int MEDIDA = 400;
        #endregion

        #region Constructores
        public Agua(int capacidadML, string marca, int contenidoML)
            :base(marca,capacidadML,contenidoML)
        {
        }
        #endregion

        #region Métodos
        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder(base.GenerarInforme());

            cadena.AppendLine("---Agua---");
            cadena.AppendFormat($"Medida (ml): {Agua.MEDIDA}\n");

            return cadena.ToString();
        }
        #endregion
    }
}
