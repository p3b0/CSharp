﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessNumberLib;

namespace GuessNumberTestLib
{
    [TestClass]
    public class GuessNumberTest
    {
        [TestMethod]
        public void NewGameReturnCorrectFeedback()
        {
            var sut = new GuessNumber();
            Assert.AreEqual("Guess a number between 1 and 100.", sut.Feedback);

        }

        [TestMethod]
        public void CorrectlyGuess42InThreeTries()
        {
            var sut = new GuessNumber();
            sut.Guess(10);
            Assert.AreEqual("Guess higher.", sut.Feedback);
            sut.Guess(55);
            Assert.AreEqual("Guess lower.", sut.Feedback);
            sut.Guess(42);
            Assert.AreEqual($"You made it in {sut.Tries} tries.", sut.Feedback);

        }
    }
}
