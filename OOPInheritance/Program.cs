using System;
using OOPInheritance.Classes.Banking;
using OOPInheritance.Classes.HR;

namespace OOPInheritance
{
    internal class Program
    {
        static void Main()
        {
            TestBankAccounts();
            TestPeople();
        }

        static void TestPeople()
        {
            Person person = new Person("Joe Smith", new DateTime(2007, 12, 22));
            Console.WriteLine(person.Description());

            CheckingAccount checkingAccount = new(300, new DateTime(2022, 10, 11), person);
            Console.WriteLine($"Current Balance: {checkingAccount.Balance}");

            Employee employee = new Employee("Jane Brown", new DateTime(2007, 12, 22), new DateTime(2019, 02, 13));
            Console.WriteLine(employee.Description());           

            Department accounts = new Department("Accounts");
            accounts.AddEmployee(employee);
        }

        static void TestBankAccounts()
        {
            Person peterRabbit = new Person("Peter Rabbit", new DateTime(1884, 12, 12));
            CheckingAccount checkingAccount = new(300, new DateTime(2022, 10, 11), peterRabbit);
            checkingAccount.UpdateOverdraftLimit(1000);

            SavingsAccount savingsAccount = new(600, new DateTime(2022, 01, 03), peterRabbit, 0.01m);

            List<BankAccount> bankAccounts = new List<BankAccount> { checkingAccount, savingsAccount };
            foreach (BankAccount bankAccount in bankAccounts)
            {

                Console.WriteLine(bankAccount.GetType());
                Console.WriteLine($"Current Balance: {bankAccount.Balance}");

                // This is polymorphism, the object will be processed differently depending on its class
                bankAccount.Withdraw(100, TransactionType.Card);

                Console.WriteLine($"New Balance: {bankAccount.Balance}");
                Console.WriteLine();
            }
        }
    }
}