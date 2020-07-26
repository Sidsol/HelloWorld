using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class Indexing
    {
        public static string findFirstMiddleLastCharacter(string stringToSearch)
        {
            char firstCharacter, middleCharacter, lastCharacter;

            firstCharacter = stringToSearch[0];

            middleCharacter = stringToSearch[(int)Math.Ceiling(stringToSearch.Length / (double)2)];

            lastCharacter = stringToSearch[stringToSearch.Length - 1];

            return $"\nThe first, middle, and last character of this string: {stringToSearch} " +
                "\nare the following: " + firstCharacter + middleCharacter + lastCharacter;
        }
    }
}
