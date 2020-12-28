using System;

namespace Exam215
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Лёха = new Student("Максимов", "Алексей", 16, "Тачки", "Борщ");
            Лёха.GetInfo();
            Student Кирилл = new Student("Охотников", "Кирилл");
            Кирилл.GetInfo();
            Student Вася = new Student("Ильясов", "Вася", 15);
            Вася.GetInfo();
        }
    }
}
