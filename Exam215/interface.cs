using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    interface IAttack
    {
        public int Damage { get; }
        public void Attack();
    }
}
