namespace BankingAppWPFA
{
    partial class Menu
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
            traansferButton = new Button();
            WelcomeLabel = new Label();
            accountMenuNameLabel = new Label();
            BalanceLabel = new Label();
            balanceMenuNameLabel = new Label();
            label6 = new Label();
            depositButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(390, 64);
            label1.TabIndex = 0;
            label1.Text = "MONARCH BANK";
            // 
            // traansferButton
            // 
            traansferButton.Location = new Point(77, 369);
            traansferButton.Name = "traansferButton";
            traansferButton.Size = new Size(153, 131);
            traansferButton.TabIndex = 2;
            traansferButton.Text = "TRANSFER";
            traansferButton.UseVisualStyleBackColor = true;
            traansferButton.Click += traansferButton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            WelcomeLabel.Location = new Point(62, 92);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(168, 45);
            WelcomeLabel.TabIndex = 5;
            WelcomeLabel.Text = "Welcome";
            // 
            // accountMenuNameLabel
            // 
            accountMenuNameLabel.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            accountMenuNameLabel.Location = new Point(295, 92);
            accountMenuNameLabel.Name = "accountMenuNameLabel";
            accountMenuNameLabel.Size = new Size(294, 31);
            accountMenuNameLabel.TabIndex = 6;
            accountMenuNameLabel.Text = "accountMenuName";
            accountMenuNameLabel.Click += accountMenuNameLabel_Click;
            // 
            // BalanceLabel
            // 
            BalanceLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BalanceLabel.Location = new Point(62, 179);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(168, 45);
            BalanceLabel.TabIndex = 7;
            BalanceLabel.Text = "Balance";
            BalanceLabel.Click += label4_Click;
            // 
            // balanceMenuNameLabel
            // 
            balanceMenuNameLabel.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Italic, GraphicsUnit.Point);
            balanceMenuNameLabel.Location = new Point(295, 179);
            balanceMenuNameLabel.Name = "balanceMenuNameLabel";
            balanceMenuNameLabel.Size = new Size(168, 45);
            balanceMenuNameLabel.TabIndex = 8;
            balanceMenuNameLabel.Text = "balanceMenuName";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 58);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 9;
            label6.Click += label6_Click;
            // 
            // depositButton
            // 
            depositButton.Location = new Point(387, 369);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(153, 131);
            depositButton.TabIndex = 1;
            depositButton.Text = "DEPOSIT";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(664, 623);
            Controls.Add(label6);
            Controls.Add(balanceMenuNameLabel);
            Controls.Add(BalanceLabel);
            Controls.Add(accountMenuNameLabel);
            Controls.Add(WelcomeLabel);
            Controls.Add(traansferButton);
            Controls.Add(depositButton);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button traansferButton;
        private Label WelcomeLabel;
        private Label accountMenuNameLabel;
        private Label BalanceLabel;
        private Label balanceMenuNameLabel;
        private Label label6;
        private Button depositButton;
    }
}