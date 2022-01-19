using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AuthThest
{
    [TestClass]
    public class UnitTest1
    {
       
        // testeo de casos  de prueba 
        [TestMethod]
        public void Testnombre()
        {
            string result = WindowsFormsAppProyectoMDS1.Poveedores.nombreP();
            Assert.AreEqual("cualquier nombre", result);
        }

        //Pruebas unitarias 
     

        [TestMethod]
        public void TestRucDR()
        {
            string result = WindowsFormsAppProyectoMDS1.Poveedores.RucP("1234567891234");
            Assert.AreEqual("1234567891234", result);
        }

        [TestMethod]
        public void TestRucFR()
        {
            string result = WindowsFormsAppProyectoMDS1.Poveedores.RucP("12345678912345");
            Assert.AreEqual("ruc invalido", result);
        }

        [TestMethod]
        public void TestNumTelfDR()
        {
            string result = WindowsFormsAppProyectoMDS1.Poveedores.NumTelfP("0992836492");
            Assert.AreEqual("0992836492", result);
        }

        [TestMethod]

        public void TestNumTelfFR()
        {
            string result = WindowsFormsAppProyectoMDS1.Poveedores.NumTelfP("09992836492");
            Assert.AreEqual("el numero de telefono no existe", result);
        }

        [TestMethod]
        public void TestDir()
        {
            string result = WindowsFormsAppProyectoMDS1.Poveedores.DirP("ibarra");
            Assert.AreEqual("Ibarra", result);
        }

        [TestMethod]
        public void TestDirF()
        {
            string result = WindowsFormsAppProyectoMDS1.Poveedores.DirP("guayaquil");
            Assert.AreEqual("ingrese nueva cuidad del Proveedor ", result);
        }

        [TestMethod]
        public void TestProdD()
        {
            string result = WindowsFormsAppProyectoMDS1.Poveedores.ProdP("camisetas");
            Assert.AreEqual("camisetas", result);
        }

        [TestMethod]
        public void TestProdF()
        {
            string result = WindowsFormsAppProyectoMDS1.Poveedores.ProdP("vestidos");
            Assert.AreEqual("realise un ingreso de nuevo producto", result);
        }


    }
}
