using System;

namespace test_infinit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti m:");
            int m = int.Parse(Console.ReadLine());

            int[,] mat1 = ReadMatrix(n, m);
            ShowMatrix(mat1);

            int[,] mat2 = ReadMatrix(m, n);
            ShowMatrix(mat2);

            int[,] addResult = MultiplyMatrices(mat1, mat2);
            ShowMatrix(addResult);
        }

        static int[,] ReadMatrix(int n, int m)
        {
            Console.WriteLine("Introduceti matricea:");

            int[,] result = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    result[i, j] = int.Parse(Console.ReadLine());
                }
            }

            return result;
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int columns1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int columns2 = matrix2.GetLength(1);


            int[,] product = new int[rows1, columns2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < columns2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < columns1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    product[i, j] = sum;
                }
            }

            return product;
        }


        static void ShowMatrix(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
//Cititi de la tastatura continutul a doua matrici de intregi cu 2 dimensiuni avand lungimile n 
//m, respectiv m, n. Lungimile celor doua dimensiuni ale matricilor, m si n, vor fi citite de la 
//tastaura. Scrieti o functie care va calcula produsul celor doua matrici, apelati-o si afisati-I 
//rezultatul