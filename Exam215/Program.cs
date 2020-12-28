using System;
using System.Collections.Generic;

namespace Exam215
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AutoAbs> Cars = new List<AutoAbs>();
            Cars.Add(new AutoNew("Ford Focus RS", 210));
            Cars.Add(new AutoOld("Audi", 350000, 120));
            Cars.Add(new AutoNew("Lada Largus", 10));
            Cars.Add(new AutoOld("Nissan Skyline 94", 125000, 300));
            double a = int.Parse(Console.ReadLine());
            foreach (var item in Cars)
            {
                AutoAbs car = Cars.Find(item => item.Price == a);
                Console.WriteLine($"Price: {item.Price}, Name: {item.Name}" );
            }
        }
    }
}
