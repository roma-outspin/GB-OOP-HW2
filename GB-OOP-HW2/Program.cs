using System;

namespace GB_OOP_HW2
{
    class Program
    {
        static void Main(string[] args)
        {

            var account1 = new BankAccount();
            var account2 = new BankAccount(5555.55m);
            var account3 = new BankAccount(BankAccountTypes.Дебетовый);
            var account4 = new BankAccount(35, BankAccountTypes.Кредитный);

            var account5 = new BankAccount()
            {
                Balance = 0.99m,
                AccountType = BankAccountTypes.Депозитный
            };

            var account6 = new BankAccount();
            account6.Balance = -500;
            account6.AccountType = BankAccountTypes.Кредитный;

            Console.WriteLine(account1.ToString());
            Console.WriteLine(account2.ToString());
            Console.WriteLine(account3.ToString());
            Console.WriteLine(account4.ToString());
            Console.WriteLine(account5.ToString());
            Console.WriteLine(account6.ToString());
        }
    }
}
