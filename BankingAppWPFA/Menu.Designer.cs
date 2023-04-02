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
            depositButton = new Button();
            traansferButton = new Button();
            topUpButton = new Button();
            balanceButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Perpetua Titling MT", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(184, 9);
            label1.Name = "label1";
            label1.Size = new Size(390, 64);
            label1.TabIndex = 0;
            label1.Text = "MONARCH BANK";
            // 
            // depositButton
            // 
            depositButton.Location = new Point(452, 169);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(153, 131);
            depositButton.TabIndex = 1;
            depositButton.Text = "DEPOSIT";
            depositButton.UseVisualStyleBackColor = true;
            // 
            // traansferButton
            // 
            traansferButton.Location = new Point(155, 169);
            traansferButton.Name = "traansferButton";
            traansferButton.Size = new Size(153, 131);
            traansferButton.TabIndex = 2;
            traansferButton.Text = "TRANSFER";
            traansferButton.UseVisualStyleBackColor = true;
            // 
            // topUpButton
            // 
            topUpButton.Location = new Point(155, 384);
            topUpButton.Name = "topUpButton";
            topUpButton.Size = new Size(153, 131);
            topUpButton.TabIndex = 3;
            topUpButton.Text = "MOBILE TOP-UP";
            topUpButton.UseVisualStyleBackColor = true;
            // 
            // balanceButton
            // 
            balanceButton.Location = new Point(452, 384);
            balanceButton.Name = "balanceButton";
            balanceButton.Size = new Size(153, 131);
            balanceButton.TabIndex = 4;
            balanceButton.Text = "CHECK BALANCE";
            balanceButton.UseVisualStyleBackColor = true;
            balanceButton.Click += balanceButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(752, 679);
            Controls.Add(balanceButton);
            Controls.Add(topUpButton);
            Controls.Add(traansferButton);
            Controls.Add(depositButton);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button depositButton;
        private Button traansferButton;
        private Button topUpButton;
        private Button balanceButton;
    }
}