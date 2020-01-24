using System;

namespace animal2
{
    class Animal
    {
        // CLASS VARIABLES
        public static int Contador = 0;

        public string nome;
        public int idade;
        public float felicidade;

        // CLASS CONSTRUCTORS
        public Animal ()
        {
            nome = "Spotty";
            idade = 6;
            felicidade = 0.5f;

            Contador++;
        }

        public Animal (string _nome, int _idade, float _felicidade)
        {
            nome = _nome;
            idade = _idade;
            felicidade = _felicidade;

            Contador++;
        }
        // CLASS METHODS
        public void Print ()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Felicidade: " + felicidade);
        }

    }
    class Program
    {
        public static void Main(string[] args)
        {
            Animal cachorro = new Animal();
           cachorro.Print();

            Console.WriteLine();

            Animal gato = new Animal("Tomzinho",10, 0.8f);
            gato.Print();

            Console.WriteLine();

            Console.WriteLine("Numero de animais:" + Animal.Contador);

           Console.ReadKey();
        }
    }
}
