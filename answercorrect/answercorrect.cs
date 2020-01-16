using System;

namespace answercorrect
{
    class answercorrect
    {
        static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            int num01 = numberGenerator.Next(1, 15);
            int num02 = numberGenerator.Next(1, 15);

            Console.WriteLine("Quanto é " + num01 + " vezes " + num02 + "?");

            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == num01 * num02)
            {
                int respostaIndice = numberGenerator.Next(1, 4);

                switch (respostaIndice)
                {
                    case 1:
                        Console.WriteLine ("Correto. Muito bem!");
                        break;
                    case 2:
                        Console.WriteLine("A resposta está correta.");
                        break;
                    default:
                        Console.WriteLine("Você já tinha praticado?");
                        break;
                }

            }

            else
            {
                int diferença = Math.Abs(resposta - (num01 * num02)); // pega o valor absoluto da diferença

                if (diferença == 1)
                {
                    Console.WriteLine("Bem perto do resultado!");
                }

                else if (diferença <= 10)
                {
                    Console.WriteLine("Você pode fazer melhor do que isso");
                }

                else
                {
                    Console.WriteLine("Você está bem longe do resultado");
                }
            }

            Console.ReadKey();
        }
    }
}
