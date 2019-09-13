using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            Random numerosAleatorios = new Random();

            for (int i = 0; i < 20 ; i++)
            {
                numeros.Add(numerosAleatorios.Next(-100,100));
            }
            
        }
    }
}
