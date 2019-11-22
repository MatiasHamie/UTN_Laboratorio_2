using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface IFiles<T>
    {
        #region Métodos
        void Guardar(string nombreArchivo, T objeto);
        void Guardar(string nombreArchivo, T objeto, Encoding encoding);
        void Leer(string nombreArchivo, out T objeto);
        void Leer(string nombreArchivo, out T objeto, Encoding encoding);
        #endregion
    }
}
