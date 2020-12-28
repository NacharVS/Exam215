using System;

namespace Exam215
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5];
            Random rnd = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = rnd.Next(1, 5);
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();
            Class2.ab( array1);
        }
    }
}
