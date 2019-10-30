using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_42
{
    class MiClase
    {
        #region Constructores
        public MiClase()
        {
            try
            {
                MiClase.MetodoEstatico();
            }
            catch (DivideByZeroException objetoException)
            {
                throw objetoException;
            }
        }

        public MiClase()
        {

        }
        #endregion

        #region Métodos
        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
        }
        #endregion

    }
}
