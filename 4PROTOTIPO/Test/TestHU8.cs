using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU8
    {
        [TestMethod]
        public void TestCodelim()
        {
            string result = ProyectoVenta.Productos.CodElim("P001");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestCodelim2()
        {
            string result = ProyectoVenta.Productos.CodElim("C002");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestCodelimF()
        {
            string result = ProyectoVenta.Productos.CodElim("PP00");
            Assert.AreEqual("Error: No existe el codigo del producto", result);
        }

        [TestMethod]
        public void TestCodelimF2()
        {
            string result = ProyectoVenta.Productos.CodElim("CC02");
            Assert.AreEqual("Error: No existe el codigo del producto", result);
        }

        [TestMethod]
        public void TestDeselim()
        {
            string result = ProyectoVenta.Productos.DesElim("talla s");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestDeselim2()
        {
            string result = ProyectoVenta.Productos.DesElim("color azul");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestDeselimF()
        {
            string result = ProyectoVenta.Productos.DesElim("color 0");
            Assert.AreEqual("Error: No existe la descripcion", result);
        }

        [TestMethod]
        public void TestDeselimF2()
        {
            string result = ProyectoVenta.Productos.DesElim("talla -1");
            Assert.AreEqual("Error: No existe la descripcion", result);
        }

        [TestMethod]
        public void TestCategelim()
        {
            string result = ProyectoVenta.Productos.CategElim("blusa");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestCategelim2()
        {
            string result = ProyectoVenta.Productos.CategElim("vestido");
            Assert.AreEqual("Eliminado", result);
        }

        [TestMethod]
        public void TestCategelimF()
        {
            string result = ProyectoVenta.Productos.CategElim("gorras");
            Assert.AreEqual("Error: No existe el codigo del producto", result);
        }

        [TestMethod]
        public void TestCategelimF2()
        {
            string result = ProyectoVenta.Productos.CategElim("0vestidos");
            Assert.AreEqual("Error: No existe el codigo del producto", result);
        }
    }
}
