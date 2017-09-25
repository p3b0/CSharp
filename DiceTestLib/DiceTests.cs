using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dice;

namespace DiceTestLib
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void IsNumberSeven()
        {
            var sut = new Dices();
            Assert.AreEqual(7, sut.ThrowDice(2));
        }
    }
}
