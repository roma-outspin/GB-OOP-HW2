namespace GB_OOP_HW2
{
    public class BankAccount
    {
        private int _id;
        private decimal _balance;
        private BankAccountTypes _accountType;

        private static int idGenerator = 1;

        private static void AssignId()
        {
            idGenerator++;
        }

        public BankAccount()
        {
            _id = idGenerator;
            AssignId();
        }

        public BankAccount(decimal money) :this()
        {
            _balance = money;
        }

        public BankAccount(BankAccountTypes accounType) : this()
        {
            _accountType = accounType;
        }

        public BankAccount(decimal money, BankAccountTypes accounType) : this()
        {
            _balance = money;
            _accountType = accounType;
        }

        public int GetId()
        {
            return _id;
        }

        public decimal GetBalance()
        {
            return _balance;
        }


        public BankAccountTypes GetAccountType()
        {
            return _accountType;
        }

        public override string ToString()
        {
            return $"ID вашего счета: {_id}\n" +
                    $"Тип вашего счета: {_accountType}\n" +
                    $"На вашем счету: {_balance}$\n";
        }
    }

}
