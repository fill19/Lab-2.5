using System;

namespace Lab_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int m = 8;
                int n = 6;
                if (m % 2 == 0 && n % 2 == 0)
                {
                    int[][] matrix = new int[m][];
                    for (int i = 0; i < m; i++)
                    {
                        matrix[i] = new int[n];
                        for (int j = 0; j < n; j++)
                        {
                            matrix[i][j] = j + 1;
                            Console.Write(matrix[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            if (i < m / 2 && j < n / 2)
                            {
                                int tmp = matrix[i][j];
                                matrix[i][j] = matrix[i + m / 2][j + n / 2];
                                matrix[i + m / 2][j + n / 2] = tmp;
                            }
                        }
                    }
                    Console.WriteLine();
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            Console.Write(matrix[i][j] + " ");
                        }
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}

