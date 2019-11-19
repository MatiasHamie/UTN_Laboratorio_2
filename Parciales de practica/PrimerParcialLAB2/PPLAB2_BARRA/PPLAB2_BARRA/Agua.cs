using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        #region Campos
        private const int MEDIDA = 400;
        #endregion

        #region Métodos
        public Agua(int capacidadML,string marca,int contenidoML)
            :base(marca,capacidadML,contenidoML)
        {

        }

        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder(base.ToString());
            cadena.AppendFormat($"Agua {this.marca}\n");
            return cadena.ToString();
        }

        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }

        public int ServirMedida(int medida)
        {
            int medidaServida;

            if (medida <= this.contenidoML)
            {
                medidaServida = Agua.MEDIDA;
            }
            else
            {
                medidaServida = this.contenidoML;
            }

            this.contenidoML -= medidaServida;

            return medida;
        }
        #endregion
    }
}
