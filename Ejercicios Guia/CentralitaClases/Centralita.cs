using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_40CentralitaClases
{
    public class Centralita
    {
        #region Campos
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;
        #endregion

        #region Propiedades
        public float GananciasPorLocal { get { return CalcularGanancia(Llamada.TipoLlamada.Local); } }
        public float GananciasPorProvincial { get { return CalcularGanancia(Llamada.TipoLlamada.Provincial); } }
        public float GananciasPorTotal { get { return CalcularGanancia(Llamada.TipoLlamada.Todas); } }
        public List<Llamada> Llamadas { get { return listaDeLlamadas; } }
        #endregion

        #region Constructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();//No olvidar que en el constructor vacio se instancia la lista
        }

        public Centralita(string nombreEmpresa):this()//No olvidar usar el this para si o si inicializar la lista
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion

        #region Métodos
        public string Mostrar()
        {
           Local local;//No agrego el 'new' ya que la llamada que va a almacenar local, ya tiene sus datos instanciados, solamente me hago una "copia" a local.
           Provincial provincial;//Idem local
           StringBuilder stringBuilder = new StringBuilder(($"[Razon social: {razonSocial}] \nGanancia total: {GananciasPorTotal}\n"));
           stringBuilder.AppendLine($"Ganancias Local: {GananciasPorLocal} Ganancias Provincial: {GananciasPorProvincial}");

           foreach (Llamada llamadaExtraidaDeLaLista in Llamadas)
           {
               if (llamadaExtraidaDeLaLista is Local)
               {
                   local = (Local)llamadaExtraidaDeLaLista;
                   stringBuilder.AppendLine(local.ToString());//Uso appendline para poner el /n al final implícito
               }
               else
               {
                   provincial = (Provincial)llamadaExtraidaDeLaLista;
                   stringBuilder.AppendLine(provincial.ToString());
               }
           }

          return stringBuilder.ToString();
        }
    
        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipoDeLlamada)
        {
            float acumuladorGanancias = 0;
            Local auxiliarTipoLocal;
            Provincial auxiliarTipoProvincial;

            foreach (Llamada llamadaExtraidaDeLaLista in Llamadas)
            {
                if (tipoDeLlamada == Llamada.TipoLlamada.Local && llamadaExtraidaDeLaLista is Local)
                {
                    auxiliarTipoLocal = (Local)llamadaExtraidaDeLaLista;
                    acumuladorGanancias += auxiliarTipoLocal.CostoLlamada;
                }
                else if (tipoDeLlamada == Llamada.TipoLlamada.Provincial && llamadaExtraidaDeLaLista is Provincial)
                {
                    auxiliarTipoProvincial = (Provincial)llamadaExtraidaDeLaLista;
                    acumuladorGanancias += auxiliarTipoProvincial.CostoLlamada;
                }
                else if(tipoDeLlamada == Llamada.TipoLlamada.Todas)
                {
                    //Si el tipo es TODAS, calculo acorde a cada tipo extraido en el momento
                    if (llamadaExtraidaDeLaLista is Local)
                    {
                        auxiliarTipoLocal = (Local)llamadaExtraidaDeLaLista;
                        acumuladorGanancias += auxiliarTipoLocal.CostoLlamada;
                    }
                    else
                    {
                        auxiliarTipoProvincial = (Provincial)llamadaExtraidaDeLaLista;
                        acumuladorGanancias += auxiliarTipoProvincial.CostoLlamada;
                    }
                }
                else
                {
                    acumuladorGanancias = -1;
                }
            }
            return acumuladorGanancias;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }
        #endregion

        #region Sobrecarga de operadores
        public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
        {
            bool esta = false;
            foreach (Llamada llamadaAux in c.listaDeLlamadas)
            {
                if(llamadaAux == nuevaLlamada)
                {
                    esta = true;
                    break;
                }
            }

            if (esta == false)
            {
                c.AgregarLlamada(nuevaLlamada);
            }

            return c;
        }
        #endregion
    }
}
