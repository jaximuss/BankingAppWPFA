using BankingLibrary;
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
        public Menu()
        {
            InitializeComponent();
        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel();
            MessageBox.Show("Your balance is: " + GlobalConfig.connection.CheckBalance(user));
        }
    }
}
