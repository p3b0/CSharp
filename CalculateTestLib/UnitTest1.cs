using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Caculate;

namespace CalculateTestLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReadValue()
        {
            double[] setValues = { 12.50, 17.50 };
            var sut = new Calculations();
            var actual = sut.Calculate(setValues);
            Assert.AreEqual(actual,25);
        }
    }
}
