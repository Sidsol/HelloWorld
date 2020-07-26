using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class DoWhileLoops
    {
        public static void DoWhileLoopsPractice()
        {
            string s = "0123456789";

            do
            {
                if (s[0] % 2 != 0)
                {
                    Console.Write(s[0]);
                }
                s = s.Substring(1);
            } while (s.Length >= 1);
        }
    }
}
