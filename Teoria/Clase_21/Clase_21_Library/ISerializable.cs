using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21
{
    public interface ISerializable<T>
    {
        bool guardar(string archivo);
        bool modificar(string archivo);
        bool leer(string archivo, out T datos);
        bool eliminar(string archivo);

        // Base de Datos
        bool guardar();
        bool modificar();
        bool leer(out T datos);
        bool eliminar();
    }
}
