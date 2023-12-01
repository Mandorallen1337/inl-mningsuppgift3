using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace inlämningsuppgift3
{
    public class BankAccountsManager
    {
        
        
        private List<BankAccounts> accounts;

        public BankAccountsManager()
        {
            accounts = new List<BankAccounts>();
            LoadFromFile("accounts.csv");
        }

        public BankAccounts CreateAccount(string username, string password, int balance = 0)
        {
            try
            {
                if(accounts.Any(accounts => accounts.Username == username))
                {
                    MessageBox.Show("An account with the same username already exists");
                    return null;
                }

                BankAccounts newAccount = new BankAccounts(username, password, balance);
                accounts.Add(newAccount);
                //SaveToFile("accounts.csv");

                return newAccount;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error creating account: {ex.Message}");
                return null;
            }
        }

        public void DeleteAccount(string username, LoggedIn loggedInInstance)
        {
            // Find and remove the account with the specified username
            BankAccounts accountToRemove = accounts.FirstOrDefault(account => account.Username == username);

            if (accountToRemove != null)
            {
                if (accountToRemove == loggedInInstance.LoggedInAccount)
                {
                    loggedInInstance.LoggedInAccount = null;
                    loggedInInstance.LoggedInUsername = null;
                }
                
                accounts.Remove(accountToRemove);
                SaveToFile("accounts.csv");
                MessageBox.Show($"Account with username '{username}' deleted successfully. Have a nice day.");
            }
            else
            {
                MessageBox.Show($"Account with username '{username}' not found.");
            }
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

        public void SaveToFile(string fileName)
        {
            File.WriteAllText(fileName, string.Empty);
            HashSet<string> uniqueAccounts = new HashSet<string>();
            //Hashset for uniqueness
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                foreach (var account in accounts)
                {
                    if(account != null)
                    {
                        string accountInfo = $"{account.Username},{account.Password},{account.Balance}";
                        if (uniqueAccounts.Add(accountInfo))
                        {
                            sw.WriteLine(accountInfo);
                        }
                        
                    }
                                                             
                }
            }
        }
        

        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                //add csv to List
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] accountData = sr.ReadLine().Split(',');
                        if (accountData.Length == 3)
                        {
                            string username = accountData[0];
                            string password = accountData[1];
                            int balance = int.Parse(accountData[2]);
                            accounts.Add(CreateAccount(username, password, balance));
                            

                        }
                    }
                }
            }
        }
      


    }
}
