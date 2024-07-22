using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Account
    {

        private static long accountSequence = 10;
        private long accountNumber;
        private string holdersName;
        private double balance;
        private List<Transaction> transactions = new();
        private List<IAccountObserver> observers = new();

        public Account(string holdersName, double balance)
        {
            this.accountNumber = Account.accountSequence++;
            this.holdersName = holdersName;
            this.balance = balance;
        }

        public void Withdraw(double amount, string remarks)
        {
            if (amount > this.balance)
                throw new Exception("Insufficient balance");

            this.balance -= amount;

            var txn = new Transaction(amount, remarks, TransType.DR);
            transactions.Add(txn);
            NotifyObservers();
        }

        public void Deposit(double amount, string remarks)
        {
            this.balance += amount;

            var txn = new Transaction(amount, remarks, TransType.CR);
            transactions.Add(txn);
            NotifyObservers();
        }

        public override string ToString() =>
        $"{accountNumber}: {holdersName} {balance}";

        public List<Transaction> GetTransaction()
        {
            return this.transactions;
        }

        public void AddObserver(IAccountObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IAccountObserver observer)
        {
            observers.Remove(observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(this);
            }
        }

    }

    public class AccountObserver : IAccountObserver
    {
        public void Update(Account account)
        {
            Console.WriteLine($"Account {account} has been updated.");
        }
    }
}
