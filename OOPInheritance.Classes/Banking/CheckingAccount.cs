using OOPInheritance.Classes.HR;

namespace OOPInheritance.Classes.Banking
{
    public class CheckingAccount : BankAccount
    {
        public int OverdraftLimit { get; private set; }

        public CheckingAccount(decimal openingBalance, DateTime openingDate, Person accountHolder) : base(openingDate, accountHolder)
        {
            OpeningBalance = openingBalance;
            Balance = openingBalance;
        }

        public void UpdateOverdraftLimit(int overdraftLimit)
        {
            if (Balance < 0)
            {
                throw new InvalidOperationException("Account must be in credit first.");
            }
            OverdraftLimit = overdraftLimit;
        }        

        public override void Withdraw(decimal amount, TransactionType type, string description = "")
        {
            decimal newBalance = Balance - Math.Abs(amount);
            if (newBalance < OverdraftLimit * -1)
            {
                throw new InvalidOperationException("Overdraft limit would be exceeded");
            }
            AddTransaction(Math.Abs(amount) * -1, description, type);
            Balance = newBalance;
        }
    }
}
