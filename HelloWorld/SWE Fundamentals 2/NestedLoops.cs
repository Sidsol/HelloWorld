using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class NestedLoops
    {
        public static void NestedLoopsPractice()
        {
            var hats = new List<int>() { 1, 5, 6, 7, 3 };
            
            foreach (var hat in hats)
            {
                Console.WriteLine("hats");
            }
        }
    }
}
