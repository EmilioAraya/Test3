using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(Program.addNumber(2, 3), 5);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(Program.addNumber(2, 3), "five");
        }
    }
}
