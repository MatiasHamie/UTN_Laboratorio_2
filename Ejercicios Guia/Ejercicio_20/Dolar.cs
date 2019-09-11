using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Dolar()
        {
            Dolar.cotizRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }

        //Conversiones

        /*
         *  Conversion implicita de un double a dolar
         *  lo que hago es facilitar y escribir menos codigo
         *  por ej.. en lugar de instanciar objetos de tipo dolar
         *  en el main, lo que hago es crear una variable y crearla aca
         */
        public static implicit operator Dolar(double d)
        {
            //Creo un dolar nuevo aca y lo devuelvo ya instanciado
            return new Dolar(d);
        }

        //Conversiones explicitas de mooneda
        public static explicit operator Euro(Dolar d)
        {
            //Retornas directamente un euro, que le pasas la cantidad
            //de euros en total
            return new Euro(d.cantidad * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.cantidad * Pesos.GetCotizacion());
        }

        //Sobrecarga de operadores
        //Dolar - Euro
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == e.GetCantidad();
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return d.cantidad != e.GetCantidad();
        }

        //Dolar - Pesos
        public static bool operator ==(Dolar d, Pesos p)
        {
            return d.cantidad == p.GetCantidad();
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return d.cantidad != p.GetCantidad();
        }

        //Dolar - Dolar
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.GetCantidad();
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return d1.cantidad != d2.GetCantidad();
        }

        //Sobrecarga de operadores
        //Suma y resta de 
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).GetCantidad());
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).GetCantidad());
        }
    }
}
