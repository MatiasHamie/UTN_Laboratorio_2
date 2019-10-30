using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class PuestoAtencion
    {
        #region Campos
        private static int numeroActual;
        private Puesto puesto;
        #endregion

        #region Propiedades
        public int NumeroActual
        {
            get { return numeroActual + 1; }
        }
        #endregion

        #region Constructores
        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto):this()
        {
            this.puesto = puesto;
        }
        #endregion

        #region Enumerador
        public enum Puesto { Caja1, Caja2 };
        #endregion

        #region Métodos
        public bool Atender(Cliente cli)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Atendiendo cliente..[{cli.Nombre}] Numero: {cli.Numero}");
            Thread.Sleep(2000);
            return true;
        }
        #endregion

    }
}
