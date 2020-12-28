using System;

namespace Exam215
{
    class Charactiristiks
    {
        public static double xp1 = 100;
        public static int lovkost1;
        public static int udacha1;
        public static double xp2 = 100;
        public static int lovkost2;
        public static int udacha2;
    }
    class Exam215 : Charactiristiks
    {
        public static void Bitva()
        {
            Random rnd = new Random();
            lovkost1 = rnd.Next(1, 10);
            udacha1 = rnd.Next(1, 10);
            lovkost2 = rnd.Next(1, 10);
            udacha2 = rnd.Next(1, 10);
            Console.WriteLine("Игрок 1");
            Console.WriteLine($"XP: {xp1}");
            Console.WriteLine($"Ловкость: {lovkost1}");
            Console.WriteLine($"Удача: {udacha1}");
            Console.WriteLine();
            Console.WriteLine("Игрок 2");
            Console.WriteLine($"XP: {xp2}");
            Console.WriteLine($"Ловкость: {lovkost2}");
            Console.WriteLine($"Удача: {udacha2}");
            Console.WriteLine();
            double uron = 0;
            while (xp1 > 0 && xp2 > 0)
            {
                uron = rnd.Next(-10, 40);
                uron -= lovkost1;
                uron -= udacha1;
                if (uron <= 0)
                    uron = 0;
                xp1 -= uron;
                if (xp1 <= 0)
                    break;
                Console.WriteLine($"Игрок 2 нанес игроку 1 урон: {uron}");
                Console.WriteLine($"ХР игрока 1: {xp1}");
                Console.WriteLine($"ХР игрока 2: {xp2}");
                Console.WriteLine();
                uron = rnd.Next(-10, 40);
                uron -= lovkost2;
                uron -= udacha2;
                if (uron <= 0)
                    uron = 0;
                xp2 -= uron;
                if (xp2 <= 0)
                    break;
                Console.WriteLine($"Игрок 1 нанес игроку 2 урон: {uron}");
                Console.WriteLine($"ХР игрока 1: {xp1}");
                Console.WriteLine($"ХР игрока 2: {xp2}");
                Console.WriteLine();
            }
            if (xp1 <= 0)
            {
                Console.WriteLine("Победил игрок 2");
            }
            else
            {
                Console.WriteLine("Победил игрок 1");
            }
        }
    }
}