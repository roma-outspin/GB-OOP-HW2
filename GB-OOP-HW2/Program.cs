using System;

namespace GB_OOP_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            myAccount.SetId(35);
            myAccount.SetBalance(999.99m);
            myAccount.SetAccountType(BankAccountTypes.Текущий);

            Console.WriteLine($"ID моего счета: {myAccount.GetId()}\n" +
                $"Тип моего счета: {myAccount.GetAccountType()}\n" +
                $"На моем счету: {myAccount.GetBalance()}$\n");
        }
    }
}
