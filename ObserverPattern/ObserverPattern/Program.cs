// See https://aka.ms/new-console-template for more information
using ObserverPattern;

Account account = new("Anders Hejlsberg", 100_000);

AccountObserver observer = new();
account.AddObserver(observer);
account.Deposit(10000, "salary");
account.Withdraw(1000, "rent");
System.Console.WriteLine(account);
foreach (var txn in account.GetTransaction())
    System.Console.WriteLine(txn);

Console.ReadLine();
