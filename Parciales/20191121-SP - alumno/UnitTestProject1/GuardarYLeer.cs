using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;


namespace TestUnitarios
{
    [TestClass]
    public class GuardarYLeer
    {
        [TestMethod]
        public void GuardarLeer()
        {
            Planeta pEnviado = new Planeta(12,12,12,null);
            Planeta pDevuelto;
            
            Xml<Planeta> xml = new Xml<Planeta>();
            xml.Guardar("hola", pEnviado);
            System.Threading.Thread.Sleep(1000);
            xml.Leer("hola",out pDevuelto);

            Assert.Equals(pEnviado, pDevuelto);
        }
    }
}
