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
        // given username and password. Returns true if
        // login successful. Otherwise, it returns false
        bool login(string username, string password);

        // method: createAccount
        // username - Username to create account with
        // password - Password to create account with
        // balance - Initial balance to create account with
        // description: Create an account in the bank. Returns true
        // if there is no account logged in already. Otherwise, it
        // returns false.
        bool createAccount(string username, string password, int balance);

        //method: deposit
        // amount - Amount to deposit to current account
        // description: Deposit amount to current account.
        // If the amount is greater than 0, it returns true.
        // Otherwise, it returns false.
        bool deposit(int amount);

        // method: withdrawal
        // amount - Amount to withdrawal from current account
        // description: Withdrawal amount from current account.
        // If the amount is greater than 0, it returns true.
        // Otherwise, it returns false.
        bool withdrawal(int amount);

        // method: seeTransactionHistory
        // description: Print out the transaction history of
        // current account
        void seeTransactionHistory();
    }
}
