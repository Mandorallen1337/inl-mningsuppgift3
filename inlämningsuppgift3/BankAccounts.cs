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
        public string Password { get; set; }
        public int Balance { get; set; }
        public List <int> AccountNumber { get; private set; }

       


        public BankAccounts(string username = "", string password = "", int balance = 0, int accountNumber = 0)
        {
            Username = username;
            Password = password;
            Balance = balance;
            AccountNumber = new List<int>();
            

        }
        //Remove?
        //private static int nextAccountNumber = 1000;

        //private static int GetNextAccountNumber()
        //{
        //    return nextAccountNumber++;
        //}
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

               

      

        

    }
}
