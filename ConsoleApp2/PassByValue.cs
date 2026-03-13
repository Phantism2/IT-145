using System;

namespace BYValByRef
{
    internal class PassByValue
    {
        public static void AddNumbers(int n1, int n2)
        {
            int result = n1 + n2;

            Console.WriteLine("Inside PassByValue:");
            Console.WriteLine("result = " + result);

            n1 = 100;
            n2 = 200;

            Console.WriteLine("Changed inside method:");
            Console.WriteLine("n1 = " + n1);
            Console.WriteLine("n2 = " + n2);
        }
    }
}