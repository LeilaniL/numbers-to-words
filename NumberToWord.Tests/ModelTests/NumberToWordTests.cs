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
        public void NumberToWordConverter_LookupDictionaryValue_Int()
        {
            NumberToWordConverter newLookup = new NumberToWordConverter (2);
            Assert.AreEqual("two", (newLookup.NumberConverter(newLookup.UserInput)));
        }
    }
}