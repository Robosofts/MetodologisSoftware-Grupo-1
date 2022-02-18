using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class TestHU6
    {
        [TestMethod]
        public void TestIdmod()
        {
            string result = ProyectoVenta.Clientes.IDmod("1707014302 == 1717014302");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestIdmod2()
        {
            string result = ProyectoVenta.Clientes.IDmod("1000000000 == 1000000002");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestIdmodF()
        {
            string result = ProyectoVenta.Clientes.IDmod("1000000000 == 1000000");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestIdmodF2()
        {
            string result = ProyectoVenta.Clientes.IDmod("1000000000 == 10000001");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestNombreCompletomod()
        {
            string result = ProyectoVenta.Clientes.NombreCompletomod("Genesis Anchundia == Genesis Moreira");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestNombreCompletomod2()
        {
            string result = ProyectoVenta.Clientes.NombreCompletomod("Camilo Arrieta == Camila Arrieta");
            Assert.AreEqual("Modificacion Registrada", result);
        }

        [TestMethod]
        public void TestNombreCompletomodF()
        {
            string result = ProyectoVenta.Clientes.NombreCompletomod("Andrea Arias == Arias");
            Assert.AreEqual("Error en la Modificacion", result);
        }

        [TestMethod]
        public void TestNombreCompletomodF2()
        {
            string result = ProyectoVenta.Clientes.NombreCompletomod("Dayana Chavez == Dayana");
            Assert.AreEqual("Error en la Modificacion", result);
        }
    }

}
