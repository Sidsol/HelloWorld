using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class LoopFlowControl
    {
        public static void LoopFlowControlPractice()
        {
            string s = "This is a test string".ToLower();
            
            for (int i = 1; i < s.Length; i++)
            {
                if (!s[0].Equals(s[i]))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"{s[0]} was found at index {i}");
                    break;
                }
            }

        }
    }
}
