using Microsoft.VisualStudio.TestTools.UnitTesting;
using Suma.Controllers;

namespace UnitTestSumar
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd1()
        {
            //Arrange
            Sumacontroller sumita = new Sumacontroller();
            int a = 5;
            int b = 8;
            int esperado = 13;

            //ACT
            int resultaso = sumita.Add(a, b);
            //Assert
            Assert.AreEqual(esperado, resultaso);
        }

        [TestMethod]
        public void TestAdd2()
        {
            //Arrange
            Sumacontroller sumita = new Sumacontroller();
            int a = -7;
            int b = -6;
            int esperado = -13;

            //ACT
            int resultaso = sumita.Add(a, b);
            //Assert
            Assert.AreEqual(esperado, resultaso);
        }


    }
}
