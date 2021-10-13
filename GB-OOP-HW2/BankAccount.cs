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

        public BankAccount(decimal money) :this()
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
    }

}
