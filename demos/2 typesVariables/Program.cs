using System;

namespace typesVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            // integer
            int number1 = 1;
            //Console.WriteLine("Example of integer is " + number1);

            // double
            double number2 = 1.00;
            //Console.WriteLine("Example of double is " + number2);

            // string
            string text = "Hello World. We are prinbting more text";
            //Console.WriteLine("Our small program says " + text);

            // boolean
            bool def = false;
            //Console.WriteLine("A true statement is always " + def);

            // operations + - * /
            Console.WriteLine("2 + 2 = " + ("2"+(2+2)));
            Console.WriteLine("2 - 2 = " + (2-2));
            Console.WriteLine("2 * 2 = " + (2*2));
            Console.WriteLine("2 / 2 = " + (2/2));

            // concatenation of strings
            Console.WriteLine("Hello" + " " + "World" + "!");

            // boolean operations (&& || !)
            Console.WriteLine("True AND True = " + (true && true));
            Console.WriteLine("True AND False = " + (true && false));
            Console.WriteLine("True OR False = " + (true || false));
            Console.WriteLine("False OR False = " + (false || false));
            Console.WriteLine("NOT True = " + (!true));
        }
    }
}
