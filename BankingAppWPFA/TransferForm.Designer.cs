namespace BankingAppWPFA
{
    partial class TransferForm
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
            textBox1 = new TextBox();
            label2 = new Label();
            amountTransferTextbox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 42);
            label1.Name = "label1";
            label1.Size = new Size(193, 45);
            label1.TabIndex = 0;
            label1.Text = "Account Number";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(263, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(119, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 121);
            label2.Name = "label2";
            label2.Size = new Size(144, 46);
            label2.TabIndex = 2;
            label2.Text = "Amount";
            // 
            // amountTransferTextbox
            // 
            amountTransferTextbox.Location = new Point(263, 121);
            amountTransferTextbox.Name = "amountTransferTextbox";
            amountTransferTextbox.Size = new Size(119, 23);
            amountTransferTextbox.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(196, 218);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Transfer";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TransferForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 314);
            Controls.Add(button1);
            Controls.Add(amountTransferTextbox);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "TransferForm";
            Text = "TransferForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox amountTransferTextbox;
        private Button button1;
    }
}