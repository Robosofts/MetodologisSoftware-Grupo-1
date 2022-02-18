using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU2
    {
        [TestMethod]
        public void TestCodigoT()
        {
            string result = ProyectoVenta.Productos.CodigoP("P000");
            Assert.AreEqual("P000", result);
        }

        [TestMethod]
        public void TestCodigoT2()
        {
            string result = ProyectoVenta.Productos.CodigoP("V002");
            Assert.AreEqual("V002", result);
        }


        [TestMethod]
        public void TestCodigoF()
        {
            string result = ProyectoVenta.Productos.CodigoP("AA123");
            Assert.AreEqual("Codigo Invalido", result);
        }

        [TestMethod]
        public void TestCodigoF2()
        {
            string result = ProyectoVenta.Productos.CodigoP("Y1235");
            Assert.AreEqual("Codigo Invalido", result);
        }

        [TestMethod]
        public void TestCategoriaT()
        {
            string result = ProyectoVenta.Productos.CategoriaP("vestido");
            Assert.AreEqual("vestido", result);
        }

        [TestMethod]
        public void TestCategoriaT2()
        {
            string result = ProyectoVenta.Productos.CategoriaP("pantalones");
            Assert.AreEqual("pantalones", result);
        }

        [TestMethod]
        public void TestCategoriaF()
        {
            string result = ProyectoVenta.Productos.CategoriaP("01S4");
            Assert.AreEqual("Categoria Invalido", result);
        }

        [TestMethod]
        public void TestCategoriaF2()
        {
            string result = ProyectoVenta.Productos.CategoriaP("-10");
            Assert.AreEqual("Categoria Invalido", result);
        }


        [TestMethod]

        public void TestDescripcion()
        {
            string result = ProyectoVenta.Productos.DescripcionP("talla s");
            Assert.AreEqual("talla s", result);
        }

        [TestMethod]

        public void TestDescripcion2()
        {
            string result = ProyectoVenta.Productos.DescripcionP("color azul");
            Assert.AreEqual("color azul", result);
        }


        [TestMethod]
        public void TestDescripcionF()
        {
            string result = ProyectoVenta.Productos.DescripcionP("01S200");
            Assert.AreEqual("Descripcion Invalida", result);
        }


        [TestMethod]
        public void TestDescripcionF2()
        {
            string result = ProyectoVenta.Productos.DescripcionP("Vestido");
            Assert.AreEqual("Descripcion Invalida", result);
        }
    }
}
