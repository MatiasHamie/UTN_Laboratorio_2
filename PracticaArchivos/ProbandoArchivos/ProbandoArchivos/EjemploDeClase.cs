using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProbandoArchivos
{
    public class EjemploDeClase
    {
        public int edad;
        public string nombre;
        public string apellido;

        public EjemploDeClase() { }

        public EjemploDeClase(int edad, string nombre, string apellido)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat($"Edad: {this.edad}\n");
            sb.AppendFormat($"Nombre: {this.nombre}\n");
            sb.AppendFormat($"Apellido: {this.apellido}\n");

            return sb.ToString();
        }

        public bool LeerArchivo(string path, out string infoALeer)
        {
            StreamReader srFile = new StreamReader(path);
            infoALeer = srFile.ReadToEnd();
            srFile.Close();

            return true;
        }

        public bool GuardarArchivo(string path, string infoAGuardar)
        {
            StreamWriter swFile = new StreamWriter(path);
            swFile.WriteLine(infoAGuardar);
            swFile.Close();

            return true;
        }

    }
}
