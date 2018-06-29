using System;
using System.Collections.Generic;

namespace Converter.Models
{
    public class TextNumber
    {
        private int _number;
        private int _lastDigit;
        private int _placeValuePosition = 3;
        private int _periodModifier = 0;
        private Dictionary<int, string> _onesDictionary = new Dictionary<int, string>() { };
        private Dictionary<int, string> _teensDictionary = new Dictionary<int, string>() { };
        private Dictionary<int, string> _tensDictionary = new Dictionary<int, string>() { };
        private Dictionary<int, string> _hundredsDictionary = new Dictionary<int, string>() { };
        private Dictionary<int, string> _modifierDictionary = new Dictionary<int, string>() { };
        private List<Dictionary<int, string>> _dictionaryList = new List<Dictionary<int, string>>() { };

        public void SetNumber(string number)
        {
            _number = int.Parse(number);
        }

        public int GetNumber()
        {
            return _number;
        }

        public void CreateOnesDictionary()
        {
            _onesDictionary[1] = "one";
            _onesDictionary[2] = "two";
            _onesDictionary[3] = "three";
            _onesDictionary[4] = "four";
            _onesDictionary[5] = "five";
            _onesDictionary[6] = "six";
            _onesDictionary[7] = "seven";
            _onesDictionary[8] = "eight";
            _onesDictionary[9] = "nine";
        }

        public string GetOnesValue(int number)
        {
            return _onesDictionary[number];
        }

        public Dictionary<int, string> GetOnesDictionary()
        {
            return _onesDictionary;
        }

        public void CreateTeensDictionary()
        {
            _teensDictionary[1] = "eleven";
            _teensDictionary[2] = "twelve";
            _teensDictionary[3] = "thirteen";
            _teensDictionary[4] = "fourteen";
            _teensDictionary[5] = "fifteen";
            _teensDictionary[6] = "sixteen";
            _teensDictionary[7] = "seventeen";
            _teensDictionary[8] = "eighteen";
            _teensDictionary[9] = "nineteen";
        }

        public string GetTeensValue(int number)
        {
            return _teensDictionary[number];
        }

        public void CreateTensDictionary()
        {
            _tensDictionary[1] = "ten";
            _tensDictionary[2] = "twenty";
            _tensDictionary[3] = "thirty";
            _tensDictionary[4] = "forty";
            _tensDictionary[5] = "fifty";
            _tensDictionary[6] = "sixty";
            _tensDictionary[7] = "seventy";
            _tensDictionary[8] = "eighty";
            _tensDictionary[9] = "ninety";
        }

        public Dictionary<int, string> GetTensDictionary()
        {
            return _tensDictionary;
        }

        public string GetTensValue(int number)
        {
            return _tensDictionary[number];
        }

        public void CreateHundredsDictionary()
        {
            _hundredsDictionary[1] = "one hundred";
            _hundredsDictionary[2] = "two hundred";
            _hundredsDictionary[3] = "three hundred";
            _hundredsDictionary[4] = "four hundred";
            _hundredsDictionary[5] = "five hundred";
            _hundredsDictionary[6] = "six hundred";
            _hundredsDictionary[7] = "seven hundred";
            _hundredsDictionary[8] = "eight hundred";
            _hundredsDictionary[9] = "nine hundred";
        }

        public Dictionary<int, string> GetHundredsDictionary()
        {
            return _hundredsDictionary;
        }

        public string GetHundredsValue(int number)
        {
            return _hundredsDictionary[number];
        }

        public void CreateAllDictionaries()
        {
            this.CreateOnesDictionary();
            this.CreateTeensDictionary();
            this.CreateTensDictionary();
            this.CreateHundredsDictionary();
        }

        public void AddDictionariesToList()
        {
            this.CreateAllDictionaries();
            _dictionaryList.Add(_onesDictionary);
            _dictionaryList.Add(_tensDictionary);
            _dictionaryList.Add(_hundredsDictionary);
        }

        public List<Dictionary<int, string>> GetDictionaryList()
        {
            return _dictionaryList;
        }

        public int GetLastDigit()
        {
            _lastDigit = _number % 10;
            return _lastDigit;
        }

        public int RemoveLastDigit()
        {
            return _number /= 10;
        }

        // public string GetNumberText()
        // {
        //     this.GetLastDigit();
        //
        // }
    }
}
