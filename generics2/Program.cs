using System;
using System.Collections.Generic;

namespace generics2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> precos = new Dictionary<string, int>(5);
            precos.Add("Melancia", 5);
            precos.Add("Carro", 100000);
            Console.WriteLine(precos["Melancia"]);

            Console.ReadKey();
        }
    }
}
