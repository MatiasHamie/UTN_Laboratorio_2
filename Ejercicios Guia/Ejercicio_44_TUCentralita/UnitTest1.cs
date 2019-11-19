using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_40CentralitaClases;

namespace Ejercicio_44_TUCentralita
{
    [TestClass]
    public class TestUnitarioCentralita
    {
        /// <summary>
        /// Crear un test unitario que valide que la lista
        /// de llamadas de la centralita esté instanciada al
        /// crear un nuevo objeto del tipo Centralita
        /// </summary>
        [TestMethod]
        public void CentralitaIsNotNull()
        {
            #region Arrange
            Centralita centralita;
            #endregion

            #region Act
            centralita = new Centralita("Hamie S.A.");
            #endregion

            #region Assert
            Assert.IsNotNull(centralita);
            #endregion
        }

        /// <summary>
        /// Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
        /// se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
        /// destino de una llamada Local ya existente
        /// </summary>
        [TestMethod]
        public void TwoEqualsCallsProvincial()
        {
            #region Arrange
            Provincial provincial1;
            Provincial provincial2;
            #endregion

            #region Act
            provincial1 = new Provincial("1234", Provincial.Franja.Franja_1, (float)12.8, "5678");
            provincial2 = new Provincial("1234", Provincial.Franja.Franja_2, (float)34.2, "5678");
            #endregion

            #region Assert
            Assert.IsTrue(provincial1 == provincial2);
            #endregion
        }

        /// <summary>
        /// Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
        /// se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
        /// destino de una llamada Provincial ya existente
        /// </summary>
        [TestMethod]
        public void TwoEqualCallsLocal()
        {
            #region Arrange
            Local local1;
            Local local2;
            #endregion

            #region Act
            local1 = new Local("1234", (float)24.3, "5678", (float)123.4);
            local2 = new Local("1234", (float)34.2, "5678", (float)54.23);
            #endregion

            #region Assert
            Assert.IsTrue(local1 == local2);
            #endregion
        }

        /// <summary>
        /// Dentro de un método de test unitario crear dos llamadas Local y dos Provincial, todos con
        /// los mismos datos de origen y destino.
        /// Luego comparar cada uno de estos cuatro objetos
        /// contra los demás, debiendo ser iguales solamente las instancias de Local y de Provincial
        /// entre sí
        /// </summary>
        [TestMethod]
        public void TwoEqualCallsProvLoc()
        {
            #region Arrange
            Provincial provincial1;
            Provincial provincial2;
            Local local1;
            Local local2;
            #endregion

            #region Act
            local1 = new Local("1234", (float)24.3, "5678", (float)123.4);
            local2 = new Local("1234", (float)34.2, "5678", (float)54.23);
            provincial1 = new Provincial("1234", Provincial.Franja.Franja_1, (float)12.8, "5678");
            provincial2 = new Provincial("1234", Provincial.Franja.Franja_2, (float)34.2, "5678");
            #endregion

            #region Assert
            Assert.IsTrue(local1 == local2);
            Assert.IsTrue(provincial1 == provincial2);
            Assert.IsFalse(local1 == provincial1);
            Assert.IsFalse(local1 == provincial2);
            Assert.IsFalse(local2 == provincial1);
            Assert.IsFalse(local2 == provincial2);
            #endregion
        }
    }
}
