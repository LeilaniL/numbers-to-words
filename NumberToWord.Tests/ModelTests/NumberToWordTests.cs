using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToWord;
using System.Collections.Generic;
using System;
using System.Linq;

namespace NumberToWord.Tests
{

    [TestClass]
    public class NumberToWordTest{
    
        [TestMethod]
        public void NumberToWordConverter_LookupSingleDigit_String()
        {
            NumberToWordConverter newLookup = new NumberToWordConverter (2);
            Assert.AreEqual("two", (newLookup.NumberConverter(newLookup.UserInput)));
        }
        [TestMethod]
        public void NumberToWordConverter_LookupTeens_String()
        {
            NumberToWordConverter newLookup = new NumberToWordConverter (12);
            Assert.AreEqual("twelve", (newLookup.NumberConverter(newLookup.UserInput)));
        }
        [TestMethod]
        public void NumberToWordConverter_LookupDoubleDigit_String()
        {
            NumberToWordConverter newLookup = new NumberToWordConverter (74);
            Assert.AreEqual("seventy four", (newLookup.NumberConverter(newLookup.UserInput)));
        }
    }
}