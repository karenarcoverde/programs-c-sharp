using System;

namespace numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int [5];
            numbers[0] = 12;
            numbers[1] = 3;
            numbers[2] = 5;

            foreach (int number in numbers)
            {
                Console.Write(number + ",");
            }

            Console.ReadKey();
        }
    }
}
