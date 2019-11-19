using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades
{
    public class SerializarXML<T> : IArchivos<T>
    {
        public bool Guardar(string rutaArchivo, T objeto)
        {
            bool retorno = true;
            try
            {
                string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo);

                XmlTextWriter xmlTextWriter = new XmlTextWriter(pathArchivoEnEscritorio, System.Text.Encoding.UTF8);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                xmlSerializer.Serialize(xmlTextWriter, objeto);
                xmlTextWriter.Close();
            }
            catch (Exception e)
            {
                retorno = false;
                throw new ErrorArchivoException(e);
            }

            return retorno;
        }

        public T Leer(string rutaArchivo)
        {
            T archivo;
            try
            {
                string pathArchivoEnEscritorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), rutaArchivo);

                XmlTextReader xmlTextReader = new XmlTextReader(pathArchivoEnEscritorio);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

                archivo = (T)xmlSerializer.Deserialize(xmlTextReader);
                xmlTextReader.Close();
            }
            catch (Exception e)
            {
               throw new ErrorArchivoException(e);
            }

            return archivo;
        }
    }
}
