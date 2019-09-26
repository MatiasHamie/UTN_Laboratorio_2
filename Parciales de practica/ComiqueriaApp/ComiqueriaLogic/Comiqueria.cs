using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comiqueria
    {
        #region Campos
        private List<Producto> productos;
        private List<Venta> ventas;
        #endregion

        #region Propiedades
        public Producto this[Guid codigo]//indexador
        {
            get
            {
                Producto retorno = null;
                foreach (Producto productoAux in productos)
                {
                    if (codigo == ((Guid)productoAux))
                    {
                        retorno = productoAux;
                        break;
                    }
                }

                return retorno;
            }
        }
        #endregion

        #region Constructores
        public Comiqueria()
        {
            productos = new List<Producto>();
            ventas = new List<Venta>();
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(Comiqueria comiqueria, Producto producto)
        {
            bool retorno = false;

            for (int i = 0; i < comiqueria.productos.Count; i++)
            {
                if (comiqueria.productos[i].Descripcion == producto.Descripcion)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Comiqueria comiqueria, Producto producto)
        {
            return !(comiqueria == producto);
        }

        public static Comiqueria operator +(Comiqueria comiqueria, Producto producto)
        {
            //for (int i = 0; i < comiqueria.productos.Count; i++)
            //{
            if (comiqueria != producto)
            {
                comiqueria.productos.Add(producto);
                //break;
            }
            //}

            return comiqueria;
        }
        #endregion

        #region Métodos
        public void Vender(Producto producto)
        {
            Vender(producto, 1);
        }

        public void Vender(Producto producto, int cantidad)
        {
            Venta venta = new Venta(producto, cantidad);
            this.ventas.Add(venta);
        }

        public string ListarVentas()
        {
            StringBuilder cadena = new StringBuilder();

            ventas.Sort(OrdenarXFecha);

            foreach (Venta ventaAux in ventas)
            {
                cadena.AppendFormat($"{ventaAux.ObtenerDescripcionBreve()}");
            }

            return cadena.ToString();
        }

        private int OrdenarXFecha(Venta venta1, Venta venta2)
        {
            if (venta1.Fecha > venta2.Fecha)
            {
                return 1;
            }
            else if (venta1.Fecha == venta2.Fecha)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public Dictionary<Guid, string> ListarProductos()
        {
            Dictionary<Guid, string> diccionarioProductos = new Dictionary<Guid, string>();

            for (int i = 0; i < productos.Count; i++)
            {
                if (!(diccionarioProductos.ContainsKey((Guid)productos[i])))
                {
                    diccionarioProductos.Add(((Guid)productos[i]), productos[i].Descripcion);
                }
            }

            return diccionarioProductos;
        }
        #endregion
    }
}
