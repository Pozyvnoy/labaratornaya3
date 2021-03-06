using System;

namespace laba3_9
{
     class Program
    {
        public static int[,] CreateMatrix(int size)
        {
            var random = new Random();
            var matrix = new int[size, size];
            for (int x = 0; x < size; ++x)
                for (int y = 0; y < size; ++y)
                    matrix[x, y] = random.Next(10);
            return matrix;
        }

        static void Print(int[,] matrix)
        {
            for (int y = 0; y < matrix.GetLength(1); ++y)
            {
                for (int x = 0; x < matrix.GetLength(0); ++x)
                    Console.Write("{0,2}", matrix[x, y]);
                Console.WriteLine();
            }
        }

        static void Transform(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int y = 0; y < size; ++y)
            {
                int count = (y <= size / 2) ? y : size / 2 - (y - size / 2);
                for (int x = 0; x <= count; ++x)
                    Swap(ref matrix[x, y], ref matrix[size - x - 1, y]);
            }
        }

        static void Swap(ref int a, ref int b)
        {
            var t = a;
            a = b;
            b = t;
        }

        static void Main(string[] args)
        {
            var matrix = CreateMatrix(9);
            Print(matrix);
            Console.WriteLine();
            Transform(matrix);
            Print(matrix);
        }
    }
}