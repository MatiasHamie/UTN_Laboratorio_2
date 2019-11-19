using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ProbandoArchivos
{
    class ArchivoXML<T>
    {
        public bool GuardarXml(string archivoXml, T datosDelObjeto)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter(archivoXml, System.Text.Encoding.UTF8);
            XmlSerializer xmlSer = new XmlSerializer(typeof(T));
            xmlSer.Serialize(xmlWriter, datosDelObjeto);
            xmlWriter.Close();

            return true;
        }

        public bool LeerXml(string archivoXml,out T datosDelObjeto)
        {
            XmlTextReader xmlReader = new XmlTextReader(archivoXml);
            XmlSerializer xmlSer = new XmlSerializer(typeof(T));
            datosDelObjeto = (T)xmlSer.Deserialize(xmlReader);
            xmlReader.Close();

            return true;
        }
    }
}
