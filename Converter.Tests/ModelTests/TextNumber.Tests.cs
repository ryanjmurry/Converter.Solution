using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Converter.Models;

namespace Converter.Tests
{
    [TestClass]
    public class TextNumberTest
    {
        [TestMethod]
        public void SetGetNumber_SetsAndGetsNumber_Int()
        {
            TextNumber newTextNumber = new TextNumber();
            newTextNumber.SetNumber("1");
            Assert.AreEqual(1, newTextNumber.GetNumber());
        }

        [TestMethod]
        public void CreateAllDictionaries_CreateAllDictionaries_String()
        {
            TextNumber newTextNumber = new TextNumber();
            newTextNumber.CreateAllDictionaries();
            Assert.AreEqual("one", newTextNumber.GetOnesValue(1));
            Assert.AreEqual("eleven", newTextNumber.GetTeensValue(1));
            Assert.AreEqual("ten", newTextNumber.GetTensValue(1));
            Assert.AreEqual("one hundred", newTextNumber.GetHundredsValue(1));
        }
    }
}
