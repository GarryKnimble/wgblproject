using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Kiosk : KioskInterface
    {
        private Bank bank;
        private Account currentUser;

        public void login(string username, string password)
        {
            // TODO: Implement login method
        }
        public void createAccount(string username, string password, int balance)
        {
            // TODO: Implement account creation
        }
        public void deposit(int amount)
        {
            // TODO: Implement depositing into account
        }
        public void withdrawal(int amount)
        {
            // TODO: Implement withdrawaling from account
        }
        public void seeTransactionHistory()
        {
            // TODO: Implement printing transaction history of account
        }
    }
}
