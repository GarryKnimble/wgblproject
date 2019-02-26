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

        public bool deposit(int amount)
        {
            if (amount > 0)
            {
                // Increment to balance
                balance += amount;
                addTransaction(amount);
                return true;
            }
            return false;
        }

        public bool withdrawal(int amount)
        {
            if (amount > 0)
            {
                // Decrement from balance
                balance -= amount;
                addTransaction(-amount);
                return true;
            }
            return false;
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

        private void addTransaction(int amount)
        {
            transactions.addTransaction(amount);
        }

        public bool isPassword(string password)
        {
            if (password.Equals(this.password)) return true;
            return false;
        }
    }
}
