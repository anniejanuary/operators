using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 14;
            int num2 = 7;
            int num3; //not defining this one yet

            //unary operators
            num3 = -num1; //assigning to num3 value of num1 * -1
            Console.WriteLine($"Num3 is {num3}");

            bool isSunny = true;
            Console.WriteLine($"Is it sunny? {!isSunny}");

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine($"Num is {num}");
            Console.WriteLine($"Num is {num++}");
            Console.WriteLine($"Num is {num}");

            Console.WriteLine("\n");

            Console.WriteLine($"Num is {num}");

            //pre increment operator technically
            Console.WriteLine($"Num is {++num}");
            Console.WriteLine($"Num is {num}");

            //decrement operator
            num--;

            Console.WriteLine($"Num is {num}");
            Console.WriteLine($"Num is {num--}");

            int result; //not assigning value yet bc ill be changing it along the way
            
            result = num1 + num2;
            Console.WriteLine($"Result of num1 + num2 is {result}");

            result = num1 - num2;
            Console.WriteLine($"Result of num1 - num2 is {result}");

            result = num1 * num2;
            Console.WriteLine($"Result of num1 * num2 is {result}");

            result = num1 / num2;
            Console.WriteLine($"Result of num1 / num2 is {result}");

            
           //modular operator
            result = num1 % num2;
            Console.WriteLine($"Result of num1 / num2 is {result}");

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine($"Is num1 lower than num2? {isLower}");

            //equality operator
            //bool isEqual;
            //isEqual = num1 == num2;
            //Console.WriteLine($"Is num1 = num2? {isEqual}");

            bool isEqual;
            isEqual = num1 != num2;
            Console.WriteLine($"Is num1 not equal to num2? {isEqual}");

            //conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny; // using 2 bools
            Console.WriteLine($"Is num1 < num2 and is it sunny? {isLowerAndSunny}");

            //or operator
            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine($"Is num1 < num2 OR is it sunny? {isLowerAndSunny}");

            Console.ReadKey();
        }
    }
}
