using System;

namespace add
{
    class Program
    {
        static void Main(string[] args)
        {
            add(10, 8);
            add(10, 8, 2);
            Console.ReadKey();
        }

        static void add(int num01, int num02)
        {
            Console.WriteLine(num01 + num02);
        }

        static void add (int num01, int num02, int num03)
        {
            Console.WriteLine(num01 + num02 + num03);
        }
    }
}
