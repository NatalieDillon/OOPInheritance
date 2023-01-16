using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPInheritance.Classes.Banking
{
    public enum TransactionType { Cash, Cheque, StandingOrder, BankTransfer, DirectDebit, Card}
    public class Transaction
    {
        public decimal Amount { get; private set; }
        public TransactionType Type { get; private set; }

        public string Description { get; private set; }

        public Transaction(decimal amount, string description, TransactionType transactionType)
        {
            Amount = amount;
            Description = description;
            Type = transactionType;
        }

    }
}
