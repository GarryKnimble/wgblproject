using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    interface BankInterface
    {
        // method: createAccount
        // username - The username of the account to create
        // password - The password of the account to create
        // balance - The initial balance for the new account
        // description: Create an account with a username, password,
        // and initial balance
        void createAccount(string username, string password, int balance);

        // method: getAccount
        // username - The username of the account to get
        // description: Retrieves the account with the given username
        Account getAccount(string username);
    }
}
