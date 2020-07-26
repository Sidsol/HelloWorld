using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.SWE_Fundamentals_2
{
    public class BasicFunctions
    {
        public static void PrintPassedString(string printThisString)
        {
            Console.WriteLine(printThisString);
        }

        internal static void ConcatenateThreeStrings(string a, string b, string c)
        {
            Console.WriteLine(a + b + c);
        }

        internal static void UpdateArray(int[] arrayToModify, int indexToModify, int valueToInsert)
        {
            if (arrayToModify.Length > indexToModify)
            {
                arrayToModify[indexToModify] = valueToInsert;
            }
            Console.WriteLine(arrayToModify[indexToModify]);
        }

        internal static void PrintEveryOtherWord(string printingEveryOtherWord)
        {
            var splitString = printingEveryOtherWord.Split(" ");

            for (int i = 0; i < splitString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(splitString[i] + " ");
                }
            }
        }

        internal static string CreateSubstring(string origianlString, int index = 0, int length = 0)
        {
            if (index > origianlString.Length || length > origianlString.Length)
            {
                return "";
            }
            else
            {
                var sb = new StringBuilder();
                //var lengthOfNewString = length == 0 ? origianlString.Length : length;
                for (int i = index; i < (length == 0 ? origianlString.Length : length); i++)
                {
                    sb.Append(origianlString[i]);
                }

                return sb.ToString();
            }
        }

    }
}
