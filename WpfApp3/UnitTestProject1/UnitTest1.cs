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
            int a = 0;
            int actual = fx(a);
            int exeption = 0;
            Assert.AreEqual(actual, exeption);
        }
        [TestMethod]
        public void TestMethod2()
        {
            int a = -23;
            int actual = fx(a);
            int exeption = -1;
            Assert.AreEqual(actual, exeption);
        }
        [TestMethod]
        public void TestMethod3()
        {
            int a = 6788;
            int actual = fx(a);
            int exeption = 1;
            Assert.AreEqual(actual, exeption);
        }
    }
}
