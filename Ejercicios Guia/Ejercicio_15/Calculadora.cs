using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_15
{
    class Calculadora
    {
        public static double Calcular(double primero, double segundo, char operacion)
        {
            double resultado = 0;

            switch (operacion)
            {
                case '+':
                    resultado = primero + segundo;
                    break;
                case '-':
                    resultado = primero - segundo;
                    break;
                case '*':
                    resultado = primero * segundo;
                    break;
                case '/':
                    if (Validar(segundo))
                    {
                        resultado = primero / segundo;
                    }
                    else
                    {
                        resultado = -999.999;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("No se puede dividir por cero!");
                    }
                    break;
            }

            return resultado;
        }

        private static bool Validar(double segundo)
        {
            if (segundo != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
