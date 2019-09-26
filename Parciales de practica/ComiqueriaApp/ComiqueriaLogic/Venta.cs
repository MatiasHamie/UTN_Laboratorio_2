using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        #region Campos
        private DateTime fecha;
        private static int porcentajeIva;
        private double precioFinal;
        private Producto producto;
        #endregion

        #region Propiedades
        internal DateTime Fecha
        {
            get { return fecha; }
        }
        #endregion

        #region Métodos
        static Venta()
        {
            porcentajeIva = 21;
        }

        internal Venta(Producto producto, int cantidad)
        {
            this.producto = producto;
            Vender(cantidad);
        }
        #endregion

        #region Métodos
        private void Vender(int cantidad)
        {
            this.producto.Stock -= cantidad;
            System.Threading.Thread.Sleep(2000);
            fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad)
        {
            return ((precioUnidad * cantidad) * porcentajeIva) / 100;
        }

        public string ObtenerDescripcionBreve()
        {
            StringBuilder cadena = new StringBuilder();
            //System.Threading.Thread.Sleep(2000);//Pausa para que aparezcan distintas horas
            cadena.AppendFormat($"Fecha {Fecha}");
            //cadena.AppendFormat($" Fecha: {this.fecha.Day}/{this.fecha.Month}/{this.fecha.Year} ");
            cadena.AppendFormat($" Descripcion: {this.producto.Descripcion} ");
            cadena.AppendFormat($" Precio final: ${this.precioFinal}\n");

            return cadena.ToString();
        }
        #endregion
    }
}
