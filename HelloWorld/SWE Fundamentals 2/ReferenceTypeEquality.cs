using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class ReferenceTypeEquality
    {
        public static bool AreArraysEqual(int[] arrayOne, int[] arrayTwo)
        {
            if (arrayOne.Length !=  arrayTwo.Length)
            {
                return false;
            }

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
