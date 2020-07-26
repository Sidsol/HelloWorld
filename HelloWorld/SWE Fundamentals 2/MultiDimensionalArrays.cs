using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.SWE_Fundamentals_2
{
    public class MultiDimensionalArrays
    {
        public static void MultiDimensionalArraysPractice()
        {
            var my2DArray = new int[3, 3];

            for (int i = 0; i < my2DArray.GetLength(0); i++)
            {
                for (int j = 0; j < my2DArray.GetLength(1); j++)
                {
                    my2DArray[i, j] = (i + 1) * (j + 1);
                }
            }

            PrintMultiDemensionalArray(my2DArray);
        }

        private static void PrintMultiDemensionalArray(int[ , ] arrayToPrint)
        {
            foreach (var item in arrayToPrint)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
