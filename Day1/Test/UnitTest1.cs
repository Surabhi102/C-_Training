using Class;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod3()
        {
            int[] a = { 2,3,4,2,3 };
            Class1 pair = new Class1();
            Assert.AreEqual(2, pair.(a));
        }
        [TestMethod]
        public void TestMethod2()
        {
            int[] a = { 1, 2, 1, 3, 2, 4, 5 };
            Class1 pair = new Class1();
            Assert.AreEqual(2, pair.Pair(a));
        }
        [TestMethod]
        public void TestMethod()
        {
            int[] a = { 1, 2, 1, 3, 2, 4, 5,3 };
            Class1 pair = new Class1();
            Assert.AreEqual(3, pair.Pair(a));
        }
        [TestMethod]
        public void TestMethod1()
        {
            int[] a = { 1, 2, 1, 3, 2, 4, 5, 4, 5 };
            Class1 pair = new Class1();
            Assert.AreEqual(4, pair.Pair(a));
        }
    }
}
