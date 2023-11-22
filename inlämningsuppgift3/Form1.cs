using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace inlämningsuppgift3
{
    public partial class LoginScreen : Form
    {
        public BankAccounts bankAccounts;

        private LoggedIn loggedIn;
        
        public LoginScreen()
        {
            InitializeComponent();
            userLabel.Visible = false;
            bankAccounts = new BankAccounts();
            

        }

        public void SetLoggedOutUsername(string username)
        {
            userLabel.Text = $"Logged out user: {username}";
            userLabel.Visible = true;

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text;
            string password = passwordTextBox.Text;

            
            BankAccounts loggedInAccount = bankAccounts.Login(username, password);

            if (loggedInAccount != null)
            {
                MessageBox.Show($"Welcome, {loggedInAccount.Username}!");

                this.loggedIn = new LoggedIn(this, loggedInAccount, loggedInAccount.Username);
                loggedIn.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}