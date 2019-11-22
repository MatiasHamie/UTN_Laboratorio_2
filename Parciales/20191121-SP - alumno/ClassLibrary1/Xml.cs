using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1;
using System.Xml;
using System.Xml.Serialization;
using Entidades;

namespace Archivos
{
    public class Xml<T>:IFiles<T>
    {
        #region Propiedades
        public string GetDirectory
        {
            get
            {
                string pathEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                pathEscritorio += @"\";
                return pathEscritorio;
            }
        }
        #endregion

        #region Métodos
        public bool FileExists(string nombreArchivo)
        {
            return File.Exists(this.GetDirectory + nombreArchivo);
        }

        public void Guardar(string nombreArchivo, T objeto)
        {
            if(nombreArchivo is null)
            {
                throw new ErrorArchivosException("Error al guardar xml");
            }
            
            string pathArchivo = this.GetDirectory + nombreArchivo;
            
            XmlTextWriter xmlTextWriter = new XmlTextWriter(pathArchivo, System.Text.Encoding.UTF8);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            try
            {
                xmlSerializer.Serialize(xmlTextWriter, objeto);
            }
            catch (Exception)
            {
                objeto = default(T);
                
            }
            finally
            {
                xmlTextWriter.Close();
            }
        }

        public void Guardar(string nombreArchivo, T objeto, Encoding encoding)
        {
            string pathArchivo = this.GetDirectory + nombreArchivo;
            XmlTextWriter xmlTextWriter = new XmlTextWriter(pathArchivo, encoding);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            try
            {
                xmlSerializer.Serialize(xmlTextWriter, objeto);
            }
            catch (Exception)
            {
                objeto = default(T);
            }
            finally
            {
                xmlTextWriter.Close();
            }
        }

        public void Leer(string nombreArchivo, out T objeto)
        {
            string pathArchivo = this.GetDirectory + nombreArchivo;
            XmlTextReader xmlTextReader = new XmlTextReader(pathArchivo);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            try
            {
                objeto = (T)xmlSerializer.Deserialize(xmlTextReader);
            }
            catch (Exception)
            {
                objeto = default(T);
                throw new ErrorArchivosException("Error al guardar XML");
            }
            finally
            {
                xmlTextReader.Close();
            }
        }

        public void Leer(string nombreArchivo, out T objeto, Encoding encoding)
        {
            string pathArchivo = this.GetDirectory + nombreArchivo;
            XmlTextReader xmlTextReader = new XmlTextReader(pathArchivo);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));

            try
            {
                objeto = (T)xmlSerializer.Deserialize(xmlTextReader);
            }
            catch (Exception)
            {
                objeto = default(T);
            }
            finally
            {
                xmlTextReader.Close();
            }
        }
        #endregion
    }
}
