using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
    class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad,int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this.productos;
        }

        public static string MostrarEstante(Estante e)
        {
            string cadena = "";

            foreach (Producto p in e.GetProductos())
            {
                //object.ReferenceEquals(p, null); <-- otro ejemplo de verificar que no sea null
                if (!(p is null))//El foreach recorre todo el array sea null o no, verificar que el producto sea !=NULL
                {
                    //Recordar que al ser estatico, como MostrarProducto, se escribe clase.metodo();
                    cadena += "Ubic: " + e.ubicacionEstante + " " + Producto.MostrarProducto(p) + "\n";
                }
            }
            return cadena;
        }

        //Sobrecarga de operadores
        public static bool operator ==(Estante e, Producto p)
        {
            bool flag = false;

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!(e.productos[i] is null))
                {
                    if (e.productos[i] == p)
                    {
                        flag = true;
                    }
                }
            }
            return flag;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool flag = false;

            if (e!=p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        flag = true;
                        break;
                    } 
                }
            }

            return flag;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            if(!(p is null))
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] == p)
                    {
                        e.productos[i] = null;
                    }
                }
            }

            return e;
        }
    }
}
