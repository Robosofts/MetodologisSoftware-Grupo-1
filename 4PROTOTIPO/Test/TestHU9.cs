using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU9
    {
        [TestMethod]
        public void TestIDelim()
        {
            string result = ProyectoVenta.Clientes.IDElim("1752019164");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestIDelim2()
        {
            string result = ProyectoVenta.Clientes.IDElim("1471235946");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestIDelimF()
        {
            string result = ProyectoVenta.Clientes.IDElim("147123594600");
            Assert.AreEqual("Error: No existe el ID", result);
        }

        [TestMethod]
        public void TestIDelimF2()
        {
            string result = ProyectoVenta.Clientes.IDElim("175201916400");
            Assert.AreEqual("Error: No existe el ID", result);
        }

        [TestMethod]
        public void TestNombreCompletoelim()
        {
            string result = ProyectoVenta.Clientes.NombreCompletoElim("Karla Criollo");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestNombreCompletoelim2()
        {
            string result = ProyectoVenta.Clientes.NombreCompletoElim("Dayana Chaves");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestNombreCompletoelimF()
        {
            string result = ProyectoVenta.Clientes.NombreCompletoElim("Dayana");
            Assert.AreEqual("Error: No existe el Cliente", result);
        }

        [TestMethod]
        public void TestNombreCompletoelimF2()
        {
            string result = ProyectoVenta.Clientes.NombreCompletoElim("Anchundia");
            Assert.AreEqual("Error: No existe el Cliente", result);
        }
    }
}
