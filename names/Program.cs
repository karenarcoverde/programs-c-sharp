using System;

namespace names
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[3]
            {
                "Karen", "Erick", "Lourdes"
            };


            foreach (string nome in nomes)
            {
                Console.Write(nome + ",");
            }

            Console.ReadKey();

        }
    }
}
