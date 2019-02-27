using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    interface TransactionInterface
    {
        // method: getAmount
        // description: Return the transaction amount
        int getAmount();

        // method: getDateTime
        // description: Get the date which the transaction
        // took place
        DateTime getDateTime();
    }
}
