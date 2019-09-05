using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase5
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public Producto (string marca, string codigo,float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }
        
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        //Conversiones
        public static explicit operator string(Producto p)
        {
            string cadena = "";

            cadena = p.codigoDeBarra;

            return cadena;
        }
        
        //Sobrecarga de operadores
        public static bool operator ==(Producto p1, Producto p2)
        {
            return ((p1.GetMarca() == p2.GetMarca()) && (p1.codigoDeBarra == p2.codigoDeBarra));
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        public static bool operator ==(Producto p, string marca)
        {
            return p.GetMarca() == marca;
        }

        public static bool operator !=(Producto p, string marca)
        {
            return !(p == marca);
        }

        public static string MostrarProducto(Producto p)
        {
            return "Marca: " + p.GetMarca() + "Precio: " + p.GetPrecio() +" Codigo de barras: "+(string)p;
        }

        
    }
}
