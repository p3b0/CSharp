using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeLib;

namespace PracticeTestLib
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestFile()
        {
            var sut = new FileHandler();
            var actual = "Mattias Asplund;1971-04-05;070-6186120";
            sut.Name = "Mattias Asplund";
            sut.Birthday = "1971-04-05";
            sut.Number = "070-6186120";
            Assert.AreEqual(actual, sut.WriteFile());

        }
    }
}
