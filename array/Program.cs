using System;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers [0] = 12;
            numbers[1] = 3;
            numbers[2] = 5;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + ",");
            }
            Console.ReadKey();
        }
    }
}
