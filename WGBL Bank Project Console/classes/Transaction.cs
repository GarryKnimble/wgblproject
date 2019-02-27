using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Transaction
    {
        private int amount;
        public Transaction nextTransaction;
        private DateTime dateTime;

        public Transaction(int amount)
        {
            this.amount = amount;
            this.dateTime = DateTime.Now;
        }

        public int getAmount()
        {
            return amount;
        }

        public DateTime getDateTime()
        {
            return dateTime;
        }
    }
}
