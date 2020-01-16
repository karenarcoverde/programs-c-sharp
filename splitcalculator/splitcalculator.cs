using System;

namespace splitcalculator
{
    class splitcalculator
    {
        static void Main(string[] args)
        {
        Start:
            double num01;
            double num02;

            Console.Write("Enter a number to be divided: ");
            num01 = Convert.ToDouble (Console.ReadLine());
            Console.Write("Enter a number to divide by: ");
            num02 = Convert.ToDouble (Console.ReadLine());

            Console.WriteLine(num01 + " divided by " + num02 + " is equal to " + num01 / num02);

            // Wait for the user to press a key. Then make empty space and start over.
            Console.ReadKey();
            Console.WriteLine();
            goto Start; // Jumps to "Start:".


        }
    }
}


