using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_30
{
    class AutoF1
    {
        #region Campos
        private short cantidadCombustible;
        private short numero;
        private short vueltasRestantes;
        private bool enCompetencia;
        private string escuderia;
        #endregion

        #region Getters y Setters
        public short GetCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void SetCantidadCombustible(short cantidadCombustible)
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public short GetVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public void SetVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        public bool GetEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void SetEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }


        #endregion

        #region Constructor
        public AutoF1(short numero, string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }
        #endregion

        #region Sobrecarga de Operadores
        public static bool operator ==(AutoF1 a1, AutoF1 a2)
        {
            return (a1.escuderia == a2.escuderia) && (a1.numero == a2.numero);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }
        #endregion

        #region Métodos
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Escuderia: {0}, Numero: {1}, Cant. Combustible: {2} ", this.escuderia, this.numero, this.cantidadCombustible);
            stringBuilder.Append(this.enCompetencia ? "En Competencia: Si" : "En Competencia: No");

            return stringBuilder.ToString();
        }
        #endregion
    }
}
