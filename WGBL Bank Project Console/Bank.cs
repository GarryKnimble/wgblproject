using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Bank : BankInterface
    {
        private Dictionary<String, Account> accounts;

        public Bank()
        {
            accounts = new Dictionary<string, Account>();
        }

        public void createAccount(string username, string password, int balance)
        {
            if (!accounts.ContainsKey(username)) {
                // Add new account to accounts dictionary
                accounts.Add(username, new Account(username, password, balance));
            }
            else
            {
                throw new Exception("An account with the username '" + username + "' already exists.");
            }
        }

        public Account getAccount(string username)
        {
            // Retrieve account given username
            if(accounts.ContainsKey(username)) return accounts[username];
            return null;
        }
    }
}
