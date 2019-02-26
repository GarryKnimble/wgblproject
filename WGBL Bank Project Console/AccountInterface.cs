using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    interface AccountInterface
    {
        // method: deposit
        // amount - The amount to deposit into account
        // description: Deposit amount into account
        bool deposit(int amount);

        // method: withdrawal
        // amount - The amount to withdrawal from account
        // description: Withdrawal from account
        bool withdrawal(int amount);

        // method: checkBalance
        // description: Returns the balance of the account
        int checkBalance();

        // method: seeTransactionHistory
        // description: Prints the transaction history of account
        void seeTransactionHistory();
    }
}
