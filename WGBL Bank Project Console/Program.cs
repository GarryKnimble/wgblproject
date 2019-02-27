using System;

namespace WGBL_Bank_Project_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiosk kiosk = new Kiosk();
            Console.WriteLine("Welcome to the WGBL Bank!");
            string username;
            string password;
            while (true)
            {
                int option;
                if (!kiosk.isLoggedIn())
                {
                    Console.WriteLine("\nWhat do you want to do?\n" +
                        "[0] Login\n" +
                        "[1] Create Account");
                    Console.Write("Choose available options to begin: ");
                    try
                    {
                        option = Int32.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nError reading input: " + e.Message);
                        option = -1;
                    }
                    switch (option)
                    {
                        case 0:
                            Console.Write("Enter your username: ");
                            username = Console.ReadLine();
                            Console.Write("Enter your password: ");
                            password = Console.ReadLine();
                            // If login fails
                            if (!kiosk.login(username, password))
                            {
                                Console.WriteLine("\nThe username or password was incorrect.");
                            }
                            else
                            {
                                Console.WriteLine("\nWelcome, " + username + "!");
                            }
                            break;
                        case 1:
                            Console.Write("Enter a username to use: ");
                            username = Console.ReadLine();
                            Console.Write("Enter a password to use: ");
                            password = Console.ReadLine();
                            try
                            {
                                kiosk.createAccount(username, password, 100);
                                Console.WriteLine("\nAccount creation successful.");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("\nError when creating account: " + e.Message);
                            }
                            break;
                        default:
                            Console.WriteLine("\nOption not recognized.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\nThe following are the available options.\n" +
                        "[0] Deposit\n" +
                        "[1] Withdrawal\n" +
                        "[2] Check Balance\n" +
                        "[3] Transaction History\n" +
                        "[4] Log out");
                    Console.Write("Input 0-4 to do an action: ");
                    try
                    {
                        option = Int32.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nError reading input: " + e.Message);
                        option = -1;
                    }
                    switch (option)
                    {
                        case 0:
                            int amount;
                            Console.Write("\nHow much would you like to deposit?: ");
                            try
                            {
                                amount = Int32.Parse(Console.ReadLine());
                                kiosk.deposit(amount);
                                Console.WriteLine("\nDeposit success");
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine("\nError with deposit: " + e.Message);
                            }
                            break;
                        case 1:
                            Console.Write("\nHow much would you like to withdrawal?: ");
                            try
                            {
                                amount = Int32.Parse(Console.ReadLine());
                                kiosk.withdrawal(amount);
                                Console.WriteLine("\nWithdrawal success");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("\nError with withdrawal: " + e.Message);
                            }
                            break;
                        case 2:
                            Console.WriteLine("\nYour current balance is $" + kiosk.checkBalance());
                            break;
                        case 3:
                            Console.WriteLine("\nYour transaction history: ");
                            kiosk.seeTransactionHistory();
                            break;
                        case 4:
                            kiosk.logout();
                            Console.WriteLine("\nYou are logged out now.");
                            break;
                        default:
                            Console.WriteLine("\nOption not recognized");
                            break;
                    }
                }
            }
        }
    }
}
