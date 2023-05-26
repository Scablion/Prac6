using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static WpfApp4.Class1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Zadanie4_1()
        {
            double x = -1;
            double exp = 3;
            double act = fx(x);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie4_2()
        {
            double x = 0.5;
            double exp = 2;
            double act = fx( x);
            Assert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie4_3()
        {
            double x = 3;
            double exp = -0.5;
            double act = fx( x);
            Assert.AreEqual(exp, act);
        }
    }
}
