using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    interface TransactionsInterface
    {
        // method: addTransaction
        // amount - Transaction value to apply
        // description: Adds a new transaction to the 
        // list of transactions.
        void addTransaction(int amount);

        // method: getTransactions
        // description: Returns first node in transactions
        // list.
        Transaction getTransactions();

        // method: printTransactions
        // description: Print all the transactions in linkedlist
        void printTransactions();
    }
}
