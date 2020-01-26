using System;

namespace enums
{
    class Program
    {
        enum Raça {Bulldog, Boxer, Chihuahua, Beagle};

        class Animal
        {
             public string nome;
             public int idade;
             public float felicidade;
        }

        class cachorro : Animal
        {
            public Raça raça;

            public cachorro (string _nome, int _idade, float _felicidade, Raça _raça)
            {
                nome = _nome;
                idade = _idade;
                felicidade = _felicidade;

                raça = _raça;
            }

            public void Print()
            {
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Felicidade: " + felicidade);
                Console.WriteLine("Raça: " + raça);
            }

         }
             static void Main(string[] args)
             {
                 cachorro Hulk = new cachorro("Hulk", 6, 0.7f, Raça.Chihuahua);
                 Hulk.Print();

                 Console.ReadKey();
             }
    }
}
