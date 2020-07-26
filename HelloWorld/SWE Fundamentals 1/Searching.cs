using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class Searching
    {
        public static void FindCharInString(string sentenceToSearch, char searchCharacter)
        {
            if (sentenceToSearch.ToLower().Contains(searchCharacter) == true)
            {
                Console.WriteLine($"True the character \"{searchCharacter}\" is in the phrase above.");
                Console.WriteLine($"the first occurence of \"{searchCharacter}\" is at index {sentenceToSearch.ToLower().IndexOf(searchCharacter)}");
            }
            else
            {
                Console.WriteLine($"False the character \"{searchCharacter}\" is not in the phrase above.");
            }
        }

        public static void FindFileName(string fullPath)
        {
            int indexOfFinalFowardSlash = fullPath.LastIndexOf(@"\");
            int indexOfFinalPeriod = fullPath.LastIndexOf('.');

            Console.WriteLine($"\nThe file name in the path: {fullPath}"
                              + $" is {fullPath.Substring(indexOfFinalFowardSlash + 1, fullPath.Length - indexOfFinalPeriod - 1)}");
        }
        public static void FindDriveLetter(string fullPath)
        {
            Console.WriteLine($"The Drive for the path: {fullPath} "
                              + $" is {fullPath.Substring(0, 1).ToUpper()}");
        }
        //public static int Contains
    }
}
