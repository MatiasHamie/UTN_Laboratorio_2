using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        #region Campos
        private Guid Codigo;
        private string descripcion;
        private double precio;
        private int stock;
        #endregion

        #region Propiedades
        public string Descripcion
        {
            get { return this.descripcion; }
        }

        public double Precio
        {
            get { return this.precio; }
        }

        public int Stock
        {
            get { return this.stock; }
            set { if (value >= 0) this.stock = value; }
        }
        #endregion

        #region Constructores
        protected Producto(string descripcion, int stock, double precio)
        {
            this.descripcion = descripcion;
            this.stock = stock;
            this.precio = precio;
            this.Codigo = Guid.NewGuid();
        }
        #endregion

        #region Conversiones
        public static explicit operator Guid(Producto p)
        {
            return p.Codigo;
        }
        #endregion

        #region Métodos
        public override string ToString()
        {
            StringBuilder cadena = new StringBuilder();

            cadena.AppendFormat($" Descripción: {this.descripcion}\n");
            cadena.AppendFormat($" Código: {this.Codigo}\n");
            cadena.AppendFormat($" Precio: {this.Precio}\n");
            cadena.AppendFormat($" Stock: {this.Stock}\n");

            return cadena.ToString();
        }
        #endregion
    }
}
