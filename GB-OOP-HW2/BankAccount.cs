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


        public int GetId()
        {
            return _id;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void SetBalance(decimal balance)
        {
            _balance = balance;
        }

        public BankAccountTypes GetAccountType()
        {
            return _accountType;
        }

        public void SetAccountType(BankAccountTypes accountType)
        {
            _accountType = accountType;
        }



    }

}
