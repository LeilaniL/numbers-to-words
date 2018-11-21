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
             Dictionary<int, string> tensPlace = new Dictionary<int, string>
        {
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fifteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"},
            };

        public NumberToWordConverter (int userInput)
        {
            UserInput = userInput;
        }
        public string NumberConverter(int lookupNumber)
            {
                if(lookupNumber<10)
                {
                return (singleNumbers[lookupNumber]);
                } else
                {
                    return (tensPlace[lookupNumber]);
                }
            }
    }
}