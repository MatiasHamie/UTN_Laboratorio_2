﻿using System;
using System.Windows.Forms;//No olvidar de agregar esto

namespace Ejercicio_40CentralitaClases
{
    class Program
    {
        static void Main(string[] args)
        {
            //No olvidar de poner estas 3 lineas para arrancar un form
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CentralTelefonica());

            //// Mi central
            //Centralita c = new Centralita("Fede Center");

            //// Mis 4 llamadas
            //Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            //Provincial l2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            //Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            //Provincial l4 = new Provincial(Provincial.Franja.Franja_3, l2);

            //// Las llamadas se irán registrando en la Centralita. 
            //// La centralita mostrará por pantalla todas las llamadas según las vaya registrando. 
            //c += l1;
            ////Console.WriteLine(c.Mostrar());
            ////Console.WriteLine("------------------");

            //c += l2;
            ////Console.WriteLine(c.Mostrar());
            ////Console.WriteLine("------------------");

            //c += l3;
            ////Console.WriteLine(c.Mostrar());
            ////Console.WriteLine("------------------");

            //c += l4;
            ////Console.WriteLine(c.Mostrar());
            ////Console.WriteLine("------------------");

            ////c.OrdenarLlamadas();
            ////Console.WriteLine("[ORDENADAS POR DURACION]");
            ////Console.WriteLine(c.Mostrar());
            ////Console.WriteLine("------------------");

            //Console.ReadKey();

            //Console.WriteLine("Hello World!");
        }
    }
}

