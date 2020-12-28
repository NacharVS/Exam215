using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    interface IVevesti
    {
        public void vevesti()
        {
             Console.WriteLine("ВВедите сколько пополнить  ");
            int a = int.Parse(Console.ReadLine());

            NewBank1.vklad = (NewBank1.vklad + a);

       }
    }
}
