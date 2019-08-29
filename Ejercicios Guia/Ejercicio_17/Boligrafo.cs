using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17Bis
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            short auxiliar = 0;//Creo un auxiliar para validar
            int suma = 0;
            int resta = 0;

            auxiliar = this.tinta;

            if(tinta < 0)
            {
                resta = auxiliar + tinta;
                if(resta >= 0)
                {
                    this.tinta = (short)resta;
                }
            }
            else
            {
                suma = auxiliar + tinta;
                if (suma <= cantidadTintaMaxima)
                {
                    this.tinta = (short)suma;
                }
            }
        }
        
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            short valorPrevioTinta = this.tinta;
            bool retorno = true;

            dibujo = "";

            SetTinta(gasto);

            if (gasto < 0 && GetTinta() < valorPrevioTinta) 
            {
                for (int i = 0; i < ((-1)*gasto); i++)
                {
                    dibujo += "*";
                }
            }
            else if(gasto > 0 && GetTinta() > valorPrevioTinta)
            {
                for (int i = 0; i < gasto; i++)
                {
                    dibujo += "*";
                }
            }
            else
            {
                retorno = false;
            }

            return retorno;
        }
    }
}
