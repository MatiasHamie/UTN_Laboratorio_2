using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_SQL_conThiago
{
    public static class MostrarModal
    {
        public delegate void MiDelegado(string mensaje);
        public static event MiDelegado mensajeDeError;

        public static void InvocarModal(string msj)
        {
            mensajeDeError.Invoke(msj);
        }
    }
}
