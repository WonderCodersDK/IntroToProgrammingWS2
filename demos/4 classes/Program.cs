using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address("Weidekampsgade 8", 2300, "København");

            address.SetCoordinates(55.667536, 12.583309);
            
            Console.WriteLine(address.PrintCoordinates());
            Console.WriteLine(address.PrintAddress());
            Console.WriteLine(address.PrintAddress() + " " + address.PrintCoordinates());
        }
    }
}