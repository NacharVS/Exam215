using System;

namespace Exam215
{
    class Program:Class1
    {
        static void Main(string[] args)
        {
            Program[] array1 = new Program[3];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new Program();
            }
            array1[0].Marka = "Lada";
            array1[0].Nowy = "Da";
            array1[0].kolKolos = "4";
            array1[1].Marka = "Shkoda";
            array1[1].Ctary = "Da";
            array1[1].Probeg = "300000";
            array1[2].Marka = "Toyta";
            array1[2].Nowy = "Da";
            array1[2].kolKolos = "4";

            Console.WriteLine("Введите характеристики:Marka, Nowy, kolKolos");
            string vod = Console.ReadLine();

            switch (vod)
            {
                case Marka:
            }

        }
    }
}
