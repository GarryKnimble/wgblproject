using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Transactions : TransactionsInterface
    {
        Transaction newestTransaction;

        public void addTransaction(int amount)
        {
            Transaction newTransaction = new Transaction(amount);
            if(newestTransaction == null)
            {
                newestTransaction = newTransaction;
            }
            else
            {
                newTransaction.nextTransaction = newestTransaction;
                newestTransaction = newTransaction;
            }
        }

        public Transaction getTransactions()
        {
            return newestTransaction;
        }


        public void printTransactions()
        {
            if(newestTransaction == null)
            {
                Console.WriteLine("No transactions.");
            }
            else
            {
                printTransactions_h(newestTransaction);
            }
        }

        private void printTransactions_h(Transaction transaction)
        {
            if (transaction != null)
            {
                if (transaction.getAmount() > 0)
                {
                    Console.WriteLine("Deposit of $" + transaction.getAmount() + " on " + transaction.getDateTime().ToShortDateString());
                }
                else
                {
                    // Withdrawal value will be less than 0, so make it positive
                    Console.WriteLine("Withdrawal of $" + (transaction.getAmount() * -1) + " on " + transaction.getDateTime().ToShortDateString());
                }
                printTransactions_h(transaction.nextTransaction);
            }
        }
    }
}
