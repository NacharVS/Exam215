using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    abstract class AutoAbs
    {
        private static string _name;
        private static double _price;

        public static string Name { get => _name; set => _name = value; }
        public static double Price { get => _price; set => _price = value; }
    }
}
