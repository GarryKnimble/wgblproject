using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Account : AccountInterface
    {
        private string username;
        private string password;
        private Transaction transaction;
        private int balance;

        public void deposit(int amount)
        {
            // TODO: Implement depositing amount into account
        }

        public void withdrawal(int amount)
        {
            // TODO: Implement withdrawaling amount from account
        }

        public int checkBalance()
        {
            return balance;
        }

        public void seeTransactionHistory()
        {
            // TODO: Implement printing of transaction history
        }
    }
}
