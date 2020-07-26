using HelloWorld.SWE_Fundamentals_2;
using System;
using System.Text;
using HelloWorld.AlgorithmPractice;

namespace HelloWorld
{
    public enum Directions
    {
        Up, Down, Left, Right
    }
    public enum MyEnum
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    public struct Car
    {
        public double Price;
        public string Owner;
        public string Make;
    }
    class Program
    {
        static int Main(string[] args)
        {
            #region SWE Fundamentals 1
            #region Program Arguments
            Directions directionArgument;
            bool booleanArgument;
            int integerArgument;

            if (args.Length == 0)
            {
                ArgumentsHelp();
            }
            else
            {
                foreach (var arg in args)
                {
                    if (arg == "/?")
                    {
                        ArgumentsHelp();
                        return 1;
                    }
                }

                var sbArguments = new StringBuilder();
                sbArguments.Append("\nThe arguemts passed to the program were: ");

                bool success = Enum.TryParse(args[0], true, out directionArgument);
                if (success)
                {
                    sbArguments.Append($"{directionArgument}, ");
                    success = bool.TryParse(args[1].ToLower(), out booleanArgument);
                    if (success)
                    {
                        sbArguments.Append($"{booleanArgument}, ");
                        success = int.TryParse(args[2], out integerArgument);
                        if (success)
                        {
                            sbArguments.Append($"{integerArgument}, ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nCould not properly identify the second passed value");
                        Console.WriteLine("Expected a True or False (Note: not case sensitive)");
                        return 1;
                    }
                }
                else
                {
                    Console.WriteLine("\nCould not properly identify the first passed value");
                    Console.WriteLine("Expected a Direction such as: Up, Down, Left, Right (Note: not case sensitive)");
                    return 1;
                }


                var argString = string.Join(", ", args);
                Console.WriteLine($"You entered {argString}");
            }
            #endregion

            #region HelloWorld
            Console.WriteLine("\nHello World!");
            #endregion

            #region Comments

            //This is a single line comment

            /*testing
              multin
              line
              commentes*/

            /// <summary>
            /// This is an XML documentation comment
            /// </summary>
            /// <param name="args"></param> 
            #endregion

            #region Variables
            bool thisIsABool = false;
            int thisIsAnInt = 1;
            double thisIsADouble = 2.0;
            char thisIsAChar = 'C';
            string thisIsAString = "This is a string, how about that!";

            var sb = new StringBuilder();
            sb.AppendLine("\nExample of C# Variable Types:");
            sb.AppendLine($"This is a bool: {thisIsABool}");
            sb.AppendLine($"This is an int: {thisIsAnInt}");
            sb.AppendLine($"This is an double: {thisIsADouble}");
            sb.AppendLine($"This is an char: {thisIsAChar}");
            sb.AppendLine($"This is an string: {thisIsAString}");

            Console.WriteLine(sb.ToString());
            #endregion

            #region Min / Max Values
            //maxInt produces an overflow exception error when incrementd by 1
            //var maxInt = int.MaxValue + 1;

            #endregion

            #region Implicit Types
            var thisIsAnImplicitBool = false;
            var thisIsAnImplicitInt = 1;
            var thisIsAnImplicitDouble = 2.0;
            var thisIsAnImplicitChar = 'C';
            var thisIsAnImplicitString = "This is a string";
            #endregion

            #region Operators

            #region Assignmnet and Increment/Decrement
            var x = 1;
            var y = 5;

            //x++ will assign the value of x to z1 then will increment x
            var z1 = x++;
            //++y will increment y then assign the new value to z2;
            var z2 = ++y;

            var sbIncrement = new StringBuilder();
            sbIncrement.AppendLine("Incrementing Values");
            sbIncrement.AppendLine($"Value of x: {x}");
            sbIncrement.AppendLine($"Value of y: {y}");
            sbIncrement.AppendLine($"Value of z1: {z1}");
            sbIncrement.AppendLine($"Value of z2: {z2}");

            Console.WriteLine(sbIncrement.ToString());

            #endregion

            #region Math
            var z = 10;

            var a = x + y * z;
            var b = z / y + x;
            var c = z - x + y;

            var isEven = z % 2 == 0 ? true : false;

            var isDivisibleByThree = y % 3 == 0 ? true : false;

            var roundToThreeDecimalUsingTruncate = Math.Truncate(x / (double)y);
            var roundToThreeDecimalUsingStringFormat = (x / (double)y).ToString("#.000");

            #endregion

            #endregion

            #region Type Conversions

            int xConversion, yConversion, zConversion;
            double aConversion, bConversion, cConversion;

            xConversion = 1;
            yConversion = 3;
            zConversion = 6;

            aConversion = 2.0;
            bConversion = 6.0;
            cConversion = 12.0;

            int placeHolder;

            var sbTypeConvbersion = new StringBuilder();
            sbTypeConvbersion.AppendLine("Type Conversions:");

            sbTypeConvbersion.AppendLine($"int x: {xConversion} double a: {aConversion.ToString("#.00")} ");
            placeHolder = xConversion;
            xConversion = (int)aConversion;
            aConversion = (double)placeHolder;
            sbTypeConvbersion.AppendLine($"conversion = int a: {xConversion} and double x: {aConversion.ToString("#.00")}");

            sbTypeConvbersion.AppendLine($"int y: {yConversion} double b: {bConversion.ToString("#.00")} ");
            placeHolder = yConversion;
            yConversion = (int)bConversion;
            bConversion = (double)placeHolder;
            sbTypeConvbersion.AppendLine($"conversion = int b: {yConversion} and double y: {bConversion.ToString("#.00")}");

            sbTypeConvbersion.AppendLine($"int z: {zConversion} double c: {cConversion.ToString("#.00")} ");
            placeHolder = xConversion;
            zConversion = (int)cConversion;
            cConversion = (double)placeHolder;
            sbTypeConvbersion.AppendLine($"conversion = int c: {zConversion} and double z: {cConversion.ToString("#.00")}");

            Console.WriteLine(sbTypeConvbersion.ToString());

            #endregion

            #region Strings

            #region Escape and literals
            Console.WriteLine("\nThis is a string with \ttabs and \nnewlines\n");
            Console.WriteLine(@"This is a string litteral esacpe sequences like \t (tab) and \n (new line) do not work ");
            #endregion

            #region Concatenation
            var firstString = "\nThis is the first part of my message";
            var secondString = "This is the second part of my message";

            Console.WriteLine(firstString + " " + secondString);
            #endregion

            #region String Legnth
            var testingStringLength = "\nThis string is how long I wonder?";

            Console.WriteLine($"{testingStringLength} Accoring to string.legth property = {testingStringLength.Length}");
            #endregion

            #region Indexing
            string stringWithOddNumberOfCharacters = "This string has an odd number of characters";

            Console.WriteLine(Indexing.findFirstMiddleLastCharacter(stringWithOddNumberOfCharacters));
            #endregion

            #region ChangingCase
            string toChangeCase = "Get it done!";

            ChangingCase.PrintStringUpperAndLowerCase(toChangeCase);
            #endregion

            #region GettingPartsOfStrings
            string getPartsOfThisString = "This will be my test string";
            Console.WriteLine("\nGetting parts of strings:");
            Console.WriteLine("\"" + getPartsOfThisString + "\"");
            Console.WriteLine("Using string.Substring property:" + getPartsOfThisString.Substring(1, getPartsOfThisString.Length - 2));
            Console.WriteLine("Using string.trim property:" + getPartsOfThisString.Trim(getPartsOfThisString[0]).Trim(getPartsOfThisString[getPartsOfThisString.Length - 1]));

            #endregion

            #region Searching
            string sentenceToSearch = "It was the best of time, it was the worst of times.";
            char searchCharacter = 'i';
            Console.WriteLine("\nSearching:");

            Console.WriteLine($"Is \"{searchCharacter}\" in \"{sentenceToSearch}\"");
            Searching.FindCharInString(sentenceToSearch, searchCharacter);

            string filePath = @"c:\foo\bar.txt";

            Searching.FindFileName(filePath);
            Searching.FindDriveLetter(filePath);
            #endregion

            #region Splitting
            string testingSplit = "This is a string with spaces";
            // splitting the string with .split will create an array of strings
            var splitString = testingSplit.Split(' ');
            #endregion

            #region Formatting

            Formatting.FormatStrings();
            #endregion

            #region PrintingAndParsing
            PrintingAndParsing.Parsing();
            #endregion

            #endregion

            #region Enums
            var testingEnums = MyEnum.Friday;
            Console.WriteLine("\nEnums:");
            Console.WriteLine($"The Name of the Variable: {testingEnums} and the value: {(int)testingEnums}");

            #endregion

            #region Structs
            var xStruct = new Car();
            var yStruct = new Car();

            xStruct.Make = "Hyundai";
            xStruct.Owner = "Jonah";
            xStruct.Price = 999.99;

            yStruct.Make = "Tesla";
            yStruct.Owner = "Bob";
            yStruct.Price = 35000.00;

            Console.WriteLine("\nStructs:");
            Console.WriteLine($"Struct x: "
                              + $"\nOwner: {xStruct.Owner}"
                              + $"\nMake: {xStruct.Make}"
                              + $"\nPrice: {xStruct.Price}");

            Console.WriteLine($"\nStruct y: "
                              + $"\nOwner: {yStruct.Owner}"
                              + $"\nMake: {yStruct.Make}"
                              + $"\nPrice: {yStruct.Price}");

            xStruct.Make = yStruct.Make;
            xStruct.Owner = yStruct.Owner;
            xStruct.Price = yStruct.Price;

            Console.WriteLine($"\nStruct x after copying values from Struct y: "
                  + $"\nOwner: {xStruct.Owner}"
                  + $"\nMake: {xStruct.Make}"
                  + $"\nPrice: {xStruct.Price}");
            #endregion

            #region Console I/O
            ConsoleIO.EnterUserName();
            #endregion

            #region Command Line Arguments

            #endregion
            #endregion

            #region SWE Fundamental 2
            #region Conditionals

            Console.WriteLine("\nConditionals: ");

            #region If / Else
            Console.WriteLine("\nIf / Else: ");

            //Console.WriteLine("What value of x would you like to test");
            //var valueToCheck = Console.ReadLine();
            //int check;
            //var success = int.TryParse(valueToCheck, out check);

            //if (success)
            //{
            //    Conditionals.Conditions(check);
            //}

            IfElse.Conditions();

            #endregion

            #region Switch
            Console.WriteLine("\nPracticing with switch statements:");
            string season = "Winter";
            Console.Write($"{season} ");
            PracticingSwith.choosingThroughSwitch(season);
            #endregion

            #region Order Of Operations
            Console.WriteLine("\nOrder of Operations:");

            OrderOfOperations.Order();
            #endregion

            #region Nest Conditionals
            Console.WriteLine("\nNest Conditionals:");

            NestConditionals.NestCondiontionals();
            #endregion

            #endregion

            #region Loops
            Console.WriteLine("\nLoop:");

            #region While
            Console.WriteLine("\nWhile Loops:");

            WhileLoops.WhileLoopsPractice();
            #endregion

            #region Do While Loops
            Console.WriteLine("\n\nDo While Loops:");

            DoWhileLoops.DoWhileLoopsPractice();

            #endregion

            #region For Loops
            Console.WriteLine("\n\nFor Loops:");

            ForLoops.ForLoopsPractice();
            #endregion

            #region Foreach Loop
            Console.WriteLine("\n\nForeach Loops:");

            ForeachLoops.ForeachLoopsPractice();
            #endregion

            #region Nest Loops
            Console.WriteLine("\nNested Loops:");

            NestedLoops.NestedLoopsPractice();
            #endregion

            #region Loop Flow Contorl
            Console.WriteLine("\nLoop Flow Control:");

            LoopFlowControl.LoopFlowControlPractice();

            #endregion

            #endregion

            #region Arrays
            Console.WriteLine("\nArrays:");

            #region Single Dimensional Arrays
            Console.WriteLine("\nSingle Dimensional Arrays:");
            SingleDimensionalArrays.SingleDimensionalArraysPractice();
            #endregion

            #region Multi Dimensional Arrays
            Console.WriteLine("\nMulti Dimensional Arrays:");

            MultiDimensionalArrays.MultiDimensionalArraysPractice();
            #endregion
            #endregion

            #region Functions
            Console.WriteLine("\nFunctions:");

            #region Basic Functions
            Console.WriteLine("\nBasic Functions:");

            var basicString1 = "This will ";
            var basicString2 = "print when passed ";
            var basicString3 = "to my basic function";

            var arrayToModify = new int[5] { 1, 2, 3, 4, 5 };
            var indexToModify = 3;
            var valueToInsert = 10;

            var printingEveryOtherWord = "To be or not to be";

            BasicFunctions.PrintPassedString(basicString1);
            BasicFunctions.ConcatenateThreeStrings(basicString1, basicString2, basicString3);
            BasicFunctions.UpdateArray(arrayToModify, indexToModify, valueToInsert);
            BasicFunctions.PrintEveryOtherWord(printingEveryOtherWord);
            Console.WriteLine();
            Console.WriteLine(BasicFunctions.CreateSubstring(basicString3, 4));
            #endregion

            #region Reference Type Equality
            Console.WriteLine("\nReference Type Equality:");

            var arrayOne = new int[5] { 1, 2, 3, 4, 5 };
            var arrayTwo = new int[5] { 1, 2, 3, 4, 7 };

            Console.WriteLine(ReferenceTypeEquality.AreArraysEqual(arrayOne, arrayTwo));

            #endregion


            #region Output Parameters
            Console.WriteLine("\nOutput Parameters:");

            int one = 21;
            int two = 7;
            int sum, difference, product, quotient;
            OutputParameters.mathOutput(one, two, out sum, out difference, out product, out quotient);

            Console.WriteLine($"The Sum of {one} and {two} =  {sum}");
            Console.WriteLine($"The Difference of {one} and {two} =  {difference}");
            Console.WriteLine($"The Product of {one} and {two} =  {product}");
            Console.WriteLine($"The Quotient of {one} and {two} =  {quotient}");
            #endregion

            #region Reference Parameters
            Console.WriteLine("\nReference Parameters:");

            int indexToFind = 3;
            string stringToSearch = "This is a sting operation, you are under arrest";
            Console.WriteLine(stringToSearch);
            Console.WriteLine($"Function will return the character at index location {indexToFind}");
            Console.WriteLine("The charater is: " + ReferenceParameters.ReturnSelectedIndex(stringToSearch, ref indexToFind));
            Console.WriteLine($"the value of the index has been changed to: {indexToFind}");

            #endregion

            #endregion
            #endregion

            #region File I/O

            #endregion

            #region Algorithms
            Algorithms.AlgorithmPractice();

            #endregion

            Console.ReadLine();
            return 1;
        }
        public static void ArgumentsHelp()
        {
            Console.WriteLine("Please enter a Direction, a true or false and an integer");
            Console.WriteLine("Example: Up, false, 1");
        }
    }
}
