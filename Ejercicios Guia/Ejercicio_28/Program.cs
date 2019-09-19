using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_28
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formContadorDePalabras());
        }
    }

    public static class Palabras
    {
        private static string strRichBox = "";
        public static string ContadorDePalabras(string strIngresado)
        {
            Palabras.strRichBox = strIngresado;
            Dictionary<string, int> ejemploMiDiccionario = new Dictionary<string, int>();
            List<KeyValuePair<string, int>> listaDePalabras = new List<KeyValuePair<string, int>>();
            string resultadoFinal = "";

            //Todo separador de palabras (como el punto, coma, espacio, 
            //doble coma por error, etc)
            //lo reemplazo por ;

            strRichBox = strRichBox.Replace(" ", ";");
            strRichBox = strRichBox.Replace(",", ";");
            strRichBox = strRichBox.Replace(",,", ";");
            strRichBox = strRichBox.Replace(",,,", ";");
            strRichBox = strRichBox.Replace(".", ";");
            strRichBox = strRichBox.Replace("..", ";");
            strRichBox = strRichBox.Replace("...", ";");

            foreach (string palabra in strRichBox.Split(';'))//Ojo con poner comillas dobles!
            {
                if (ejemploMiDiccionario.ContainsKey(palabra))
                {
                    //El dictionario puede ser usado como array para acceder
                    //a los elementos, se logra poniendo el KEY o el KEYVALUE
                    //entre los []..
                    //Ojo: NO se usan los index, se usan los KEY
                    ejemploMiDiccionario[palabra]++;
                }
                else
                {
                    ejemploMiDiccionario.Add(palabra, 1);
                }
            }

            listaDePalabras = ejemploMiDiccionario.ToList();

            listaDePalabras.Sort(ordenarDiccionario);

            for (int i = 0; i < listaDePalabras.Count(); i++)
            {
                resultadoFinal += ($"Palabra: '{listaDePalabras[i].Key}' Veces: {listaDePalabras[i].Value}\n");
            }
            return resultadoFinal;
        }

        public static int ordenarDiccionario(KeyValuePair<string, int> x, KeyValuePair<string, int> y)
        {
            if (x.Value > y.Value) { return 1; }
            else if (x.Value == y.Value) { return 0; }
            else { return -1; }
        }
    }
}
