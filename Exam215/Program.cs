using System;


namespace Exam215
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[10, 10];
            Random rnd = new Random();
            int k = 0;
            Console.WriteLine("введите число");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    array[i, j] = rnd.Next(0, 100);
                    Console.Write(array[i, j] + " ");
                    if (array[i, j] ==num)
                    {
                        k += 1;
                    }
                }
                if (k >= 0)
                {
                    Console.Write($"количество числа в строке {k}");
                }
                k = 0;
                Console.WriteLine();
            }
        }
    }
}
			
