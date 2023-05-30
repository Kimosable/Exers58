// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

class Program
{
    static void Main(string[] args)
    {
        int[,] matrix1 = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        int[,] matrix2 = new int[,]
        {
            {9, 8, 7},
            {6, 5, 4},
            {3, 2, 1}
        };

        Console.WriteLine("Первая матрица:");
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix1[i, j]);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Вторая матрица:");
        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                Console.Write("{0,4}", matrix2[i, j]);
            }
            Console.WriteLine();
        }

        int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;

                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                result[i, j] = sum;
            }
        }

        Console.WriteLine("Результат умножения матриц:");
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                Console.Write("{0,4}", result[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}