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
                    if (value <= 0)
                    {
                        _saude = 0;
                    }

                    else if (value >= 100)
                    {
                        _saude = 100;
                    }

                    else
                    {
                        _saude = value;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            Jogador Karen = new Jogador();
            Console.WriteLine(Karen.saude);
            Karen.saude -= 200;
            Console.WriteLine(Karen.saude);
            Karen.saude += 400;
            Console.WriteLine(Karen.saude);
            Karen.saude = 50;
            Console.WriteLine(Karen.saude);

            Console.ReadKey();
        }
    }
}
