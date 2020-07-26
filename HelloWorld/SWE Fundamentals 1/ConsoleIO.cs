using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class ConsoleIO
    {
        public static void EnterUserName()
        {
            Console.WriteLine("\nConsole I/O:");
            Console.Write("Please enter you First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle Name: ");
            string middleName = Console.ReadLine();
            Console.Write("Finally your Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine($"Thank you for your cooperation, {firstName} {middleName} {lastName}!");
            Console.WriteLine("Press any key to exit...");

        }
    }
}
