using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class Unit_voin_gigant : unit_abstract, IAttack
    {
        public int Damage { get; private set; }
        public Unit_voin_gigant(string name, int xp, int damage)
        {
            Name = name;
            Xp = xp;
            Damage = damage;
        }
        public void Attack()
        {
            Console.WriteLine($"Атака Воина с уроном: {Damage} ед.");
        }
    }
}
