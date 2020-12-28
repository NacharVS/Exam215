using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    interface ISnimati
    {
        
        public void snimat()
        {
            Console.WriteLine("Введети скооко снять ");
            int a = int.Parse(Console.ReadLine());

            NewBank1.vklad = (NewBank1.vklad - a);


        }

    }
}
