using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU10
    {
        [TestMethod]
        public void TestnombreBuscar()
        {
            string result = ProyectoVenta.Proveedores.NomBuscar("Anahi Ruales");
            Assert.AreEqual("Proveedor encontrado", result);
        }

        [TestMethod]
        public void TestnombreBuscar2()
        {
            string result = ProyectoVenta.Proveedores.NomBuscar("Marcos Lopez");
            Assert.AreEqual("Proveedor encontrado", result);
        }

        [TestMethod]
        public void TestnombreBuscarF()
        {
            string result = ProyectoVenta.Proveedores.NomBuscar("Liz001");
            Assert.AreEqual("Proveedor no encontrado", result);
        }
        [TestMethod]
        public void TestnombreBuscarF2()
        {
            string result = ProyectoVenta.Proveedores.NomBuscar("David-1");
            Assert.AreEqual("Proveedor no encontrado", result);
        }

        [TestMethod]
        public void TestRucBuscar()
        {
            string result = ProyectoVenta.Proveedores.RucBuscar("1402574123000");
            Assert.AreEqual("Proveedor encontrado", result);
        }

        [TestMethod]
        public void TestRucBuscar2()
        {
            string result = ProyectoVenta.Proveedores.RucBuscar("1752019164000");
            Assert.AreEqual("Proveedor encontrado", result);
        }

        [TestMethod]
        public void TestRucBuscarF()
        {
            string result = ProyectoVenta.Proveedores.RucBuscar("135487216800846");
            Assert.AreEqual("Proveedor no encontrado", result);
        }

        [TestMethod]
        public void TestRucBuscarF2()
        {
            string result = ProyectoVenta.Proveedores.RucBuscar("175201916400011");
            Assert.AreEqual("Proveedor no encontrado", result);
        }
    }
}
