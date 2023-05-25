using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static WpfApp1.Class1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 5;
            double actual = fn(a);
            double exeption = 7.23606797749979;
            Assert.AreEqual(actual, exeption);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double a = 4;
            double actual = fn(a);
            double exeption = 6;
            Assert.AreEqual(actual, exeption);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 9;
            double actual = fn(a);
            double exeption = 12;
            Assert.AreEqual(actual, exeption);
        }
    }
}
