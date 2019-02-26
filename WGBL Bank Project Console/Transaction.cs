using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Transaction
    {
        private int amount;
        private Transaction nextTransaction;
        private DateTime dateTime;

        public Transaction(int amount)
        {
            this.amount = amount;
            this.dateTime = DateTime.Now;
        }

        public void printTransactions()
        {
            printTransactions_h(this);
        }

        private void printTransactions_h(Transaction transaction)
        {
            if(transaction != null)
            {
                if (amount > 0)
                {
                    Console.WriteLine("Deposit of $" + amount + " on " + dateTime.ToShortDateString());
                }
                else
                {
                    // Withdrawal value will be less than 0, so make it positive
                    Console.WriteLine("Withdrawal of $" + (amount * -1) + " on " + dateTime.ToShortDateString());
                }
                printTransactions_h(transaction.nextTransaction);
            }
        }

        public void addTransaction(int amount)
        {
            nextTransaction = new Transaction(amount);
        }
    }
}
