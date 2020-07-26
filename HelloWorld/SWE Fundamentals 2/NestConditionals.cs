using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class NestConditionals
    {
        public static void NestCondiontionals()
        {
            string s = "This";
            if (s.Length < 5)
            {
                if (s.Length % 2 != 0)
                {
                    Console.WriteLine($"\"{s}\" matches the conditions");
                }
                else
                {
                    Console.WriteLine($"\"{s}\" does not match the conditions");
                }
            }
            else if (s.Length >= 10)
            {
                if (s.Length % 2 == 0)
                {
                    Console.WriteLine($"\"{s}\" matches the conditions");
                }
                else
                {
                    Console.WriteLine($"\"{s}\" does not match the conditions");
                }
            }
            else
            {
                Console.WriteLine($"\"{s}\" does not match the conditions");
            }
        }
    }
}
