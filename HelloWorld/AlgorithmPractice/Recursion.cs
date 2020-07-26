using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorld.AlgorithmPractice
{
    public class Recursion
    {
        public static string ReverseString(string toBeReversed)
        {
            var charArray = new char[toBeReversed.Length];
            int position = 0;
            for (int i = toBeReversed.Length - 1; i >= 0; i--)
            {
                charArray[position++] = toBeReversed[i];
            }
            Console.WriteLine(new string(charArray));
            return new string(charArray);
        }

        public static string ReverseStringRecursive(string toBeReversed)
        {
            if (string.IsNullOrEmpty(toBeReversed))
            {
                return toBeReversed;
            }

            return ReverseStringRecursive(toBeReversed.Substring(1)) + toBeReversed[0];
        }

        public static int GetSumBetweenNumbers(int min, int max)
        {
            if (min > max)
            {
                return 0;
            }

            int sumBetweenNumbers = 0;
            for (int i = min; i <= max; i++)
            {
                sumBetweenNumbers += i;
            }

            return sumBetweenNumbers;
        }
        public static void GetSumBetweenNumbersRecursive(int min, int max)
        {
            if (min > max)
            {
                return;
            }

            return sumBetweenNumbers;
        }

        public static int XToThePowerOfY(int x, int y)
        {
            return 0;
        }

    }
}
