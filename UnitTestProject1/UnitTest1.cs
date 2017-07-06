using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio04;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Datos datos = new Datos();
            datos.message = "Mensaje de prueba";
            datos.numberOne = 1;
            datos.numberTwo = 2; 
            UsoDatos sut = new UsoDatos();
            Assert.AreEqual(sut.UsarDatos(datos), "Mensaje de prueba: 1, 2");
        }
    }
}
