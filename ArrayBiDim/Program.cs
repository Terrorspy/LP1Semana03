using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas;
            int colunas;
            float somaMedias = 0;

            Console.WriteLine("Quais são as linhas do array?");
            linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas são as colunas do array?");
            colunas = int.Parse(Console.ReadLine());

            float[,] matrix = new float[linhas, colunas];

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j =  0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"Insira um número para a posição ({i}, {j}): ");
                    matrix[i, j] = float.Parse(Console.ReadLine());
                }
            }

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                float media = 0;
                for(int j =  0; j < matrix.GetLength(1); j++)
                {
                    media += matrix[i, j];
                }
                Console.WriteLine(media/colunas);
                somaMedias += media/colunas;
            }
            Console.WriteLine(somaMedias);
        }
    }
}