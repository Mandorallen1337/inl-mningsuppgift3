namespace inlämningsuppgift3
{
    partial class LoggedIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DepositLabel = new Label();
            DepositButton = new Button();
            WithdrawLabel = new Label();
            CheckBalanceLabel = new Label();
            WithdrawButton = new Button();
            LogoutButton = new Button();
            balanceLabel = new Label();
            withdrawAmountTextBox = new TextBox();
            transactionListBox = new ListBox();
            depositAmountTextBox = new TextBox();
            SuspendLayout();
            // 
            // DepositLabel
            // 
            DepositLabel.AutoSize = true;
            DepositLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DepositLabel.Location = new Point(28, 40);
            DepositLabel.Name = "DepositLabel";
            DepositLabel.Size = new Size(116, 21);
            DepositLabel.TabIndex = 0;
            DepositLabel.Text = "Deposit funds:";
            // 
            // DepositButton
            // 
            DepositButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DepositButton.Location = new Point(311, 36);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(99, 29);
            DepositButton.TabIndex = 1;
            DepositButton.Text = "Deposit";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // WithdrawLabel
            // 
            WithdrawLabel.AutoSize = true;
            WithdrawLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            WithdrawLabel.Location = new Point(28, 82);
            WithdrawLabel.Name = "WithdrawLabel";
            WithdrawLabel.Size = new Size(129, 21);
            WithdrawLabel.TabIndex = 2;
            WithdrawLabel.Text = "Withdraw funds:";
            // 
            // CheckBalanceLabel
            // 
            CheckBalanceLabel.AutoSize = true;
            CheckBalanceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CheckBalanceLabel.Location = new Point(28, 132);
            CheckBalanceLabel.Name = "CheckBalanceLabel";
            CheckBalanceLabel.Size = new Size(129, 21);
            CheckBalanceLabel.TabIndex = 4;
            CheckBalanceLabel.Text = "Current Balance:";
            // 
            // WithdrawButton
            // 
            WithdrawButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            WithdrawButton.Location = new Point(311, 76);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(99, 33);
            WithdrawButton.TabIndex = 3;
            WithdrawButton.Text = "Withdraw";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LogoutButton.Location = new Point(666, 381);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(106, 46);
            LogoutButton.TabIndex = 6;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // balanceLabel
            // 
            balanceLabel.AutoSize = true;
            balanceLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            balanceLabel.Location = new Point(181, 132);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(66, 21);
            balanceLabel.TabIndex = 7;
            balanceLabel.Text = "Balance";
            // 
            // withdrawAmountTextBox
            // 
            withdrawAmountTextBox.Location = new Point(181, 84);
            withdrawAmountTextBox.Name = "withdrawAmountTextBox";
            withdrawAmountTextBox.Size = new Size(100, 23);
            withdrawAmountTextBox.TabIndex = 8;
            // 
            // transactionListBox
            // 
            transactionListBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            transactionListBox.FormattingEnabled = true;
            transactionListBox.ItemHeight = 21;
            transactionListBox.Location = new Point(483, 40);
            transactionListBox.Name = "transactionListBox";
            transactionListBox.Size = new Size(247, 298);
            transactionListBox.TabIndex = 9;
            // 
            // depositAmountTextBox
            // 
            depositAmountTextBox.Location = new Point(181, 42);
            depositAmountTextBox.Name = "depositAmountTextBox";
            depositAmountTextBox.Size = new Size(100, 23);
            depositAmountTextBox.TabIndex = 10;
            // 
            // LoggedIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(depositAmountTextBox);
            Controls.Add(transactionListBox);
            Controls.Add(withdrawAmountTextBox);
            Controls.Add(balanceLabel);
            Controls.Add(LogoutButton);
            Controls.Add(CheckBalanceLabel);
            Controls.Add(WithdrawButton);
            Controls.Add(WithdrawLabel);
            Controls.Add(DepositButton);
            Controls.Add(DepositLabel);
            Name = "LoggedIn";
            Text = "LoggedIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DepositLabel;
        private Button DepositButton;
        private Label WithdrawLabel;
        private Label CheckBalanceLabel;
        private Button WithdrawButton;
        private Button LogoutButton;
        private Label balanceLabel;
        private TextBox withdrawAmountTextBox;
        private ListBox transactionListBox;
        private TextBox depositAmountTextBox;
    }
}