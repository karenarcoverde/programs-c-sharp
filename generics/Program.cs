using System;

namespace generics
{
    class Program
    {
        public static void Main(string[] args)
        {
            ChaveValorPar<string, int> meaning = new ChaveValorPar<string, int>("Vida", 42);
            Console.ReadKey();
            meaning.Print();

        }
    }

    class ChaveValorPar <TChave, TValor>
    {
        public TChave chave;
        public TValor valor;

        public ChaveValorPar (TChave _chave, TValor _valor)
        {
            chave = _chave;
            valor = _valor;
        }

        public void Print()
        {
            Console.WriteLine("Chave: " + chave.ToString());
            Console.WriteLine("Valor: " + valor.ToString());
        }

    }
}
