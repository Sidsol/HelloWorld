using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class Formatting
    {
        public static void FormatStrings()
        {
            const string x= "\nHello my name is {0} and I like {1}";
            string y = string.Format(x, "Jonah", "Apples");
            
            Console.WriteLine(y);

            double d = 4.289078398;
            Console.WriteLine($"Using String formating I can convert {d} to {d.ToString("#.00")}");
        }
    }
}
