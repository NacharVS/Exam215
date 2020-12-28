using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class main
    {
        public static void RunStrategy()
        {
            IAttack attack;
            Unit_voin_gigant voin_gigant = new Unit_voin_gigant("Гигант", 150, 10);
            Console.WriteLine($"Имя: {Unit_voin_gigant.Name}");
            Console.WriteLine($"XP: {Unit_voin_gigant.Xp}");
            attack = voin_gigant;
            attack.Attack();
            Console.WriteLine();
        }
    }
}
