using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class basni: unit,  IHealth,  IArmor
    {
        public basni()
        {
        }

        public basni( int _health, int _armor)
        {
            
            Health = _health;
            
            Armor = _armor;
        }
        void IArmor.Armor()
        {
            throw new NotImplementedException();
        }
        void IHealth.Health()
        {
            throw new NotImplementedException();
        }
    }
}
