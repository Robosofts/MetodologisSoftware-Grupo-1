using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU4
    {
        [TestMethod]
        public void Testnommod()
        {
            string result = ProyectoVenta.Proveedores.nommod("TextCuenca == TextQuito");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void Testnommod2()
        {
            string result = ProyectoVenta.Proveedores.nommod("TextQuito == TextGuayaquill");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestnommodF()
        {
            string result = ProyectoVenta.Proveedores.nommod("TextCuenca == 2");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestnommodF2()
        {
            string result = ProyectoVenta.Proveedores.nommod("TextCuenca == 98");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestRucmod()
        {
            string result = ProyectoVenta.Proveedores.Rucmod("1768156470001 == 1768156470002");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestRucmod2()
        {
            string result = ProyectoVenta.Proveedores.Rucmod("1768156470010 == 1768156470015");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestRucmodF()
        {
            string result = ProyectoVenta.Proveedores.Rucmod("1768156470010 == 1768156470");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestRucmodF2()
        {
            string result = ProyectoVenta.Proveedores.Rucmod("1768156470010 == 176815647");
            Assert.AreEqual("Error en la Modificacion", result);
        }
    }
}
