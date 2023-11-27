using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlämningsuppgift3
{
    public partial class CreateAccountForm : Form
    {
        private BankAccountsManager accountsManager;
        public CreateAccountForm(BankAccountsManager accountsManager)
        {
            InitializeComponent();
            this.accountsManager = accountsManager;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string username = createUsernameBox.Text;
            string password = createPasswordBox.Text;
            int initialBalance = 0;

            BankAccounts newAccount = accountsManager.CreateAccount(username, password, initialBalance);
            
            MessageBox.Show($"Account created  for {newAccount.Username}");
            this.Close();
        }
    }
}
