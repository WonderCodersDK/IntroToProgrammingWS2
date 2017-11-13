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
        }

        public static void ConcatenateWithSpace(string str1, string str2)
        {
            var str3 = str1 + " " + str2 + " hello :)";
            
            Console.WriteLine(str3);
        }

        public static int Power(int number, int power, int divisor) 
        {
            var result = number;

            for (int i = power; i > 1; i = i - 1)
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
    }
}
