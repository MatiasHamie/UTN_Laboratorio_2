using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Euro()
        {
            cotizRespectoDolar = 1 / 1.16;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        //Conversiones

        /*
         *  Conversion implicita de un double a dolar
         *  lo que hago es facilitar y escribir menos codigo
         *  por ej.. en lugar de instanciar objetos de tipo dolar
         *  en el main, lo que hago es crear una variable y crearla aca
         */
        public static implicit operator Euro(double d)
        {
            //Creo un dolar nuevo aca y lo devuelvo ya instanciado
            return new Euro(d);
        }

        //Conversiones explicitas de moneda
        public static explicit operator Dolar(Euro e)
        {
            //Retornas directamente un dolar, que le pasas la cantidad
            //de euros en total
            return new Dolar(e.cantidad * Dolar.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.cantidad * Pesos.GetCotizacion());
        }

        //Sobrecarga de operadores
        //Euro - Dolar
        public static bool operator ==(Euro e, Dolar d)
        {
            return e.cantidad == d.GetCantidad();
        }

        public static bool operator !=(Euro e, Dolar d)
        {
            return e.cantidad != d.GetCantidad();
        }

        //Euro - Pesos
        public static bool operator ==(Euro e, Pesos p)
        {
            return e.cantidad == p.GetCantidad();
        }

        public static bool operator !=(Euro e, Pesos p)
        {
            return e.cantidad != p.GetCantidad();
        }

        //Euro - Euro
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.cantidad == e2.GetCantidad();
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return e1.cantidad != e2.GetCantidad();
        }

        //Sobrecarga de operadores
        //Suma y resta de 
        public static Dolar operator +(Euro e, Dolar d)
        {
            return new Dolar(e.cantidad + ((Euro)d).GetCantidad());
        }

        public static Dolar operator -(Euro e, Dolar d)
        {
            return new Dolar(e.cantidad - ((Euro)d).GetCantidad());
        }

        public static Dolar operator +(Euro e, Pesos p)
        {
            return new Dolar(e.cantidad + ((Euro)p).GetCantidad());
        }

        public static Dolar operator -(Euro e, Pesos p)
        {
            return new Dolar(e.cantidad - ((Euro)p).GetCantidad());
        }
    }
}
