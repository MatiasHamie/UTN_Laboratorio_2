using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {
            Negocio negocio = new Negocio("PIRULO");
            PuestoAtencion puesto = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
            Cliente cliente1 = new Cliente(90, "Matias");
            Cliente cliente2 = new Cliente(91, "Alejandra");
            Cliente cliente3 = new Cliente(92, "Federico");
            Cliente cliente4 = new Cliente(93, "Sol");
            Cliente cliente5 = new Cliente(93, "Sol");

            if(negocio + cliente1)//Si no uso un if, o algo que agarre el rtorno bool tira error
            {
                Console.Write("Se agregó cliente 1 ");
                Console.WriteLine($"[Nombre] {cliente1.Nombre}, [Numero] {cliente1.Numero}");
            }
            else
            {
                Console.WriteLine("No se agregó cliente 1");
            }

            if (negocio + cliente2)//Si no uso un if, o algo que agarre el rtorno bool tira error
            {
                Console.Write("Se agregó cliente 2 ");
                Console.WriteLine($"[Nombre] {cliente2.Nombre}, [Numero] {cliente2.Numero}");
            }
            else
            {
                Console.WriteLine("No se agregó cliente 2");
            }

            if (negocio + cliente3)//Si no uso un if, o algo que agarre el rtorno bool tira error
            {
                Console.Write("Se agregó cliente 3 ");
                Console.WriteLine($"[Nombre] {cliente3.Nombre}, [Numero] {cliente3.Numero}");
            }
            else
            {
                Console.WriteLine("No se agregó cliente 3");
            }

            if (negocio + cliente4)//Si no uso un if, o algo que agarre el rtorno bool tira error
            {
                Console.Write("Se agregó cliente 4 ");
                Console.WriteLine($"[Nombre] {cliente4.Nombre}, [Numero] {cliente4.Numero}");
            }
            else
            {
                Console.WriteLine("No se agregó cliente 4");
            }

            if (negocio + cliente5)//Si no uso un if, o algo que agarre el rtorno bool tira error
            {
                Console.Write("Se agregó cliente 5 ");
                Console.WriteLine($"[Nombre] {cliente5.Nombre}, [Numero] {cliente5.Numero}");
            }
            else
            {
                Console.WriteLine("No se agregó cliente 5");
            }

            Console.WriteLine($"\n-- Clientes en espera: '{negocio.ClientesPendientes}' --");
            for (int i = negocio.ClientesPendientes; i > 0; i--)
            {
                if (~negocio)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Cliente atendido..!!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Clientes pendientes {negocio.ClientesPendientes}");
                }
            }

            Console.ReadKey();
        }
    }
}
