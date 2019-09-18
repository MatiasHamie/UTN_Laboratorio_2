using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_27
{
    /*
     * Para las pilas o colas, se pasa a array, 
     * se hacen los pop(pilas) o dequeue(colas),
     * se ordena y se pushea(pilas) o enqueue(colas)
     */
    class Program
    {
        static void Main(string[] args)
        {
            //Colas

            Queue<int> positivos = new Queue<int>();
            Queue<int> negativos = new Queue<int>();

            Random numerosAleatorios = new Random();
            int aux = 0;

            Console.WriteLine("a) Muestro como fueron ingresados");
            for (int i = 0; i < 20; i++)
            {
                aux = numerosAleatorios.Next(-100, 100);
                Console.Write($" {aux} ");
                if (aux < 0)
                {
                    //negativos.Add(aux);-> Listas
                    //negativos.Push(aux);-> Stack o Pila
                    negativos.Enqueue(aux);
                }
                else
                {
                    //positivos.Add(aux);-> Listas
                    //positivos.Push(aux);-> Stack o Pila
                    positivos.Enqueue(aux);
                }
            }
            
            /*Listas
            List<int> positivos = new List<int>();
            List<int> negativos = new List<int>();*/

            /*Pilas
            Stack<int> positivos = new Stack<int>();
            Stack<int> negativos = new Stack<int>();
            Random numerosAleatorios = new Random();
            int aux = 0;

            //Sorting de Listas
            //positivos.Sort();
            //positivos.Reverse();
            //negativos.Sort();
            
            int[] arrayPositivos = new int[positivos.Count()];
            int[] arrayNegativos = new int[negativos.Count()];

            
            arrayPositivos = positivos.ToArray();
            arrayNegativos = negativos.ToArray();

            Array.Sort(arrayPositivos);
            Array.Sort(arrayNegativos);
            Array.Reverse(arrayNegativos);

            while (positivos.Count() > 0)
            {
                positivos.Pop();
            }

            while (negativos.Count()>0)
            {
                negativos.Pop();
            }

            for (int i = 0; i < arrayPositivos.Length; i++)
            {
                positivos.Push(arrayPositivos[i]);
            }

            for (int i = 0; i < arrayPositivos.Length; i++)
            {
                negativos.Push(arrayNegativos[i]);
            }

            Console.WriteLine("\nb) Muestro positivos");
            foreach (int muestroPositivos in positivos)
            {
                Console.Write($" {muestroPositivos} ");
            }

            Console.WriteLine("\nc) Muestro negativos");
            foreach (int muestroNegativos in negativos)
            {
                Console.Write($" {muestroNegativos} ");
            }
            */

            Console.ReadKey();
        }
    }
}
