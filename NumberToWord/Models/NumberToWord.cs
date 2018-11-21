using System;
using System.Collections.Generic;

namespace NumberToWord
{
  public class NumberToWordConverter
    {
        public string UserInput;
        Dictionary<string, int> singleNumbers = new Dictionary<string, int>
        {
            {"zero", 0},
            {"one", 1},
            {"two", 2},
            {"three", 3},
            {"four", 4},
            {"five", 5},
            {"six", 6},
            {"seven", 7},
            {"eight", 8},
            {"nine", 9},
            };

        public NumberToWordConverter (string userInput)
        {
            UserInput = userInput;
        }
        public int NumberConverter(string lookupNumber)
            {
                return (singleNumbers[lookupNumber]);
            }
    }
}