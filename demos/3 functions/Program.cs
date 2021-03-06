using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            // concatenate two strings
            //ConcatenateWithSpace("We just created 11", "a bookstore!!!");

            // Math.Pow
            //var power = Power(243, 5, 3);
            //Console.WriteLine(power);

            // check if number is bigger then another one
            var greaterThan = IsGreaterThan(5, 5);
            Console.WriteLine(greaterThan);

            // get the bigger number
            var greaterNumber = GetGreaterNumber(2, 4);
            Console.WriteLine($"Out of 2 and 4, {greaterNumber} is greater");
        }

        public static void ConcatenateWithSpace(string str1, string str2)
        {
            var str3 = str1 + " " + str2 + " hello :)";
            
            Console.WriteLine(str3);
        }

        public static int Power(int number, int power, int divisor) 
        {
            var result = 1;

            for (int i = 1; i <= power; i++)
            {
                Console.WriteLine(i + " " + result);
                result = result / divisor;
            }

            return result;
        }

        public static bool IsGreaterThan(int num1, int num2) 
        {
            // > >= < <= == != 
            return num1 > num2;
        }

        public static int GetGreaterNumber(int num1, int num2)
        {
            if (num1 > num2) {
                return num1;
            } else {
                return num2;
            }
        }
    }
}
