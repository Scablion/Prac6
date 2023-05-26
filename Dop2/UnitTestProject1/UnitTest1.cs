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
            int x = 8;
            int[] exp = { 1, 1, 2, 3, 5, 8, 13, 21 };
            int[] act = Fib(x);
            CollectionAssert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie4_2()
        {
            int x = 5;
            int[] exp = {1,1,2,3,5};
            int[] act = Fib(x);
            CollectionAssert.AreEqual(exp, act);
        }
        [TestMethod]
        public void Zadanie4_3()
        {
            int x = 10;
            int[] exp = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int[] act = Fib(x);
            CollectionAssert.AreEqual(exp, act);
        }
    }
}
