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
        public Student(string Surname, string Name, string v) : this(Surname, Name, 00, " пусто", "пусто")
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
            Console.WriteLine($"Name and surname {Surname} {Name}"+ $"age {Age}" + $"Love Film {LoveFilm}" + $"Love Eat {LoveEat}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Liliya = new Student("Davletshina", "Liliya", "17", "IT", "Макароны");
            Liliya.GetInfo();

            Student Aliya = new Student("Nurtdinova","Aliya","17","Ёлки","Борщ");
            Aliya.GetInfo();

            Student Karina = new Student("Shakirova","Karina","17","После","Гречка");
        }
    }
}
