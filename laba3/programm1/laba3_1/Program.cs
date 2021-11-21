﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[n];
            Random r = new Random();
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(-35, 45);
            }
            Console.WriteLine("Вывод массива: ");
            for (int i = 0; i < mass.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(mass[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Разворот массива и вывод лишь положительных его элементов: ");
            for (int i = mass.Length - 1; i >= 0; i--)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                if (mass[i] >= 0)
                {
                    Console.Write(mass[i] + " ");
                }
            }

        }

    }
}