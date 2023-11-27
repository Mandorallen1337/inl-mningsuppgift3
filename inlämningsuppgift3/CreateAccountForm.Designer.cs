namespace inlämningsuppgift3
{
    partial class CreateAccountForm
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
            label1 = new Label();
            createUsernameBox = new TextBox();
            createPasswordBox = new TextBox();
            createPasswordLabel = new Label();
            createButton = new Button();
            enterLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 70);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // createUsernameBox
            // 
            createUsernameBox.Location = new Point(149, 72);
            createUsernameBox.Name = "createUsernameBox";
            createUsernameBox.Size = new Size(128, 23);
            createUsernameBox.TabIndex = 1;
            // 
            // createPasswordBox
            // 
            createPasswordBox.Location = new Point(149, 105);
            createPasswordBox.Name = "createPasswordBox";
            createPasswordBox.Size = new Size(128, 23);
            createPasswordBox.TabIndex = 3;
            // 
            // createPasswordLabel
            // 
            createPasswordLabel.AutoSize = true;
            createPasswordLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createPasswordLabel.Location = new Point(49, 103);
            createPasswordLabel.Name = "createPasswordLabel";
            createPasswordLabel.Size = new Size(79, 21);
            createPasswordLabel.TabIndex = 2;
            createPasswordLabel.Text = "Password";
            // 
            // createButton
            // 
            createButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            createButton.Location = new Point(149, 155);
            createButton.Name = "createButton";
            createButton.Size = new Size(100, 32);
            createButton.TabIndex = 4;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // enterLabel
            // 
            enterLabel.AutoSize = true;
            enterLabel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            enterLabel.Location = new Point(49, 24);
            enterLabel.Name = "enterLabel";
            enterLabel.Size = new Size(228, 21);
            enterLabel.TabIndex = 5;
            enterLabel.Text = "Enter username and password";
            // 
            // CreateAccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(297, 210);
            Controls.Add(enterLabel);
            Controls.Add(createButton);
            Controls.Add(createPasswordBox);
            Controls.Add(createPasswordLabel);
            Controls.Add(createUsernameBox);
            Controls.Add(label1);
            Name = "CreateAccountForm";
            Text = "CreateAccountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox createUsernameBox;
        private TextBox createPasswordBox;
        private Label createPasswordLabel;
        private Button createButton;
        private Label enterLabel;
    }
}