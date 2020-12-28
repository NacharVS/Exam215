using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class borbar : unit, IDamage, IHealth, IArmor
    {
        public borbar()
        {
        }
        public borbar(int _damage, int _health, int _armor)
        {
            Damage = _damage;
            Health = _health;
            Armor = _armor;
        }
        void IArmor.Armor()
        {
            throw new NotImplementedException();
        }
        void IDamage.Damage()
        {
            throw new NotImplementedException();
        }
        void IHealth.Health()
        {
            throw new NotImplementedException();
        }

    }
}
