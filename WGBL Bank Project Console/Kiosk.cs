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
            if (login == null)
            {
                return false;
            }
            else
            {
                if (login.isPassword(password))
                {
                    currentUser = login;
                    return true;
                }
            }
            return false;
        }
        public bool createAccount(string username, string password, int balance)
        {
            if (currentUser != null)
            {
                bank.createAccount(username, password, balance);
                return true;
            }
            return false;
        }
        public bool deposit(int amount)
        {
            if(currentUser != null) return currentUser.deposit(amount);
            return false;
        }
        public void withdrawal(int amount)
        {
            if (currentUser != null) return currentUser.withdrawal(amount);
            return false;
        }
        public void seeTransactionHistory()
        {
            currentUser.seeTransactionHistory();
        }
    }
}
