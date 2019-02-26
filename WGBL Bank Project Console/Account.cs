using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Account : AccountInterface
    {
        private string username;
        private string password;
        private Transaction transactions;
        private int balance;

        public Account(string username, string password, int balance)
        {
            this.username = username;
            this.password = password;
            this.balance = balance;
        }

        public int deposit(int amount)
        {
            // Increment to balance
            balance += amount;
            return amount;
        }

        public int withdrawal(int amount)
        {
            // Decrement from balance
            balance -= amount;
            return -amount;
        }

        public int checkBalance()
        {
            // Return account balance
            return balance;
        }

        public void seeTransactionHistory()
        {
            // Print account transaction history
            transactions.printTransactions();
        }
    }
}
