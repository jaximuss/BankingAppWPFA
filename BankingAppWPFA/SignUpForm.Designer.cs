namespace BankingAppWPFA
{
    partial class SignUpForm
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
            FirstNameLabel = new Label();
            LastNameLabel = new Label();
            emailLabel = new Label();
            label4 = new Label();
            userNameLabel = new Label();
            firstNameTextbox = new TextBox();
            LastNameTextbox = new TextBox();
            emailTextbox = new TextBox();
            passwordTextbox = new TextBox();
            usernameTextBox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(138, 90);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(138, 162);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(138, 228);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(36, 15);
            emailLabel.TabIndex = 2;
            emailLabel.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 296);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(138, 374);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(59, 15);
            userNameLabel.TabIndex = 4;
            userNameLabel.Text = "username";
            // 
            // firstNameTextbox
            // 
            firstNameTextbox.Location = new Point(276, 82);
            firstNameTextbox.Name = "firstNameTextbox";
            firstNameTextbox.Size = new Size(100, 23);
            firstNameTextbox.TabIndex = 5;
            // 
            // LastNameTextbox
            // 
            LastNameTextbox.Location = new Point(276, 162);
            LastNameTextbox.Name = "LastNameTextbox";
            LastNameTextbox.Size = new Size(100, 23);
            LastNameTextbox.TabIndex = 6;
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(276, 228);
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(100, 23);
            emailTextbox.TabIndex = 7;
            // 
            // passwordTextbox
            // 
            passwordTextbox.Location = new Point(276, 288);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(100, 23);
            passwordTextbox.TabIndex = 8;
            passwordTextbox.TextChanged += textBox4_TextChanged;
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(276, 366);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(316, 467);
            button1.Name = "button1";
            button1.Size = new Size(126, 37);
            button1.TabIndex = 10;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 698);
            Controls.Add(button1);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordTextbox);
            Controls.Add(emailTextbox);
            Controls.Add(LastNameTextbox);
            Controls.Add(firstNameTextbox);
            Controls.Add(userNameLabel);
            Controls.Add(label4);
            Controls.Add(emailLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(FirstNameLabel);
            Name = "SignUpForm";
            Text = "SignUpForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstNameLabel;
        private Label LastNameLabel;
        private Label emailLabel;
        private Label label4;
        private Label userNameLabel;
        private TextBox firstNameTextbox;
        private TextBox LastNameTextbox;
        private TextBox emailTextbox;
        private TextBox passwordTextbox;
        private TextBox usernameTextBox;
        private Button button1;
    }
}