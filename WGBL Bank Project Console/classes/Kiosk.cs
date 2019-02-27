using System;
using System.Collections.Generic;
using System.Text;

namespace WGBL_Bank_Project_Console
{
    class Kiosk : KioskInterface
    {
        private Bank bank;
        private Account currentUser;

        public Kiosk()
        {
            bank = new Bank();
        }

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

        public void createAccount(string username, string password, int balance)
        {
            // If no user logged in, create account
            if (currentUser == null)
            {
                if (username.Length == 0 || password.Length == 0) throw new Exception("You cannot create an account with no username or password.");
                bank.createAccount(username, password, balance);
            }
            else
            {
                throw new Exception("You cannot create an account while another user is logged into this kiosk.");
            }
        }

        public void deposit(int amount)
        {
            if (currentUser != null)
            {
                currentUser.deposit(amount);
            }
            else
            {
                throw new Exception("You cannot make a deposit when not logged in.");
            }
        }

        public void withdrawal(int amount)
        {
            if (currentUser != null)
            {
                currentUser.withdrawal(amount);
            }
            else
            {
                throw new Exception("You cannot withdrawal when not logged in.");
            }
        }

        public void seeTransactionHistory()
        {
            currentUser.seeTransactionHistory();
        }

        public bool isLoggedIn()
        {
            return (currentUser != null);
        }

        public int checkBalance()
        {
            return currentUser.checkBalance();
        }

        public void logout()
        {
            currentUser = null;
        }
    }
}
