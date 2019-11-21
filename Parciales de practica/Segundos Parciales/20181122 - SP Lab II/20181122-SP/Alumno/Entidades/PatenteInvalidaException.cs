using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PatenteInvalidaException:Exception
    {
        public PatenteInvalidaException(string msj) : base(msj) { }
        public PatenteInvalidaException(string msj, Exception innerException) : base(msj, innerException) { }
    }
}
