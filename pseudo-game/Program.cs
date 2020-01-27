using System;

namespace pseudo_game
{
    class Program
    {
        class Jogador
        {
            public int saude = 100;
            
            public void dano (int _dno)
            {
                saude -= _dno;
            }

        }
        static void Main(string[] args)
        {
            Jogador Karen = new Jogador();
            Console.WriteLine(Karen.saude);
            Karen.saude = 40;
            Console.WriteLine(Karen.saude);

            Karen.dano(50);
            Console.WriteLine(Karen.saude);

            Console.ReadKey();

        }
    }
}
