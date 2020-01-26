using System;

namespace animal3herança
{
    class Program
    {
        class Animal
        {
            public string nome;
            public int idade;
            public float felicidade;

            public void PrintBase()
            {
                Console.WriteLine("Nome: " + nome);
                Console.WriteLine("Idade: " + idade);
                Console.WriteLine("Felicidade: " + felicidade);
            }
        }

        class cachorro : Animal
        {
            public int ContadorLocal;

            public void Latido ()
            {
                Console.WriteLine("Wuf!");
                base.felicidade += 0.1f;

            }
        }
        class gato : Animal
        {
            public float fofura;

            public void Miado()
            {
                Console.WriteLine("Meow!");
            }
        }

        static void Main(string[] args)
        {
            cachorro Spotty = new cachorro();
            Spotty.nome = "Spotty";
            Spotty.idade = 4;
            Spotty.felicidade = 0.8f;
            Spotty.ContadorLocal = 25;
            Spotty.PrintBase();
            Spotty.Latido();
            Console.WriteLine("Nova felicidade: " + Spotty.felicidade);

            Console.WriteLine();

            gato heisenberg = new gato();
            heisenberg.nome = "Heisenberg";
            heisenberg.idade = 13;
            heisenberg.felicidade = 0.3f;
            heisenberg.fofura = 0.4f;
            heisenberg.PrintBase();
            heisenberg.Miado();


            Console.ReadKey();
        }
    }
}
