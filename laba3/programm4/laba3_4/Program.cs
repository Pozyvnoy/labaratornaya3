using System;

namespace laba3_4
{
    class Program
    {
        public static int[,] Plus(int[,] matrix1, int[,] matrix2)
        {
            int[,] ansver = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ansver[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return ansver;
        }
        public static int[,] Mines(int[,] matrix1, int[,] matrix2)
        {
            int[,] ansver = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    ansver[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return ansver;
        }
        public static double[] Average(int[,] matrix1, int[,] matrix2)
        {
            double[] ansver = new double[2];
            double x = 0;
            double y = 0;
            double z, k;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    x += matrix1[i, j];
                }
            }
            z = x / 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    y += matrix2[i, j];
                }
            }
            k = y / 9;
            ansver[0] = z; ansver[1] = k;
            return ansver;
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] matrix1 = new int[3, 3];
            int[,] matrix2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrix1[i, j] = rand.Next(1, 10);
                    matrix2[i, j] = rand.Next(1, 10);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix2[i, j] + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("+, -, Average");
            double[] forAverage = new double[2];
            int[,] ansver = new int[3, 3];
            bool YesOrNot = false;
            switch (Console.ReadLine())
            {
                case "+":
                    ansver = Plus(matrix1, matrix2);
                    YesOrNot = true;
                    break;
                case "-":
                    ansver = Mines(matrix1, matrix2);
                    YesOrNot = true;
                    break;
                case "Average":
                    forAverage = Average(matrix1, matrix2);
                    YesOrNot = false;
                    break;
            }
            if (YesOrNot == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine();
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(ansver[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Среднее значение первого массива: " + forAverage[0]);
                Console.WriteLine("Среднее значение втрого массива: " + forAverage[1]);
            }
        }
    }
}