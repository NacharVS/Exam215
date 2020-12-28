using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class rudnic : unit,  IHealth, IArmor
    {
        public rudnic()
        {
        }

        public rudnic( int _health,  int _armor)
        {
            Health = _health;
            Armor = _armor;
        }
        void IHealth.Health()
        {
            throw new NotImplementedException();
        }
        void IArmor.Armor()
        {
            throw new NotImplementedException();
        }
    }
}
