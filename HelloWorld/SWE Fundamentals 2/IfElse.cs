using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class IfElse
    {
        public static void Conditions()
        {
            int check = 1;
            if (check < 100)
            {
                Console.WriteLine("x is less than 100");
            }
            else if (check == 100)
            {
                Console.WriteLine("x is equal to 100");
            }
            else
            {
                Console.WriteLine("x is greater than 100");
            }
        }
    }
}
