using System;

namespace tentativas
{
    class Program
    {
        static void Main(string[] args)
        {
            Random NumberGenerator = new Random();

            int NumeroDeTentativas = 0;
            int Tentativas = 0;

            //or do{
            //    } while(condição);

            while (Tentativas != 6)
            {
                Tentativas = NumberGenerator.Next(1, 7);
                Console.WriteLine("Karen rolou: " + Tentativas + ".");
                NumeroDeTentativas++;
            }

            Console.WriteLine("Isso levou Karen à " + NumeroDeTentativas + " tentativa(s) rolada(s) para o número 6.");
            Console.ReadKey();
        }
    }
}
