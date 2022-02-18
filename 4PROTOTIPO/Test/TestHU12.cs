using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU12
    {
        [TestMethod]
        public void TestIDBuscar()
        {
            string result = ProyectoVenta.Clientes.IDBuscar("1457125521");
            Assert.AreEqual("Cliente encontrado", result);
        }

        [TestMethod]
        public void TestIDBuscar2()
        {
            string result = ProyectoVenta.Clientes.IDBuscar("1471235946");
            Assert.AreEqual("Cliente encontrado", result);
        }

        [TestMethod]
        public void TestIDBuscarF()
        {
            string result = ProyectoVenta.Clientes.IDBuscar("147123");
            Assert.AreEqual("Cliente no encontrado", result);
        }

        [TestMethod]
        public void TestIDBuscarF2()
        {
            string result = ProyectoVenta.Clientes.IDBuscar("1752019164F");
            Assert.AreEqual("Cliente no encontrado", result);
        }

        [TestMethod]
        public void TestNombreCompletoBuscar()
        {
            string result = ProyectoVenta.Clientes.NombreCompletoBuscar("Genesis Anchundia");
            Assert.AreEqual("Cliente encontrado", result);
        }

        [TestMethod]
        public void TestNombreCompletoBuscar2()
        {
            string result = ProyectoVenta.Clientes.NombreCompletoBuscar("Dayana Chaves");
            Assert.AreEqual("Cliente encontrado", result);
        }

        [TestMethod]
        public void TestNombreCompletoBuscarF()
        {
            string result = ProyectoVenta.Clientes.NombreCompletoBuscar("C002");
            Assert.AreEqual("Cliente no encontrado", result);
        }

        [TestMethod]
        public void TestNombreCompletoBuscarF2()
        {
            string result = ProyectoVenta.Clientes.NombreCompletoBuscar("Genesis28");
            Assert.AreEqual("Cliente no encontrado", result);
        }
    }
}
