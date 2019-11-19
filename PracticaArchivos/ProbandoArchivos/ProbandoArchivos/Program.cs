using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProbandoArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            ////--- Probando escribir un archivo ---
            //string pathDelEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ////StreamWriter swArchivo = new StreamWriter(@"C:\Users\yotut\Desktop\Programming\C#\Laboratorio 2\PracticaArchivos\Archivo_01.txt");
            //StreamWriter swArchivo = new StreamWriter($"{pathDelEscritorio}\\Archivo_01.txt");
            //swArchivo.WriteLine("Texto que se va a escribir en el archivo");
            //swArchivo.Close();

            ////--- Probando leer un archivo ---
            //StreamReader srArchivo = new StreamReader($"{pathDelEscritorio}\\Archivo_01.txt");
            //string loQueLeiDelArchivo = srArchivo.ReadToEnd();
            //srArchivo.Close();

            //Console.WriteLine(loQueLeiDelArchivo);

            //EjemploDeClase persona = new EjemploDeClase(18, "Matias", "Hamie");
            //string pathDelEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //string pathArchivo = $"{pathDelEscritorio}\\Archivo_01.txt";

            //string infoPersonaW = persona.MostrarDatos();
            //persona.GuardarArchivo(pathArchivo, infoPersonaW);

            //string infoPersonaR = "";
            //persona.LeerArchivo(pathArchivo, out infoPersonaR);
            //Console.WriteLine(infoPersonaR);

            //--- XML ---

            string pathDelEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            EjemploDeClase persona = new EjemploDeClase(18, "Matias", "Hamie");
            EjemploDeClase personaInicializadaPorXml = new EjemploDeClase();

            string pathArchivoXml = $"{pathDelEscritorio}\\Archivo_01.txt";

            ArchivoXML<EjemploDeClase> xml = new ArchivoXML<EjemploDeClase>();
            xml.GuardarXml(pathArchivoXml, persona);
            xml.LeerXml(pathArchivoXml, out personaInicializadaPorXml);

            Console.WriteLine($"{personaInicializadaPorXml.apellido}");
            Console.WriteLine($"{personaInicializadaPorXml.nombre}");
            Console.WriteLine($"{personaInicializadaPorXml.edad}");

            Console.ReadKey();
        }
    }
}
