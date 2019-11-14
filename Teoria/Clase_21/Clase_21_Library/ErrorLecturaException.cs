using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_21
{
    public class ErrorLecturaException : Exception
    {
        public ErrorLecturaException(Exception e)
            : base("No se pudo leer el archivo", e)
        { }
    }
}
