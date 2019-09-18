﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moneda
{
    class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Pesos()
        {
            Pesos.cotizRespectoDolar = 0.023;
        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }

        public static void SetCotizacion(string strCotizacion)
        {
            if (strCotizacion != "")
            {
                Pesos.cotizRespectoDolar = double.Parse(strCotizacion);
            }
        }

        //Conversiones

        /*
         *  Conversion implicita de un double a dolar
         *  lo que hago es facilitar y escribir menos codigo
         *  por ej.. en lugar de instanciar objetos de tipo dolar
         *  en el main, lo que hago es crear una variable y crearla aca
         */
        public static implicit operator Pesos(double d)
        {
            //Creo un peso nuevo aca y lo devuelvo ya instanciado
            return new Pesos(d);
        }

        //Conversiones explicitas de moneda
        public static explicit operator Dolar(Pesos p)
        {
            //Retornas directamente un dolar, que le pasas la cantidad
            //de pesos en total
            return new Dolar(p.cantidad / Pesos.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return (Euro)((Dolar)p);
        }

        //Sobrecarga de operadores
        //Peso - Euro
        public static bool operator ==(Pesos p, Euro e)
        {
            return p.cantidad == e.GetCantidad();
        }

        public static bool operator !=(Pesos p, Euro e)
        {
            return p.cantidad != e.GetCantidad();
        }

        //Peso - Dolar
        public static bool operator ==(Pesos p, Dolar d)
        {
            return p.cantidad == d.GetCantidad();
        }

        public static bool operator !=(Pesos p, Dolar d)
        {
            return p.cantidad != d.GetCantidad();
        }

        //Dolar - Dolar
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return p1.cantidad == p2.GetCantidad();
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return p1.cantidad != p2.GetCantidad();
        }

        //Sobrecarga de operadores
        //Suma y resta de 
        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + ((Pesos)d).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - ((Pesos)d).GetCantidad());
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + ((Pesos)e).GetCantidad());
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - ((Pesos)e).GetCantidad());
        }
    }
}
