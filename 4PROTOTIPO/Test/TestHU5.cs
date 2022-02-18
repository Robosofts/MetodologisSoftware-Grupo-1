using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU5
    {
        [TestMethod]
        public void TestCodmod()
        {
            string result = ProyectoVenta.Productos.Codmod("P000 == P001");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestCodmod2()
        {
            string result = ProyectoVenta.Productos.Codmod("P003 == P002");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestCodmodF()
        {
            string result = ProyectoVenta.Proveedores.Rucmod("C002 == 1");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestCodmodF2()
        {
            string result = ProyectoVenta.Proveedores.Rucmod("C002 == -2");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestDesmod()
        {
            string result = ProyectoVenta.Productos.Desmod("talla s == talla xl ");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestDesmod2()
        {
            string result = ProyectoVenta.Productos.Desmod("color azul == color rojo");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestDesmodF()
        {
            string result = ProyectoVenta.Productos.Desmod("talla xl == color");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestDesmodF2()
        {
            string result = ProyectoVenta.Productos.Desmod("color azul == 1");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestCategoriamod()
        {
            string result = ProyectoVenta.Productos.Categmod("vestido == pantalon");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestCategoriamod2()
        {
            string result = ProyectoVenta.Productos.Categmod("camisetas == blusas");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestCategoriamodF()
        {
            string result = ProyectoVenta.Productos.Categmod("blusas == 0");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestCategoriamodF2()
        {
            string result = ProyectoVenta.Productos.Categmod("vestidos == talla");
            Assert.AreEqual("Error en la Modificacion", result);
        }
    }
}
