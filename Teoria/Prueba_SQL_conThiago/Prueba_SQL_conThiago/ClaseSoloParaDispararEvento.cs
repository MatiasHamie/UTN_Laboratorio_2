using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Prueba_SQL_conThiago.MostrarModal;

namespace Prueba_SQL_conThiago
{
    public class ClaseSoloParaDispararEvento
    {
        public event MiDelegado nuevoEvento;

        public ClaseSoloParaDispararEvento()
        {
            nuevoEvento += ClaseSoloParaDispararEvento_nuevoEvento;
        }

        private void ClaseSoloParaDispararEvento_nuevoEvento(string mensaje)
        {
            MostrarModal.InvocarModal(mensaje);
        }

        public void Invocar(object mensaje)
        {
            string[] array = (string[])mensaje;
            this.nuevoEvento.Invoke(array[0].ToString());
        }
    }
}
