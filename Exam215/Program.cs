using System;

namespace Exam215
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] mus = new int[10, 10]; 
            int a = 0;
            Console.WriteLine("Введите число");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            { 
                for (int j = 0; j < 10; j++) 
                {
                    mus[i, j] = rnd.Next(1, 10); 
                    Console.Write(mus[i, j] + " ");
                    if (mus[i,j] == b)
                    {
                        a += 1;
                    }
                }
                if (a>=0)
                {
                    Console.Write($"Кол-во заданного числа в строке {a}");
                }
                a = 0;
                Console.WriteLine();
            }
        }
    }
}
