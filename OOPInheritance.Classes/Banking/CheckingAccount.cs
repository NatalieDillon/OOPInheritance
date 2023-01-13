using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Classes.Banking
{
    public class CheckingAccount : BankAccount
    {
        public int OverdraftLimit { get; private set; }

        public CheckingAccount(decimal openingBalance, DateTime openingDate, string accountHolder) : base(openingDate, accountHolder)
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

        public override void Withdraw(decimal amount)
        {
            decimal newBalance = Balance - amount;
            if (newBalance < OverdraftLimit * -1)
            {
                throw new InvalidOperationException("Overdraft limit would be exceeded");
            }
            Balance = newBalance;
        }
    }
}
