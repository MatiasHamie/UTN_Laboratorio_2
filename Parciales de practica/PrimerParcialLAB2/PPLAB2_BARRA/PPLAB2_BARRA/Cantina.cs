using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cantina
    {
        #region Campos
        private List<Botella> botellas;
        private int espaciosTotales;
        private static Cantina singleton;
        #endregion

        #region Properties
        public List<Botella> Botellas { get { return this.botellas; } }
        #endregion

        #region Métodos
        private Cantina(int espacios)
        {
            this.espaciosTotales = espacios;
            this.botellas = new List<Botella>();
        }

        public static Cantina GetCantina(int espacios)
        {
            if(singleton is null)
            {
                singleton = new Cantina(espacios);
            }
            else
            {
                singleton.espaciosTotales = espacios;
            }

            return singleton;
        }

        public static bool operator +(Cantina c, Botella b)
        {
            if(c.botellas.Count < c.espaciosTotales)
            {
                c.botellas.Add(b);
                return true;
            }

            return false;
        }
        #endregion
    }
}
