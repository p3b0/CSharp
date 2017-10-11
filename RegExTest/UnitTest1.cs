using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RegExTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRegEx()
        {
            string pattern = @"(.+?"") (\d*) (\d*.{3}) (\d*-\d*)";
            string input = @"""Mattias Asplund"" 46 35000.00 070-6186120";

            
        }
    }
}
