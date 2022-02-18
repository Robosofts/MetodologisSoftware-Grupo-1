using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU3
    {
        [TestMethod]
        public void TestID()
        {
            string result = ProyectoVenta.Clientes.ID("1001522349");
            Assert.AreEqual("1001522349", result);
        }

        [TestMethod]
        public void TestID2()
        {
            string result = ProyectoVenta.Clientes.ID("1751759687");
            Assert.AreEqual("1751759687", result);
        }

        [TestMethod]
        public void TestIDF()
        {
            string result = ProyectoVenta.Clientes.ID("175175968");
            Assert.AreEqual("ID Invalido", result);
        }

        [TestMethod]
        public void TestIDF2()
        {
            string result = ProyectoVenta.Clientes.ID("17517596");
            Assert.AreEqual("ID Invalido", result);
        }

        [TestMethod]
        public void TestNombreCompleto()
        {
            string result = ProyectoVenta.Clientes.NombreCompleto("Genesis Anchundia");
            Assert.AreEqual("Genesis Anchundia", result);
        }

        [TestMethod]
        public void TestNombreCompleto2()
        {
            string result = ProyectoVenta.Clientes.NombreCompleto("Karla Criollo");
            Assert.AreEqual("Karla Criollo", result);
        }

        [TestMethod]
        public void TestNombreCompletoF()
        {
            string result = ProyectoVenta.Clientes.NombreCompleto("Karla");
            Assert.AreEqual("Nombre Invalido", result);
        }

        [TestMethod]
        public void TestNombreCompletoF2()
        {
            string result = ProyectoVenta.Clientes.NombreCompleto("Genesis");
            Assert.AreEqual("Nombre Invalido", result);
        }
    }
}
