using System;

namespace animal
{
    class Animal
    {
        public static int Count = 0;

        public string nome = "Spotty";
        public int idade = 6;
        public float felicidade = 0.5f; 

        public void Print()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("felicidade: " + felicidade);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Animal cachorro = new Animal();
            Console.WriteLine(cachorro.nome);
            cachorro.nome = "Tom";
            Console.WriteLine(cachorro.nome);

            cachorro.Print();

            Animal.Count += 2;
            Animal gato = new Animal();
            Console.WriteLine(Animal.Count);

            Console.ReadKey();
        }
    }
}
