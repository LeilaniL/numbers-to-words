using System;
using System.Collections.Generic;

namespace NumberToWord
{
  public class NumberToWordConverter
    {
        public int UserInput;
        Dictionary<int, string> singleNumbers = new Dictionary<int, string>
        {
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            };
             Dictionary<string, int> tensPlace = new Dictionary<string, int>
        {
            {"ten", 10},
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

        public NumberToWordConverter (int userInput)
        {
            UserInput = userInput;
        }
        public string NumberConverter(int lookupNumber)
            {
                return (singleNumbers[lookupNumber]);
            }
    }
}