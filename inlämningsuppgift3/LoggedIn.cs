using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace inlämningsuppgift3
{
    public partial class LoggedIn : Form
    {
        private LoginScreen loginScreen;

        private string loggedInUsername;

        private BankAccounts loggedInAccount;

        private BankAccountsManager accountsManager;
        public BankAccounts LoggedInAccount
    {
        get { return loggedInAccount; }
        set { loggedInAccount = value; }
    }

    public string LoggedInUsername
    {
        get { return loggedInUsername; }
        set { loggedInUsername = value; }
    }




        public LoggedIn(LoginScreen loginScreen, BankAccounts loggedInAccount, string loggedInUsername, BankAccountsManager accountsManager)
        {
            InitializeComponent();
            this.loginScreen = loginScreen;
            this.loggedInAccount = loggedInAccount;
            this.loggedInUsername = loggedInUsername;
            this.accountsManager = accountsManager;

            //accountsManager.LoadFromFile("accounts.csv");

            DisplayBalance();
        }




        public void UpdateBalanceAfterWithdrawal(int withdrawalAmount)
        {
            // Update the balance in the bankAccounts object
            if (loggedInAccount.Withdraw(withdrawalAmount))
            {
                MessageBox.Show($"Withdrawal of {withdrawalAmount} successful!");
                transactionListBox.Items.Add("- " + withdrawalAmount);
                withdrawAmountTextBox.Text = string.Empty;
                // Update the displayed balance
                DisplayBalance();
            }
            else
            {
                MessageBox.Show("Insufficient funds or invalid withdrawal amount.");
            }
        }

        public void UpdateBalanceAfterDeposit(int depositAmount)
        {

            if (loggedInAccount.Deposit(depositAmount))
            {
                MessageBox.Show($"Deposit of {depositAmount} successful!");
                transactionListBox.Items.Add("+ " + depositAmount);

                depositAmountTextBox.Text = string.Empty;

                DisplayBalance();
            }
            else
            {
                MessageBox.Show("Invalid entry.");
            }
        }


        public void DisplayBalance()
        {
            int balance = accountsManager.ViewBalance(loggedInUsername);
            balanceLabel.Text = $"{balance}";
        }




        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loginScreen.Show();
            loginScreen.SetLoggedOutUsername(loggedInUsername);
            accountsManager.SaveToFile("accounts.csv");

        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(withdrawAmountTextBox.Text, out int withdrawalAmount))
            {
                if (withdrawalAmount <= 0)
                {
                    MessageBox.Show("Please enter positive amount.");
                    return;
                }
                // Call the UpdateBalanceAfterWithdrawal method
                UpdateBalanceAfterWithdrawal(withdrawalAmount);
                DisplayBalance();
            }
            else
            {
                MessageBox.Show("Invalid withdrawal amount. Please enter a valid number.");
            }

        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(depositAmountTextBox.Text, out int depositAmount))
            {
                if (depositAmount <= 0)
                {
                    MessageBox.Show("Please enter positive amount.");
                    return;
                }
                // Call the UpdateBalanceAfterWithdrawal method
                UpdateBalanceAfterDeposit(depositAmount);
                DisplayBalance();
            }
            else
            {
                MessageBox.Show("Invalid entry.");
            }

        }

        public void DeleteLoggedInAccount()
        {
            accountsManager.DeleteAccount(loggedInUsername, this);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete your account?", "Delete Account Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DeleteLoggedInAccount();
                //this.Close();
                //loginScreen.Show();
                //loginScreen.SetLoggedOutUsername(loggedInUsername);
                Application.Exit();
            }
        }
        

    }
}

