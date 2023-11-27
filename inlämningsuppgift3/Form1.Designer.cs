namespace inlämningsuppgift3
{
    partial class LoginScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            heading = new Label();
            userNameLabel = new Label();
            passwordLabel = new Label();
            userNameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            LoginButton = new Button();
            userLabel = new Label();
            registerButton = new Button();
            newUserLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            heading.Location = new Point(274, 9);
            heading.Name = "heading";
            heading.Size = new Size(243, 32);
            heading.TabIndex = 0;
            heading.Text = "Welcome to my ATM.";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userNameLabel.ForeColor = SystemColors.ControlText;
            userNameLabel.Location = new Point(224, 344);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(91, 21);
            userNameLabel.TabIndex = 2;
            userNameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            passwordLabel.Location = new Point(225, 378);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(86, 21);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(325, 342);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(239, 23);
            userNameTextBox.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(325, 376);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(239, 23);
            passwordTextBox.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ATM2;
            pictureBox1.Location = new Point(124, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(544, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.DeepSkyBlue;
            LoginButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.Location = new Point(325, 416);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(143, 30);
            LoginButton.TabIndex = 9;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            userLabel.Location = new Point(587, 425);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(175, 21);
            userLabel.TabIndex = 10;
            userLabel.Text = "Logged Out Username";
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.SeaShell;
            registerButton.Location = new Point(24, 402);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(113, 44);
            registerButton.TabIndex = 11;
            registerButton.Text = "Create Account";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // newUserLabel
            // 
            newUserLabel.AutoSize = true;
            newUserLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            newUserLabel.Location = new Point(35, 374);
            newUserLabel.Name = "newUserLabel";
            newUserLabel.Size = new Size(87, 21);
            newUserLabel.TabIndex = 12;
            newUserLabel.Text = "New User?";
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(806, 469);
            Controls.Add(newUserLabel);
            Controls.Add(registerButton);
            Controls.Add(userLabel);
            Controls.Add(LoginButton);
            Controls.Add(pictureBox1);
            Controls.Add(passwordTextBox);
            Controls.Add(userNameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Controls.Add(heading);
            Name = "LoginScreen";
            Text = "ATM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label heading;
        private Label userNameLabel;
        private Label passwordLabel;
        private TextBox userNameTextBox;
        private TextBox passwordTextBox;
        private PictureBox pictureBox1;
        private Button LoginButton;
        private Label userLabel;
        private Button registerButton;
        private Label newUserLabel;
    }
}