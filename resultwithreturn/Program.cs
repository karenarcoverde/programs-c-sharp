using System;

namespace resultwithreturn
{
    class Program
    {
        public static void Main(string[] args)
        {
            int resultado = add(1, 8);
            if (resultado > 10)
            {
                Console.WriteLine("Resultado é maior que 10!");
            }

            else
            {
                Console.WriteLine("Resultado é menor ou igual a 10!");
            }

            Console.ReadKey();
        }

        public static int add (int num01, int num02)
        {
            return num01 + num02;
        }

    }
}
