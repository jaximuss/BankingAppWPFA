using BankingLibrary;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingAppWPFA
{
    public partial class Menu : Form
    {
        public UserModel userModel;

        public Menu(UserModel user)
        {
            userModel = user;
            InitializeComponent();
        }

        private void balanceButton_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void accountMenuNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{userModel.Money}");
        }

        private void Menu_Load_1(object sender, EventArgs e)
        {
            accountMenuNameLabel.Text = userModel.UserName;
            balanceMenuNameLabel.Text = userModel.Money.ToString("C");
        }
    }
}
