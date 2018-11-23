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
        Dictionary<int, string> teens = new Dictionary<int, string>
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
            {19, "nineteen"}
        };
        Dictionary<int, string> tensPlaceValues = new Dictionary<int, string>
        {
            {2, "twen"},
            {3, "thir"},
            {4, "four"},
            {5, "fif"},
            {6, "six"},
            {7, "seven"},
            {8, "eigh"},
            {9, "nine"},
        };

        public NumberToWordConverter(int userInput)
        {
            UserInput = userInput;
        }
        public string NumberConverter(string lookupNumber)
        {
            char[] stringArray = lookupNumber.ToCharArray();
            List<int> numberList = new List<int>();
            foreach (char number in stringArray)
            {
                int integer = (int)Char.GetNumericValue(number);
                numberList.Add(integer);
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            int userInput = int.Parse(Console.ReadLine());
            NumberToWordConverter newTest = new NumberToWordConverter(userInput);
            Console.WriteLine(newTest.NumberConverter(newTest.UserInput));
        }
    }
}