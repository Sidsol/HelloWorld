using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public class ReferenceParameters
    {
        public static char ReturnSelectedIndex(string originalString, ref int index)
        {
            if (index < 0)
            {
                index = 0;
            }
            else if (index > originalString.Length)
            {
                index = originalString.Length - 1;
            }

            return originalString[index];

        }

    }
}
