using System;

namespace GB_OOP_HW2
{
    public class BankAccount
    {

        private static int idGenerator = 1;

        public int Id { get; private set; }
        public decimal Balance { get; set; }
        public BankAccountTypes AccountType { get; set; }

        public BankAccount()
        {
            Id = idGenerator;
            idGenerator++;
        }

        public BankAccount(decimal money) : this()
        {
            Balance = money;
        }

        public BankAccount(BankAccountTypes accounType) : this()
        {
            AccountType = accounType;
        }

        public BankAccount(decimal money, BankAccountTypes accounType) : this()
        {
            Balance = money;
            AccountType = accounType;
        }

        public override string ToString()
        {
            return $"ID вашего счета: {Id}\n" +
                    $"Тип вашего счета: {AccountType}\n" +
                    $"На вашем счету: {Balance}$\n";
        }

        public void AddMoney(decimal summ)
        {
            if (summ <= 0)
            {
                throw new ArgumentException("Сумма не может быть меньше нуля");
            }

            Balance += summ;
        }

        public bool TakeOffMoney(decimal summ)
        {
            if (summ <= 0)
            {
                throw new ArgumentException("Сумма не может быть меньше нуля");
            }
            if (Balance >= summ)
            {
                Balance -= summ;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool TransferMoney(ref BankAccount sourceAccount, decimal summ)
        {
            if (summ <= sourceAccount.Balance)
            {
                sourceAccount.Balance -= summ;
                this.Balance += summ;
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
