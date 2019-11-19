using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Patente
    {

        #region Campos
        private Tipo tipoCodigo;
        private string codPatente;
        #endregion

        #region Tipos anidados
        public enum Tipo
        {
            Vieja,
            Mercosur
        }
        #endregion

        #region Propiedades
        public Tipo TipoCodigo
        {
            get { return this.tipoCodigo; }
            set { this.tipoCodigo = value; }
        }

        public string CodigoPatente
        {
            get { return this.codPatente; }
            set { this.codPatente = value; }
        }
        #endregion

        #region Métodos

        #region Constructores
        public Patente() { }

        public Patente(string codPatente, Tipo tipo)
        {
            this.CodigoPatente = codPatente;
            this.TipoCodigo = tipo;
        }
        #endregion

        public override string ToString()
        {
            return this.CodigoPatente;
        }
        #endregion
    }
}
