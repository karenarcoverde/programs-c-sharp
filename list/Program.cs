using System;
using System.Collections.Generic; // para usar lista

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> ();

            numeros.Add(13);
            numeros.Add(4);
            numeros.Add(8);

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.WriteLine(numeros[i] + ",");
            }

            Console.WriteLine();
            numeros.RemoveAt(2);

            for (int i = 0; i < numeros.Count; i++)
            {
                Console.Write(numeros[i] + ",");
            }
            Console.ReadKey();
        }
    }
}
