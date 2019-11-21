using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Archivos
{
    public class Xml<T> : IArchivo<T>
    {
        public void Guardar(string archivo, T datos)
        {
            //Primero organizo el path donde voy a guardar el archivo
            string pathArchivoEnElEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo + ".xml");

            //Ahora que ya tengo el path, inicializo un writer y serializer
            XmlTextWriter writer = new XmlTextWriter(pathArchivoEnElEscritorio, Encoding.UTF8);
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            try
            {
                //Serializo los datos
                serializer.Serialize(writer, datos);
            }
            catch (Exception exc)
            {
                throw new Exception("Error al serializar XML", exc);
            }
            finally
            {
                //Cierro conexion
                writer.Close();
            }
        }

        public void Leer(string archivo, out T datos)
        {
            //Primero organizo el path donde voy a guardar el archivo
            string pathArchivoEnElEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), archivo + ".xml");

            try
            {
                using (XmlTextReader reader = new XmlTextReader(pathArchivoEnElEscritorio))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    datos = (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception exc)
            {
                datos = default;
                throw new Exception("Error al leer XML", exc);
            }
        }
    }
}
