using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza:Botella
    {
        #region Campos
        private const int MEDIDA = 330;
        Tipo tipo;
        #endregion

        #region Constructores
        public Cerveza(int capacidadML, string marca, int contenidoML)
            :this(capacidadML,marca,Tipo.Vidrio,contenidoML)
        {
        }

        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML)
           : base(marca,capacidadML,contenidoML)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Métodos
        protected override string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder(base.GenerarInforme());

            cadena.AppendLine($"--- Cerveza ---");
            cadena.AppendFormat($"Medida(ml): {Cerveza.MEDIDA}\n");
            cadena.AppendFormat($"Tipo: {this.tipo}\n");

            return cadena.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
        {
            return cerveza.tipo;
        }

        public override int ServirMedida()
        {
            int medidaGastada = 0;

            if (MEDIDA <= this.contenidoML)
            {
                medidaGastada = (int)(MEDIDA*0.8);
            }
            else
            {
                medidaGastada = this.contenidoML;
            }

            this.contenidoML -= medidaGastada;

            return medidaGastada;
        }
        #endregion

    }
}
