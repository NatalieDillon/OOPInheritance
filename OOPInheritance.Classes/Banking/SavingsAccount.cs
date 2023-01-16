
using OOPInheritance.Classes.HR;

namespace OOPInheritance.Classes.Banking
{
    public class SavingsAccount : BankAccount
    {
        private const int MinimumOpeningBalance = 500;

        private DateTime _interestLastUpdated;

        public decimal InterestRate { get; private set; }

        public SavingsAccount(decimal openingBalance, DateTime openingDate, Person accountHolder, decimal interestRate) : base(openingDate, accountHolder)
        {
            if (openingBalance < MinimumOpeningBalance)
            {
                throw new ArgumentException($"{openingBalance} must be greater than {MinimumOpeningBalance}", nameof(openingBalance));
            }
            OpeningBalance = openingBalance;
            Balance = openingBalance;
            InterestRate = interestRate;
            _interestLastUpdated = OpeningDate;
        }

        public override void Withdraw(decimal amount, TransactionType type, string description="")
        {            
            if (Balance < Math.Abs(amount))
            {
                throw new InvalidOperationException("Account cannot be in debit");
            }
            decimal withdrawal = Math.Abs(amount) * -1;
            AddTransaction(withdrawal, description, type);
            Balance += withdrawal;
        }

        public decimal CalculateAndAddInterest()
        {
            TimeSpan difference = DateTime.Today - _interestLastUpdated;
            decimal interest = difference.Days * (InterestRate / 365);
            Balance += interest;
            return interest;
        }
    }
}
