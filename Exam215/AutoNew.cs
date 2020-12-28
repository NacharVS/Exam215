using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class AutoNew : AutoAbs
    {
        private static double _saleper = 0.30;

        public AutoNew(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
