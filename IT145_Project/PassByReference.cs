using System;

namespace BYValByRef
{
    internal class PassByReference
    {
        public static void ChangeNumber(ref int n1)
        {
            Console.WriteLine("Inside PassByReference:");
            n1 = n1 + 5;
            Console.WriteLine("Updated n1 = " + n1);
        }
    }
}