using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    interface TransactionInterface
    {
        // method: printTransactions
        // description: Print all the transactions in linkedlist
        void printTransactions();

        // method: addTransaction
        // description: Add transaction to linkedlist of transactions
        void addTransaction(int amount);
    }
}
