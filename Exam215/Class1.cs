using System;
using System.Collections.Generic;
using System.Text;

namespace Exam215
{
    class Bank : Person
    {
        public static int UserID { get; set; }
        private static double bank_balans = 0;
        private static int id;
        private static string name, surname, phone;

        private static Dictionary<int, Bank> ClientList = new Dictionary<int, Bank>();
        private static List<double> ListBalans = new List<double>();

        public delegate void AccountHandler(string message);
        public static event AccountHandler Notify = (message) =>
        {
            Console.WriteLine($"\nНа номер {phone} было отправлено сообщение \nСообщение: {message}\n");
        };
        public Bank(string surname, string name, string phone)
        {
            SurName = surname;
            Name = name;
            Phone = phone;
        }
        private static void FullName()
        {
            bank_balans = 0;
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            id+= 1;
            ListBalans.Add(bank_balans);
        }
        private static void New()
        {
            bank_balans = 0;
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            id += 1;
            ListBalans.Add(bank_balans);
        }
        private static void Transfer()
        {
            int a;
            Console.Write("Введите счет, на которую переводите деньги: ");
            int login_transfer = int.Parse(Console.ReadLine());
            Console.Write("Введите сумму которую хотите перевести: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Введиет правильную сумму");
                a = int.Parse(Console.ReadLine());
            }
            if (a < 10000)
            {
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма для перевода 10 000 рублей.");
                    Console.Write("Введите сумму которую хотите перевести: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            while (a > 200000)
            {
                Console.WriteLine("Максимальная сумма для перевода 200 000 рублей");
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введиет правильную сумму");
                    a = int.Parse(Console.ReadLine());
                }
                while (a < 10000)
                {
                    Console.WriteLine("Минимальная сумма для перевода 10 000 рублей.");
                    Console.Write("Введите сумму которую хотите перевести: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            while (bank_balans - a < 0)
            {
                if (bank_balans - a < 0)
                {
                    Console.WriteLine($"Недостаточно средст для перевода. Ваш баланс {bank_balans}");
                    Console.Write("Введите сумму которую хотите перевести: ");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введиет правильную сумму");
                        a = int.Parse(Console.ReadLine());
                    }
                }
            }
            if (bank_balans >= a)
            {
                bank_balans -= a;
                Notify?.Invoke($"Был осуществлен перевод на счет {login_transfer} на сумма {a} рублей. Ваш баланс {bank_balans} рублей.");
                ListBalans[ClientList.Count - 1] = bank_balans;
            }

        }
        public static void Operation()
        {
            int number_operation;
            Console.WriteLine("1. Зарегистрироваться");
            Console.WriteLine("2. Выйти");
            Console.WriteLine("3. Новый аккаунт");
            Console.Write("Выберите дальшейшие действие ");
                try
                {
                    number_operation = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Введите правильную сумму");
                    number_operation = int.Parse(Console.ReadLine());
                }
                while (number_operation > 0 && number_operation < 10)
                {
                    switch (number_operation)
                    {
                    case 1: FullName(); break;
                    case 2: Transfer(); break;
                    case 3: New(); break;
                }
                    try

                    {
                        number_operation = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Введите правильную сумму");
                    }
                }
            }
        
        }
    }
