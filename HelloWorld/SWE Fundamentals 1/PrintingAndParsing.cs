using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    public static class PrintingAndParsing
    {
        public static void Parsing()
        {
            bool a = true;
            int b = 50;
            double c = 2.66908 ; 
            char d = 'o';

            string w = a.ToString();
            string x = b.ToString();
            string y = c.ToString();
            string z = d.ToString();

            bool e;
            int f;
            double g;
            char h;

            bool.TryParse(w, out e);
            int.TryParse(w, out f);
            double.TryParse(w, out g);
            char.TryParse(w, out h);

            Console.WriteLine($"\nValue of e: {e} of type {e.GetTypeCode()}"
                              + $"\nValue of f: {f} of type {f.GetTypeCode()}"
                              + $"\nValue of f: {g} of type {g.GetTypeCode()}"
                              + $"\nValue of f: {h} of type {h.GetTypeCode()}");


        }
    }
}
