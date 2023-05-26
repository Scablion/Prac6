using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static WpfApp4.Class1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Zadanie1_1()
        {
            int a = 5;
            int b = 10;
            int c = 2;
            double exp = 3;
            double act = Fxyz(a, b, c);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie1_2()
        {
            int a = 5;
            int b = 10;
            int c = 2;
            double exp = 2;
            double act = Fxyz(a, b, c);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void DopZadanie1_3()
        {
            int a = 5;
            int b = 10;
            int c = 2;
            double exp = -0.5;
            double act = Fxyz(a, b, c);
            Assert.AreEqual(exp, act);
        }
    }
}
