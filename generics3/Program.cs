using System;

namespace generics3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine (Utilitario.CompararValor (10,3));
            Console.WriteLine (Utilitario.CompararTipos("hello", "world"));

            Console.ReadKey();
        }

        class Utilitario
        {
            public static bool CompararValor<T01, T02>(T01 valor01, T02 valor02)
            {
                return valor01.Equals(valor02);
            }

            public static bool CompararTipos <T01,T02> (T01 tipo01, T02 tipo02)
            {
                return typeof(T01).Equals(typeof(T02));
            }
        }
    }
}
