using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU1
    {

   
        [TestMethod]
        public void Testnombre()
        {
            string result = ProyectoVenta.Proveedores.nombreP("TextCuenca");
            Assert.AreEqual("TextCuenca", result);
        }

        [TestMethod]
        public void TestnombreT()
        {
            string result = ProyectoVenta.Proveedores.nombreP("TextQuito");
            Assert.AreEqual("TextQuito", result);
        }


        [TestMethod]
        public void TestnombreF()
        {
            string result = ProyectoVenta.Proveedores.nombreP("5");
            Assert.AreEqual("Nombre Invalido", result);
        }

        [TestMethod]
        public void TestnombreF2()
        {
            string result = ProyectoVenta.Proveedores.nombreP("-1");
            Assert.AreEqual("Nombre Invalido", result);
        }

        [TestMethod]
        public void TestRucDR()
        {
            string result = ProyectoVenta.Proveedores.RucP("1234567891234");
            Assert.AreEqual("1234567891234", result);
        }

        [TestMethod]
        public void TestRucDR2()
        {
            string result = ProyectoVenta.Proveedores.RucP("1234567891235");
            Assert.AreEqual("1234567891235", result);
        }

        [TestMethod]
        public void TestRucFR()
        {
            string result = ProyectoVenta.Proveedores.RucP("12345678912345");
            Assert.AreEqual("ruc invalido", result);
        }

        [TestMethod]
        public void TestRucFR2()
        {
            string result = ProyectoVenta.Proveedores.RucP("12345678912320");
            Assert.AreEqual("ruc invalido", result);
        }
    }
}
