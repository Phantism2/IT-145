using System;

namespace BYValByRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            int n2 = 4;

            Console.WriteLine("Original values:");
            Console.WriteLine("n1 = " + n1);
            Console.WriteLine("n2 = " + n2);

            Console.WriteLine("\n--- Pass By Value ---");
            PassByValue.AddNumbers(n1, n2);

            Console.WriteLine("After PassByValue method:");
            Console.WriteLine("n1 = " + n1);
            Console.WriteLine("n2 = " + n2);

            Console.WriteLine("\n--- Pass By Reference ---");
            PassByReference.ChangeNumber(ref n1);

            Console.WriteLine("After PassByReference method:");
            Console.WriteLine("n1 = " + n1);

            Console.ReadLine();
        }
    }
}