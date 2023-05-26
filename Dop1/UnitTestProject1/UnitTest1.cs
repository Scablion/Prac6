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
            int b = 7;
            int c = 8;
            double exp = 17.3205080756888;
            double act = Fxyz(a, b, c);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie1_2()
        {
            int a = 8;
            int b = 8;
            int c = 5;
            double exp = 14.142135623731;
            double act = Fxyz(a, b, c);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void DopZadanie1_3()
        {
            int a = 6;
            int b = 4;
            int c = 8;
            double exp = 11.6189500386223;
            double act = Fxyz(a, b, c);
            Assert.AreEqual(exp, act);
        }
    }
}
