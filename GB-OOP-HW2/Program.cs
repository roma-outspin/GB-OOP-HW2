using System;

namespace GB_OOP_HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i<10;i++)
            {
                var myAccount = new BankAccount();

                myAccount.SetBalance(999.99m+i);
                myAccount.SetAccountType(BankAccountTypes.Текущий);

                Console.WriteLine($"ID вашего счета: {myAccount.GetId()}\n" +
                    $"Тип вашего счета: {myAccount.GetAccountType()}\n" +
                    $"На вашем счету: {myAccount.GetBalance()}$\n");
            }



        }
    }
}
