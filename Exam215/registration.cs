using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{

    class Student
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string LoveFilm { get; set; }
        public string LoveEat { get; set; }

        public Student(string Surname, string Name, int Age) : this(Surname, Name, Age, " пусто", "пусто")
        {

        }
        public Student(string Surname, string Name) : this(Surname, Name, 00, " пусто", "пусто")
        {

        }

        public Student(string Surname, string Name, int Age, string Film, string Eat)

        {
            this.Surname = Surname;
            this.Name = Name;
            this.Age = Age;
            this.LoveFilm = Film;
            this.LoveEat = Eat;
        }
       

        public void GetInfo()

        {
            Console.WriteLine($"Им и фамиллия: {Surname} {Name}" +
                $" возраст {Age}" +
                $" любимый фильм: {LoveFilm} " +
                $"любимая еда {LoveEat}");
        }

    }

}