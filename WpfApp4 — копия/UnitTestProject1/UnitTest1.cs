using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static WpfApp4.MainWindow;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Zadanie4_1()
        {
            int a = 5;
            int b = 10;
            int h = 2;
            double x = -1;
            double exp = 3;
            double act = Tas(a, b, h, x);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie4_2()
        {
            int a = 5;
            int b = 10;
            int h = 2;
            double x = 0.5;
            double exp = 2;
            double act = Tas(a, b, h, x);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie4_3()
        {
            int a = 5;
            int b = 10;
            int h = 2;
            double x = 3;
            double exp = -0.5;
            double act = Tas(a, b, h, x);
            Assert.AreEqual(exp, act);
        }
    }
}
