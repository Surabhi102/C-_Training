using class_Library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace mathtest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Class1 ad = new Class1();//class1 --> class Library
            Assert.AreEqual(11, ad.add(5,6)); // add-->method in Class1
        }
        [TestMethod]
        public void TestMethod2()
        {
            Class1 sub = new Class1();
            Assert.AreEqual(9, sub.add(9, 0));
        }
    }
}
