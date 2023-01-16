using OOPInheritance.Classes.HR;

namespace OOPInheritance.Classes.Banking
{
    public abstract class BankAccount
    {
        //Fields

        // Composition - the transactions are tied to the bank account
        // They cannot have an independent existence outside of the bank account
        private List<Transaction> _transactions = new List<Transaction>();

        // Properties

        // Association - a bank account has an account holder
        protected Person AccountHolder { get; private set; } 
        public decimal Balance { get; protected set; }
        public decimal OpeningBalance { get; protected set; }
        public DateTime OpeningDate { get; private set; }

        public string AccountHolderName { get { return AccountHolder.Name; } }

        // Constructor
        public BankAccount(DateTime openingDate, Person accountHolder)
        {
            OpeningDate = openingDate;
            AccountHolder = accountHolder;
        }

        // Methods
        protected void AddTransaction(decimal amount, string description, TransactionType type)
        {
            Transaction transaction = new Transaction(amount, description, type);
            _transactions.Add(transaction);
        }

        public abstract void Withdraw(decimal amount, TransactionType type, string description = ""); // Must be overriden

        public virtual void Deposit(decimal amount, TransactionType type, string description = "") // Can be overriden
        {
            Transaction transaction = new Transaction(Math.Abs(amount), description, type);
            _transactions.Add(transaction);
            Balance += Math.Abs(transaction.Amount);
        }

    }
}