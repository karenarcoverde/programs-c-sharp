using System;

namespace pseudo_game_2
{
    class Program
    {
        class Jogador
        {
            private int _saude = 100;

            public int saude
            {
                get
                {
                    return _saude;
                }
            }

            public void dano(int _dno)
            {
                _saude -= _dno;
            }
        }
        static void Main(string[] args)
        {
            Jogador Karen = new Jogador();
            Karen.dano(30);
            Console.WriteLine(Karen.saude);

            Console.ReadKey();
        }
    }
}
