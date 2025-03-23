using System;
using System.Collections.Generic;

namespace project
{
    class Program
    {
        static void Main()
        { // ООП

            Multiply(2, 3,5);

        }

        public static void Multiply(int x, int y)
        {
            int res = x * y;
            Console.WriteLine("Result: " + res);
        }
        public static void Multiply(int x, int y, int z)
        {
            int res = x * y * z;
            Console.WriteLine("Result: " + res);
        }

    }

}
