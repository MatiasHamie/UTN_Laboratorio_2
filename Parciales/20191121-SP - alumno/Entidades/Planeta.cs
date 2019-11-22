using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    #region Delegado
    public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);
    #endregion

    [Serializable]//Agrego para serializar todo
    public class Planeta
    {
        private short velocidadTraslacion;
        private short posicionActual;
        private short radioRespectoSol;
        private object objetoAsociado;

        PlanetaEventArgs pEventArgs;

        #region Evento
        public event InformacionDeAvance InformacionDeAvance;
        #endregion

        #region Propiedades
        public short RadioRespectoSol { get { return this.radioRespectoSol; } }
        public short PosicionActual { get { return this.posicionActual; } }
        #endregion

        #region Constructor por defecto para serializar
        public Planeta() { }
        #endregion

        public Planeta(short velocidad, short posicion, short radioRespectoSol, object objetoVisual)
        {
            this.velocidadTraslacion = velocidad;
            this.posicionActual = posicion;
            this.objetoAsociado = objetoVisual;
            this.radioRespectoSol = radioRespectoSol;
        }

        /// <summary>
        /// PictureBox u objeto gráfico asociado al planeta.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public object ObjetoAsociado
        {
            get
            {
                return this.objetoAsociado;
            }
            set
            {
                this.objetoAsociado = value;
            }
        }

        /// <summary>
        /// Avance del planeta según su velocidad
        /// </summary>
        public short Avanzar()
        {
            this.posicionActual += velocidadTraslacion;
            return this.posicionActual;
        }

        /// <summary>
        /// Simulación del movimiento del planeta
        /// </summary>
        public void AnimarSistemaSolar()
        {
            do
            {
                this.pEventArgs = new PlanetaEventArgs(this.Avanzar(), this.radioRespectoSol);
                this.InformacionDeAvance.Invoke(this,pEventArgs);
                System.Threading.Thread.Sleep(60 + this.velocidadTraslacion);
            } while (true);
        }
    }
}
