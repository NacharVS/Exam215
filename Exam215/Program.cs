using System;

namespace Exam215
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Bank.Run();
            Console.ReadKey();
        }
    }
    class Bank
    {
        public static Bank bank = new Bank();
        private static int bank_balans = 0;
        private static int sum = 0;
        public delegate void AccountHandler(string message);       
        public static event AccountHandler Notify;
        private static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        private static void Refill()
        {
            Notify = DisplayMessage;

            Console.Write("Введите сумму для пополнения: ");
            sum = int.Parse(Console.ReadLine());
            bank_balans += sum;
            Notify?.Invoke($"На счет поступило: {sum} рублей \nВаш баланс {bank_balans}");
        }
        private static void Withdrawal()
        {
            Notify = DisplayMessage;

            Console.Write("Введите сумму для снятия: ");
            sum = int.Parse(Console.ReadLine());
            if (bank_balans - sum > 0)
            {
                bank_balans -= sum;
                Notify?.Invoke($"Со счета снято: {sum} рублей \nВаш баланс {bank_balans}");

            }
            else
            {
                Notify?.Invoke($"Недостаточно средств для снятия \nВаш баланс {bank_balans}");
            }
        }
        public static void Run()
        {
            Console.WriteLine("1. Пополнить счет");
            Console.WriteLine("2. Снять деньги со счета");
            Console.WriteLine("Выйти: любое число");
            Console.Write("Выберите операцию ");
            int op = int.Parse(Console.ReadLine());
            while (op > 0 && op < 3)
            {
                switch (op)
                {
                    case 1: Refill(); break;
                    case 2: Withdrawal(); break;
                }
                Console.Write("Выберите операцию ");
                op = int.Parse(Console.ReadLine());
            }
        }

    }
}

