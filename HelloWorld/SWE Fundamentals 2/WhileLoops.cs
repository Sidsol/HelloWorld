using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class WhileLoops
    {
        public static void WhileLoopsPractice()
        {
            //while (true)
            //{
            //    Console.WriteLine("This is an infinite loop.... lets not run it!! ^_^");
            //}
            string s = "0123456789";
            while (s.Length >= 1)
            {
                if (s[0]% 2 != 0)
                {
                    Console.Write(s[0]);
                }
                s = s.Substring(1);
            }
        }
    }
}
