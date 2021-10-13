using System;

namespace GB_OOP_HW2
{
    class Program
    {
        static void Main(string[] args)
        {

            var myAccount1 = new BankAccount(99999.99m);
            Console.WriteLine("Введите команды add или take для добавления/снятия денег на счет и сумму через пробел\n" +
                "Введите exit для завершения программы\n" +
                $"Сейчас у Вас на счету: {myAccount1.Balance}$");
            while(true)
            {
                try
                {
                    var comm = Console.ReadLine().Split(' ');
                    if (comm[0].ToLower().Equals("add"))
                    {
                        myAccount1.AddMoney(Convert.ToDecimal(comm[1]));
                    } 
                    else if(comm[0].ToLower().Equals("take"))
                    {
                        myAccount1.TakeOffMoney(Convert.ToDecimal(comm[1]));
                    }
                    else if (comm[0].ToLower().Equals("exit"))
                    {
                        Console.WriteLine("Завершение программы");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите команды add или take для добавления / снятия денег на счет и сумму через пробел");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine($"Ваш баланс: {myAccount1.Balance}$"); 
            }

        }
    }
}
