using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_40CentralitaClases
{
    class CentralitaExcepcion:Exception
    {
        #region Campos
        private string nombreClase;
        private string nombreMetodo;
        #endregion

        #region Propiedades
        public string NombreClase { get { return this.nombreClase; } }
        public string NombreMetodo { get { return this.nombreMetodo; } }
        #endregion

        #region Metodos
        public CentralitaExcepcion(string mensaje, string clase, string metodo) : this(mensaje, clase, metodo, null)
        {
                
        }

        public CentralitaExcepcion(string mensaje, string clase, string metodo, Exception innerException) : base(mensaje, innerException)
        {
            this.nombreClase = clase;
            this.nombreMetodo = metodo;
        }
        #endregion
    }
}
