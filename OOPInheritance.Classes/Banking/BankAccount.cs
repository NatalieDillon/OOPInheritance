namespace OOPInheritance.Classes.Banking
{
    public abstract class BankAccount
    {
        // Properties
        public decimal Balance { get; protected set; }
        public decimal OpeningBalance { get; protected set; }
        public DateTime OpeningDate { get; private set; }
        public string AccountHolder { get; private set; }

        // Constructor
        public BankAccount(DateTime openingDate, string accountHolder)
        {
            OpeningDate = openingDate;
            AccountHolder = accountHolder;
        }

        // Methods

        private string Test()
        {
            return "test";
        }
        public abstract void Withdraw(decimal amount);

        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine(Test());
        }

    }
}