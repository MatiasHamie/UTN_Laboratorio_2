using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura : Producto
    {
        #region Campos
        private double altura;
        #endregion

        #region Constructores
        public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion, stock, precio)
        {
            this.altura = altura;
        }

        public Figura(int stock, double precio, double altura) : this(($"Figura {altura} cm"), stock, precio, altura)
        {

        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder(base.ToString());
            cadena.AppendFormat($" Altura: {altura}\n");

            return cadena.ToString();
        }
        #endregion
    }
}
