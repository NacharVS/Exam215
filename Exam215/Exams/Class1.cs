using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215.Exams
{
    class Class1
    {
        public void Main(string[] args)
        {
            int n = 10;
            int m = 10;
            int[,] mas = new int[n, m];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mas[i, j] = r.Next(0, 50);
                    Console.WriteLine(mas[i, j] + "");
                }
                Console.WriteLine();
                int max = mas[i, j];
                for (int j = 0; j < n; j++)
                {
                    if (mas[i, j] > max)
                    {
                        max = mas[i, j];
                    }
                }
                Console.WriteLine("max:{0},max");
            }
            Console.ReadKey();
        }
    }
}
