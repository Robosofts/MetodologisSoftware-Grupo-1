using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU11
    {
        [TestMethod]
        public void TestCodBuscar()
        {
            string result = ProyectoVenta.Productos.CodBuscar("V001");
            Assert.AreEqual("Producto Encontrado", result);
        }

        [TestMethod]
        public void TestCodBuscar2()
        {
            string result = ProyectoVenta.Productos.CodBuscar("C001");
            Assert.AreEqual("Producto Encontrado", result);
        }

        [TestMethod]
        public void TestCodBuscarF()
        {
            string result = ProyectoVenta.Productos.CodBuscar("CP00");
            Assert.AreEqual("Producto no encontrado", result);
        }

        [TestMethod]
        public void TestCodBuscarF2()
        {
            string result = ProyectoVenta.Productos.CodBuscar("CO-1");
            Assert.AreEqual("Producto no encontrado", result);
        }

        [TestMethod]
        public void TestDesBuscar()
        {
            string result = ProyectoVenta.Productos.DesBuscar("talla m");
            Assert.AreEqual("Producto Encontrado", result);
        }

        [TestMethod]
        public void TestDesBuscar2()
        {
            string result = ProyectoVenta.Productos.DesBuscar("color rojo");
            Assert.AreEqual("Producto Encontrado", result);
        }

        [TestMethod]
        public void TestDesBuscarF()
        {
            string result = ProyectoVenta.Productos.DesBuscar("talla 21");
            Assert.AreEqual("Producto no encontrado", result);
        }

        [TestMethod]
        public void TestDesBuscarF2()
        {
            string result = ProyectoVenta.Productos.DesBuscar("20color");
            Assert.AreEqual("Producto no encontrado", result);
        }

        [TestMethod]
        public void TestCategBuscar()
        {
            string result = ProyectoVenta.Productos.CategBuscar("camiseta");
            Assert.AreEqual("Producto Encontrado", result);
        }

        [TestMethod]
        public void TestCategBuscar2()
        {
            string result = ProyectoVenta.Productos.CategBuscar("pantalon");
            Assert.AreEqual("Producto Encontrado", result);
        }

        [TestMethod]
        public void TestCategBuscarF()
        {
            string result = ProyectoVenta.Productos.CategBuscar("33gorras");
            Assert.AreEqual("Producto no encontrado", result);
        }

        [TestMethod]
        public void TestCategBuscarF2()
        {
            string result = ProyectoVenta.Productos.CategBuscar("159");
            Assert.AreEqual("Producto no encontrado", result);
        }
    }
}
