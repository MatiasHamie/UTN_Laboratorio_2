using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public enum EstadoVuelo
    {
        Programado,
        Volando,
        Atrerrizado
    }
    public class Avion : IAvion
    {
        private int horasVuelo;
        private Thread vuelo;

        public Thread Vuelo
        { get {return this.vuelo; }
          set {this.vuelo = value; }
        }
        public Avion(int horasVuelo)
        {
            this.horasVuelo = horasVuelo;
        }
        
        
        public EstadoVuelo Estado
        {
            get;
        }

        public int HorasDeVuelo
        {
            get;
        }


        public void Volar()
        {
            int horasRestantes = this.horasVuelo;
            int porcentajeCompletado = 100;
            while (porcentajeCompletado <= 100)
            {

            }
        }

        void IAvion.Despegar()
        {
            Vuelo = new Thread(Volar);
            Vuelo.Start();
            
        }

        void IAvion.Estrellar()
        {
            if (Vuelo.IsAlive)
            {
                Vuelo.Abort();
            }            
        }
            
                
    }
}
