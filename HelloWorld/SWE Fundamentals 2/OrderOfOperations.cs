using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class OrderOfOperations
    {
        public static void Order()
        {
            string s = "This is very";
            if ((s.Length < 5 && s.Length % 2 != 0 ) || ( s.Length >= 10 && s.Length % 2 == 0))
            {
                Console.WriteLine($"\"{s}\" matches the conditions");
            }
            else
            {
                Console.WriteLine("\"{s}\" does not match the conditions");
            }
        }
    }
}
