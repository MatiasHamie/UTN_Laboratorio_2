using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        #region Campos
        private string autor;
        private TipoComic tipoComic;
        public enum TipoComic { Occidental, Oriental }
        #endregion

        #region Constructores
        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipoComic) : base(descripcion, stock, precio)
        {
            this.autor = autor;
            this.tipoComic = tipoComic;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder(base.ToString());
            cadena.AppendFormat($" Autor: {this.autor}\n");
            cadena.AppendFormat($" TipoComic: {this.tipoComic}\n");

            return cadena.ToString();
        }
        #endregion
    }
}
