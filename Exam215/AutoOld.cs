using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class AutoOld : AutoAbs
    {
        private static int miles;

        public AutoOld(string name, int miles, double price)
        {
            Name = name;
            Miles = miles;
            Price = price;

        }

        public static int Miles { get => miles; set => miles = value; }
    }
}
