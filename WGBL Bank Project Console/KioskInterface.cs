using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    interface KioskInterface
    {
        // method: login
        // username - Username of account to login to
        // password - Password of account to login to
        // description: Attempt to login to account with
        // given username and password
        void login(string username, string password);

        // method: createAccount
        // username - Username to create account with
        // password - Password to create account with
        // balance - Initial balance to create account with
        void createAccount(string username, string password, int balance);

        //method: deposit
        // amount - Amount to deposit to current account
        // description: Deposit amount to current account
        void deposit(int amount);

        // method: withdrawal
        // amount - Amount to withdrawal from current account
        // description: Withdrawal amount from current account
        void withdrawal(int amount);

        // method: seeTransactionHistory
        // description: Print out the transaction history of
        // current account
        void seeTransactionHistory();
    }
}
