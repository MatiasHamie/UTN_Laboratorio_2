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

        #region Propiedades
        /// <summary>
        /// Propiedad que devuelve una lista de botellas
        /// </summary>
        public List<Botella> Botellas
        {
            get { return this.botellas; }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor que inicializa Cantina 
        /// Recibe espacios a reservar
        /// Inicializa una lista de botellas
        /// </summary>
        /// <param name="espacios"></param>
        private Cantina(int espacios)
        {
            botellas = new List<Botella>();
            this.espaciosTotales = espacios;
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Constructor que devuelve Cantina ya creada,
        /// caso de que no este creada, la crea
        /// </summary>
        /// <param name="espacios"></param>
        /// <returns></returns>
        public static Cantina GetCantina(int espacios)
        {
           
            if(singleton is null)
            {
                //Cantina.singleton = new Cantina(espacios); 
                singleton = new Cantina(espacios);
            }
            else
            {
                //Cantina.singleton.espaciosTotales = espacios;
                singleton.espaciosTotales = espacios;
            }

            return singleton;
        }
        #endregion

        #region Sobrecarga de Operadores

        /// <summary>
        /// El operador + agregará, siempre y cuando 
        /// aún no se hayan ocupado todos los espacios disponibles
        /// </summary>
        /// <param Cantina="c"></param>
        /// <param Botella="b"></param>
        /// <returns>true si agregó y false en caso contrario</returns>
        public static bool operator +(Cantina c,Botella b)
        {
            //if(c.espaciosTotales > 1)
            if (c.espaciosTotales > c.Botellas.Count)
            {
                //foreach (Botella botella in c.botellas)
                //{
                    //if (!(c.botellas.Contains(b)))
                   // {
                        c.botellas.Add(b);
                        return true;
                   // }
               // }
            }

            return false;
        }
        #endregion

    }
}
