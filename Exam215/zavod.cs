using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class zavod : unit, IHealth
    {
        public zavod()
        {
        }

        public zavod( int _health)
        {
            Health = _health;
        }
        void IHealth.Health()
        {
            throw new NotImplementedException();
        }
    }
}
