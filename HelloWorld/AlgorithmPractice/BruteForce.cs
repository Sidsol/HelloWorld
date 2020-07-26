using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.AlgorithmPractice
{
    public class BruteForce
    {
        public static bool IsFirstCharRepeated(string searchString)
        {
            
            foreach (var character in searchString.Substring(1))
            {
                if (character == searchString[0])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
