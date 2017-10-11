using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using checkNumber;

namespace numberTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLastNumber()
        {
            var sut = new Check();
            sut.Calculate(770328055);
            Assert.AreEqual(7, sut.LastNumber);
        }
    }
}
