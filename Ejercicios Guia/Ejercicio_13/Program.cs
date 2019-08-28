using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 13. Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos): string DecimalBinario(double).
 * Convierte un número de entero a binario. double BinarioDecimal(string).
 * Convierte un número binario a entero. 
 */

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            string numBin = "";

            Console.WriteLine("Ingrese un número en binario..");
            numBin = Console.ReadLine();

            /*
            Console.WriteLine("Ingrese un número..");

            while(!int.TryParse(Console.ReadLine(),out num) || num<0)
            {
                Console.WriteLine("ERROR, Reingrese el número..");
            }
            */
            //numBin=Conversor.DecimalBinario(num);
            num = (int)Conversor.BinarioDecimal(numBin);

            //Console.WriteLine("Numero Decimal: {0:#,###.00} en Binario es: {1}",num,numBin);
            Console.WriteLine("Numero Binario: {0} en Decimal es: {1}",numBin,num);
            Console.ReadKey();
            
        }
    }
}
