using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class OutputParameters
    {
        public static void mathOutput(int x, int y, out int sum, out int difference, out int product, out int quotient)
        {
            sum = x + y;
            difference = x - y;
            product = x * y;
            quotient = x / y;
        }
    }
}
