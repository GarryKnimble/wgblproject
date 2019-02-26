using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Kiosk : KioskInterface
    {
        private Bank bank;
        private Account currentUser;

        public bool login(string username, string password)
        {
            Account login = bank.getAccount(username);
            // If user doesn't exist, then error
            if (login == null)
            {
                return false;
            }
            // If no user logged in.
            else
            {
                if (login.isPassword(password))
                {
                    currentUser = login;
                    return true;
                }
            }
            // If password is wrong, return false.
            return false;
        }
        public bool createAccount(string username, string password, int balance)
        {
            // If no user logged in, create account
            if (currentUser == null)
            {
                bank.createAccount(username, password, balance);
                return true;
            }
            // Otherwise, return false
            return false;
        }
        public bool deposit(int amount)
        {
            if(currentUser != null) return currentUser.deposit(amount);
            // If user not logged in, return false
            return false;
        }
        public bool withdrawal(int amount)
        {
            if (currentUser != null) return currentUser.withdrawal(amount);
            // If user not logged in, return false
            return false;
        }
        public void seeTransactionHistory()
        {
            currentUser.seeTransactionHistory();
        }
    }
}
