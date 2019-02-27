using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Account : AccountInterface
    {
        private string username;
        private string password;
        private Transactions transactions;
        private int balance;

        public Account(string username, string password, int balance)
        {
            this.username = username;
            this.password = password;
            this.balance = balance;
            this.transactions = new Transactions();
        }

        public void deposit(int amount)
        {
            if (amount > 0)
            {
                // Increment to balance
                balance += amount;
                addTransaction(amount);
            }
            else
            {
                throw new Exception("You cannot deposit a negative amount.");
            }
        }

        public void withdrawal(int amount)
        {
            if (balance - amount < 0) throw new Exception("You cannot withdrawal more than your account has.");
            if (amount > 0)
            {
                // Decrement from balance
                balance -= amount;
                addTransaction(-amount);
            }
            else
            {
                throw new Exception("You cannot withdrawal a negative amount.");
            }
        }

        public int checkBalance()
        {
            // Return account balance
            return balance;
        }

        public void seeTransactionHistory()
        {
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
