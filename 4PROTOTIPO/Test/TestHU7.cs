using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU7
    {
        [TestMethod]
        public void Testnombreelim()
        {
            string result = ProyectoVenta.Proveedores.NomElim("Adrian Simbaña");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void Testnombreelim2()
        {
            string result = ProyectoVenta.Proveedores.NomElim("Moises Socasi");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestnombreelimF()
        {
            string result = ProyectoVenta.Proveedores.NomElim("099");
            Assert.AreEqual("Error: No existe el nombre del proveedor", result);
        }
        [TestMethod]
        public void TestnombreelimF2()
        {
            string result = ProyectoVenta.Proveedores.NomElim("-4");
            Assert.AreEqual("Error: No existe el nombre del proveedor", result);
        }

        [TestMethod]
        public void TestRucelim()
        {
            string result = ProyectoVenta.Proveedores.RucElim("1752019164000");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestRucelim2()
        {
            string result = ProyectoVenta.Proveedores.RucElim("1354872168000");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestRucelimF()
        {
            string result = ProyectoVenta.Proveedores.RucElim("1354872168");
            Assert.AreEqual("Error: No existe el RUC del proveedor", result);
        }

        [TestMethod]
        public void TestRucelimF2()
        {
            string result = ProyectoVenta.Proveedores.RucElim("17520191");
            Assert.AreEqual("Error: No existe el RUC del proveedor", result);
        }
    }
}
