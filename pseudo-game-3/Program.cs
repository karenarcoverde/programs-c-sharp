using System;

namespace pseudo_game_3
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
                set
                {
                    _saude = value;
                }
            }
        }
        public static void Main(string[] args)
        {
            Jogador Karen = new Jogador();
            Console.WriteLine(Karen.saude);
            Karen.saude = 20;
            Console.WriteLine(Karen.saude);
            Console.ReadKey();
        }
    }
}
