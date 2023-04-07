namespace BankingAppWPFA
{
    partial class Form1
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
            NameLabel = new Label();
            PasswordLabel = new Label();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            logInButton = new Button();
            signUp = new Button();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(70, 124);
            NameLabel.MaximumSize = new Size(500, 500);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(60, 15);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Username";
            NameLabel.Click += label1_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(70, 206);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(57, 15);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Location = new Point(191, 124);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(168, 23);
            usernameTextbox.TabIndex = 2;
            usernameTextbox.TextChanged += usernameTextbox_TextChanged;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(191, 198);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(168, 23);
            passwordTextbox.TabIndex = 3;
            // 
            // logInButton
            // 
            logInButton.Location = new Point(146, 310);
            logInButton.Name = "logInButton";
            logInButton.Size = new Size(175, 33);
            logInButton.TabIndex = 4;
            logInButton.Text = "Log in";
            logInButton.UseVisualStyleBackColor = true;
            logInButton.Click += logInButton_Click;
            // 
            // signUp
            // 
            signUp.Location = new Point(146, 382);
            signUp.Name = "signUp";
            signUp.Size = new Size(175, 33);
            signUp.TabIndex = 5;
            signUp.Text = "Sign Up";
            signUp.UseVisualStyleBackColor = true;
            signUp.Click += signUp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 549);
            Controls.Add(signUp);
            Controls.Add(logInButton);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameTextbox);
            Controls.Add(PasswordLabel);
            Controls.Add(NameLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label PasswordLabel;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Button logInButton;
        private Button signUp;
    }
}