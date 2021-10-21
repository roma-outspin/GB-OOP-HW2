namespace GB_OOP_HW2
{
    public class BankAccount
    {
        private int _id;
        private decimal _balance;
        private BankAccountTypes _accountType;

        public int GetId()
        {
            return _id;
        }

        public void SetId(int id)
        {
            _id = id;
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
