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

        [TestMethod]
        public void AddDictionariesToList_AddDictionariesToList_Dictionary()
        {
            TextNumber newTextNumber = new TextNumber();
            newTextNumber.AddDictionariesToList();
            Dictionary<int, string> newDictionary = newTextNumber.GetOnesDictionary();
            List<Dictionary<int, string>> newList = newTextNumber.GetDictionaryList();
            CollectionAssert.AreEqual(newDictionary, newList[0]);
        }

        [TestMethod]
        public void GetLastDigit_GetLastDigitOfNumber_Int()
        {
            TextNumber newTextNumber = new TextNumber();
            newTextNumber.SetNumber("15");
            Assert.AreEqual(5, newTextNumber.GetLastDigit());
        }

        [TestMethod]
        public void RemoveLastDigit_RemoveLastDigitOfNumber_Int()
        {
            TextNumber newTextNumber = new TextNumber();
            newTextNumber.SetNumber("15");
            Assert.AreEqual(1, newTextNumber.RemoveLastDigit());
        }

        [TestMethod]
        public void GetNumberText_GetTextOfLastDigitInNumber_String()
        {
            TextNumber newTextNumber = new TextNumber();
            newTextNumber.SetNumber("15");
            Assert.AreEqual("five", newTextNumber.GetNumberText());
        }

        [TestMethod]
        public void CycleThroughList_CyclesToZeroPosition_Int()
        {
            TextNumber newTextNumber = new TextNumber();
            newTextNumber.SetNumber("1111");
            Assert.AreEqual(0, newTextNumber.CycleValuePosition());
        }

        [TestMethod]
        public void CycleThroughList_CyclesToFirstPosition_Int()
        {
            TextNumber newTextNumber = new TextNumber();
            newTextNumber.SetNumber("11111");
            Assert.AreEqual(1, newTextNumber.CycleValuePosition());
        }

        [TestMethod]
        public void CycleThroughList_CyclesToSecondPosition_Int()
        {
            TextNumber newTextNumber = new TextNumber();
            newTextNumber.SetNumber("111111");
            Assert.AreEqual(2, newTextNumber.CycleValuePosition());
        }
    }
}
