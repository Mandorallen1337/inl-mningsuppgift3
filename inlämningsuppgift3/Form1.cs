using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inlämningsuppgift3
{
    public partial class LoginScreen : Form
    {
        public BankAccountsManager accountsManager;

        private LoggedIn loggedIn;

        public LoginScreen()
        {
            InitializeComponent();
            userLabel.Visible = false;
            accountsManager = new BankAccountsManager();


        }

        public void SetLoggedOutUsername(string username)
        {
            userLabel.Text = $"Logged out user: {username}";
            userLabel.Visible = true;

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = userNameTextBox.Text;
                string password = passwordTextBox.Text;


                BankAccounts loggedInAccount = accountsManager.Login(username, password);

                if (loggedInAccount != null)
                {
                    MessageBox.Show($"Welcome, {loggedInAccount.Username}!");

                    this.loggedIn = new LoggedIn(this, loggedInAccount, loggedInAccount.Username, accountsManager);
                    loggedIn.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            using (CreateAccountForm createAccountForm = new CreateAccountForm(accountsManager))
            {
                createAccountForm.ShowDialog();
            }
        }





    }
}