using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class ForeachLoops
    {
        public static void ForeachLoopsPractice()
        {
            string s = "0123456789";

            foreach (var item in s)
            {
                if (item % 2 != 0)
                {
                    Console.Write(item);
                }
            }
        }
    }
}
