using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_26
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numerosRandom = new Random();
            int[] numerosArray = new int[20];

            for (int i = 0; i < numerosArray.Length; i++)
            {
                numerosArray[i] = numerosRandom.Next(-100, 101);
            }

            Console.WriteLine("a) Array como fue ingresado");
            foreach (int numero in numerosArray)
            {
                Console.WriteLine($"{numero}");
            }
            
            Array.Sort(numerosArray);

            int indexPos=0, indexNeg=0;
            
            for(int i = 0; i<numerosArray.Length; i++)
            {
                if (numerosArray[i] >= 0)
                {
                    indexPos++;
                }
                else
                {
                    indexNeg++;
                }
            }

            int[] numerosPositivos = new int[indexPos];
            int[] numerosNegativos = new int[indexNeg];

            indexNeg = 0;
            indexPos = 0;

            for (int i = 0; i < numerosArray.Length; i++)
            {
                
                if (numerosArray[i] >= 0)
                {
                    numerosPositivos[indexPos] = numerosArray[i];
                    indexPos++;
                }
                else
                {
                    numerosNegativos[indexNeg] = numerosArray[i];
                    indexNeg++;
                }
            }

            Array.Sort(numerosPositivos);
            Array.Sort(numerosNegativos);

            Console.WriteLine("\nb) Array con positivos ordenados");
            foreach (int positivos in numerosPositivos)
            {
                Console.Write($" {positivos} ");
            }

            Console.WriteLine("\nc) Array con negativos ordenados");
            foreach (int negativos in numerosNegativos)
            {
                Console.Write($" {negativos} ");
            }

            Console.ReadKey();
        }
    }
}
