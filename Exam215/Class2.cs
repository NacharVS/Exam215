using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace _215Labs2020.Zifarov.Delegates
{
    class Class2
    {
        private delegate void Onemass(int[] array1);
       
        public static void ab(int[] array1)
        {
            Onemass tr;
            tr = Class1.Sum;
            tr += Class1.Mul;
            tr += Class1.Sorting;
            tr(array1);
        }
        
    }

}