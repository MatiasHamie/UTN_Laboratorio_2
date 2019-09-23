using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Negocio
    {
        #region Campos
        private PuestoAtencion caja;
        private string nombre;
        private Queue<Cliente> clientes;
        #endregion

        #region Propiedades
        public Cliente Cliente
        {
            get { return clientes.Dequeue(); }
            set { clientes.Enqueue(value); }
        }
        public int ClientesPendientes
        {
            get { return clientes.Count(); }
        }
        #endregion

        #region Constructores
        private Negocio()
        {
            clientes = new Queue<Cliente>();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Negocio n, Cliente c)
        {
            List<Cliente> listaAuxiliar;
            listaAuxiliar = n.clientes.ToList();
            bool retorno = false;

            for (int i = 0; i <listaAuxiliar.Count(); i++)
            {
                if (listaAuxiliar[i] == c)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n, Cliente c)
        {
            bool retorno = false;

            if (n!=c)
            {
                n.Cliente = c;//recordar que aca estoy usando el setter implicito de la propertie
                retorno = true;
            }

            return retorno;
        }

        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Cliente);
        }
        #endregion
    }
}
