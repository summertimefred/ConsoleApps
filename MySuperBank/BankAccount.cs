using System;
using System.Collections.Generic;
using System.Text;

namespace MySuperBank
{
    class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }

        public decimal Balance {
            get 
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            }
 
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial Deposit");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }


        public void MakeDeposit(decimal amount, DateTime date, string note) 
        {
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }
        public void MakeWithdrawl(decimal amount, DateTime date, string note)
        {
            var withdrawl = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawl);
        }
    }
}
