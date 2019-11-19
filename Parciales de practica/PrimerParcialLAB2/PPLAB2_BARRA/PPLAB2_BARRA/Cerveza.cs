using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        #region Campos
        private const int MEDIDA = 330;
        private Tipo tipo;
        #endregion

        #region Métodos
        public Cerveza(int capacidadML,string marca,int contenidoML)
            :this(capacidadML, marca, contenidoML, Tipo.Vidrio)
        {
            
        }

        public Cerveza(int capacidadML,string marca, int contenidoML,Tipo tipo)
            :base(marca,capacidadML,contenidoML)
        {
            this.tipo = tipo;
        }

        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder(base.ToString());

            cadena.AppendFormat($"Cerveza: {this.marca}\n");
            cadena.AppendFormat($"tipo: {this.tipo}\n");

            return cadena.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        public override int ServirMedida()
        {
            int medidaServida;

            if (Cerveza.MEDIDA <= this.contenidoML)
            {
                medidaServida = (int)(Cerveza.MEDIDA * 0.8);
            }
            else
            {
                medidaServida = this.contenidoML;
            }

            this.contenidoML -= medidaServida;

            return medidaServida;
        }
        #endregion
    }
}
