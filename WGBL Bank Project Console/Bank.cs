using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Bank : BankInterface
    {
        private Dictionary<String, Account> accounts;

        public void createAccount(string username, string password, int balance)
        {
            // Add new account to accounts dictionary
            accounts.Add(username, new Account(username, password, balance));
        }
    }
}
