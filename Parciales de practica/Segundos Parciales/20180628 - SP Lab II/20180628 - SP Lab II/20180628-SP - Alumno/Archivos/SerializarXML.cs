using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T Objeto)
        {
            bool retorno = true;
            try
            {
                string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo);

                XmlTextWriter xmlTextWriter = new XmlTextWriter(pathArchivoEnEscritorio, System.Text.Encoding.UTF8);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(xmlTextWriter, Objeto);
                xmlTextWriter.Close();
            }
            catch (Exception e)
            {
                retorno = false;
                throw new ErrorArchivoException("Error al guardar el archivo en XML", e);
            }

            return retorno;
        }

        public T Leer(string rutaArchivo)
        {
            T objeto;
            try
            {
                string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo);

                XmlTextReader xmlTextReader = new XmlTextReader(pathArchivoEnEscritorio);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                objeto = (T)xmlSerializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
            }
            catch (Exception e)
            {
                objeto = default(T);
                throw new ErrorArchivoException("Error al guardar el archivo en XML", e);
            }

            return objeto;
        }
    }
}
