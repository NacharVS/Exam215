using System;

namespace Exam215
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] mass = new int[10, 10];
            
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                int max = 0;
                for (int j = 0; j < mass.GetLength(0); j++)
                {
                    mass[i, j] = rnd.Next(1, 99);
                    Console.Write($" {mass[i, j]}");
                    if (j == 0 || max < mass[i, j]) max = mass[i, j];
                    
                }
                Console.WriteLine();
                Console.WriteLine($" Максимальный элемент строки: {max}");

            }
        }
    }
}
