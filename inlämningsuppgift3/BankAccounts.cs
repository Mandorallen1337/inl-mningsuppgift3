using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inlämningsuppgift3
{
    public class BankAccounts
    {
        public string Username { get; set; }
        private string Password { get; set; }
        public int Balance { get; set; }

        public static List<BankAccounts> accounts = new List<BankAccounts>()
        {
            new BankAccounts("user1", "1357", 1000),
            new BankAccounts("user2", "2532", 5000),
            new BankAccounts("user3", "6432", 10000)
        };




        public BankAccounts(string username = "", string password = "", int balance = 0)
        {
            Username = username;
            Password = password;
            Balance = balance;
        }
        public bool Deposit(int amount)
        {
            Balance += amount;
            return true;
        }
        
        public bool Withdraw(int amount)
        {
            
             if (amount > Balance)
             {
                 return false;
             }
             else
             {
                 Balance -= amount;
                 return true;
             }
                                    
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

        

        public BankAccounts Login(string username, string password)
        {
            return accounts.FirstOrDefault(account => account.Username == username && account.Password == password);
        }

        

    }
}
