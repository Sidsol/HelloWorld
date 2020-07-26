using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class ForLoops
    {
        public static void ForLoopsPractice()
        {
            string s = "0123456789";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] % 2 != 0)
                {
                    Console.Write(s[i]);
                }
            }
        }
    }
}
