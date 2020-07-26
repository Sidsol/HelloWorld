using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class SingleDimensionalArrays
    {
        public static void SingleDimensionalArraysPractice()
        {
            int[] testArray = new int[10];

            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = i + 1;
            }

            PrintContentsOfArrayBackwards(testArray);
            SumsTheContentsOfArray(testArray);
            PrintTheContentsOfArrayWithOurLoops(testArray);

        }
        public static void PrintContentsOfArrayBackwards(int [] arrayToPrint)
        {
            for (int i = arrayToPrint.Length - 1; i >= 0; i--)
            {
                Console.Write(arrayToPrint[i] + ", ");
            }
        }

        public static void SumsTheContentsOfArray(int [] arrayToSum)
        {
            int sumOfArray = 0; 
            foreach (var integerToSum in arrayToSum)
            {
                sumOfArray += integerToSum;
            }

            Console.WriteLine($"\nThe sum of the integers in the passed array is: {sumOfArray}");
        }

        public static void PrintTheContentsOfArrayWithOurLoops(int[] arrayToPrint)
        {
            var arrayContents = string.Join(", ", arrayToPrint);

            Console.WriteLine(arrayContents);
        }

    }
}
