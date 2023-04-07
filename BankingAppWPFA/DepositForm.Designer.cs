namespace BankingAppWPFA
{
    partial class DepositForm
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
            AmountDepositLabel = new Label();
            DepositTextbox = new TextBox();
            DepositButton = new Button();
            SuspendLayout();
            // 
            // AmountDepositLabel
            // 
            AmountDepositLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AmountDepositLabel.Location = new Point(43, 77);
            AmountDepositLabel.Name = "AmountDepositLabel";
            AmountDepositLabel.Size = new Size(108, 20);
            AmountDepositLabel.TabIndex = 0;
            AmountDepositLabel.Text = "Amount";
            // 
            // DepositTextbox
            // 
            DepositTextbox.Location = new Point(185, 74);
            DepositTextbox.Name = "DepositTextbox";
            DepositTextbox.Size = new Size(215, 23);
            DepositTextbox.TabIndex = 1;
            DepositTextbox.TextChanged += DepositTextbox_TextChanged;
            // 
            // DepositButton
            // 
            DepositButton.Location = new Point(176, 157);
            DepositButton.Name = "DepositButton";
            DepositButton.Size = new Size(75, 23);
            DepositButton.TabIndex = 2;
            DepositButton.Text = "Deposit";
            DepositButton.UseVisualStyleBackColor = true;
            DepositButton.Click += DepositButton_Click;
            // 
            // DepositForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 261);
            Controls.Add(DepositButton);
            Controls.Add(DepositTextbox);
            Controls.Add(AmountDepositLabel);
            Name = "DepositForm";
            Text = "DepositForm";
            Load += DepositForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AmountDepositLabel;
        private TextBox DepositTextbox;
        private Button DepositButton;
    }
}