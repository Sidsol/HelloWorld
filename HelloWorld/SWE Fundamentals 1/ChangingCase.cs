using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class ChangingCase
    {
        public static void PrintStringUpperAndLowerCase(string toChangeCase)
        {
            Console.WriteLine($"\nConvert: {toChangeCase} " +
                $"\nTo all lower case: {toChangeCase.ToLower()} " +
                $"\nTo all upper case: {toChangeCase.ToUpper()}");
        }
    }
}
