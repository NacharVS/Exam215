using System;
using System.Collections.Generic;
using System.Text;

namespace _215Labs2020.Zifarov.Delegates
{
    class Class1
    {

        public static void Sum(int[] array1)
        {

            int sum = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                sum = sum + array1[i];
            }
            Console.WriteLine($"sum {sum}");
        }
        public static void Mul(int[] array1)
        {
            int mul = 1;
            for (int i = 0; i < array1.Length; i++)
            {
                mul = mul * array1[i];
            }
            Console.WriteLine($"mul {mul}");
        }
        public static void Sorting(int[] array1)
        {
            Console.WriteLine("Сортировка");
            int buffer;
            for (int i = 0; i < array1.Length; i++)
            {


                for (int j = 0; j < array1.Length - 1; j++)
                {
                    if (array1[j] > array1[j + 1])
                    {
                        buffer = array1[j];
                        array1[j] = array1[j + 1];
                        array1[j + 1] = buffer;

                    }

                }

            }
            for (int i = 0; i < array1.Length; i++)
            {
                Array.Reverse(array1);
                Console.WriteLine(array1[i]);
            }
            Console.WriteLine();

        }
        
    }
}
