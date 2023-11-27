using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inlämningsuppgift3
{
    public class BankAccountsManager
    {
        private static int nextAcccountNumber = 1000;

        private List<BankAccounts> accounts;

        public BankAccountsManager()
        {
            accounts = new List<BankAccounts>();
        }
        public BankAccounts CreateAccount(string username, string password, int balance = 0)
        {
            BankAccounts newAccount = new BankAccounts(username, password, balance, nextAcccountNumber++);
            accounts.Add(newAccount);

            // Add the new account number to the user's list
            BankAccounts userAccount = accounts.FirstOrDefault(account => account.Username == username);
            if (userAccount != null)
            {
                userAccount.AccountNumber.Add(newAccount.AccountNumber);
            }

            return newAccount;
        }


        public BankAccounts Login(string username, string password)
        {
            return accounts.FirstOrDefault(account => account.Username == username && account.Password == password);
        }

        public int ViewBalance(string username)
        {
            BankAccounts userAccount = accounts.FirstOrDefault(account => account.Username == username);

            if (userAccount != null)
            {
                return userAccount.Balance;
            }
            else
            {
                return -1;
            }
        }

    }
}
