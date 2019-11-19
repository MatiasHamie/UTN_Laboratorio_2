using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    public class VehiculoDeCarrera
    {
        #region Campos
        private short cantidadCombustible;
        private short numero;
        private short vueltasRestantes;
        private bool enCompetencia;
        private string escuderia;
        #endregion

        #region Constructores
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        #endregion

        #region Propiedades
        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set { this.cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get { return this.enCompetencia; }
            set { this.enCompetencia = value; }
        }

        public string Escuderia
        {
            get { return this.escuderia; }
            set { this.escuderia = value; }
        }

        public short Numero
        {
            get { return this.numero; }
            set { this.numero = value; }
        }

        public short VueltasRestantes
        {
            get { return this.vueltasRestantes; }
            set { this.vueltasRestantes = value; }
        }
        #endregion

        #region Métodos
        public virtual string MostrarDatos()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat($"--- Vehículo ---\n");
            cadena.AppendFormat($"Escudería: {this.escuderia}\n");
            cadena.AppendFormat($"Numero: {this.numero}\n");
            cadena.AppendFormat(this.enCompetencia ? "En Competencia: Si" : "En Competencia: No");
            cadena.AppendFormat($"Vueltas Restantes: {this.vueltasRestantes}\n");

            return cadena.ToString();
        }
        #endregion



    }
}
