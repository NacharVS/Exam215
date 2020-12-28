using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class Matrix
    {
        public static void Run()
        {
            int[,] matrix = new int[10,10];
            Random rnd = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 10);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            int proz = 1;
            for (int i = 0; i < 10; i++)
            {
                sum += matrix[i, i];
                proz *= matrix[i, i];
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов главной диагонгали = {sum}");
            Console.WriteLine($"Произведение элементов главной диагонгали = {Math.Abs(proz)}");
        }
    }
}
