using System;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Fred", 1200);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with Balance {account.Balance}");

            account.MakeWithdrawl(800, DateTime.Now, "buy gaming pc");
            Console.WriteLine($"Account Balance {account.Balance}");
        }
    }
}
