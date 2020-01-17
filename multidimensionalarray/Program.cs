using System;

namespace multidimensionalarray
{
    class Program
    {
        static void Main(string[] args)
        { 
            CriarMatriz();
            Console.ReadKey();
        }

        static void CriarMatriz()
        {
            int linha = 5;
            int coluna = 5;

            int[,] matriz = new int[linha, coluna]; // or int [][] matriz = new int [linha,coluna];
            matriz[2, 3] = 3;

            for (int x = 0; x < linha; x++)
            {
                for (int y = 0; y < coluna; y++)
                {
                    Console.Write(matriz[x, y] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
