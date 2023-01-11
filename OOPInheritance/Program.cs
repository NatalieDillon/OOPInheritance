using System;
using OOPInheritance.Classes;

namespace OOPInheritance
{
    internal class Program
    {
        static void Main()
        {
            CheckingAccount checkingAccount = new(300, new DateTime(2022, 10, 11), "Peter Rabbit");
            checkingAccount.UpdateOverdraftLimit(1000);

            SavingsAccount savingsAccount = new(600, new DateTime(2022, 01, 03), "Bugs Bunny", 0.01m);

            List<BankAccount> bankAccounts = new List<BankAccount> { checkingAccount, savingsAccount };
            foreach (BankAccount bankAccount in bankAccounts){
                
                Console.WriteLine(bankAccount.GetType());
                Console.WriteLine($"Current Balance: {bankAccount.Balance}");

                // This is polymorphism, the object will be processed differently depending on its class
                bankAccount.Withdraw(1000);

                Console.WriteLine($"New Balance: {bankAccount.Balance}");
                Console.WriteLine();
            }
        }
    }
}