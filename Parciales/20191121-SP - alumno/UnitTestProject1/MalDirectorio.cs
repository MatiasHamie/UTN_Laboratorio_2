using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;

namespace UnitTestProject1
{
    [TestClass]
    public class MalDirectorio
    {
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void CargarMalDirectorio()
        {
            Planeta planeta = new Planeta();

            Xml<Planeta> xml = new Xml<Planeta>();

            xml.Guardar(null, planeta);
        }
    }
}
