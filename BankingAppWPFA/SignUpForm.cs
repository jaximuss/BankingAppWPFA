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
    
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserModel userModel = new UserModel(firstNameTextbox.Text,LastNameTextbox.Text,emailTextbox.Text,passwordTextbox.Text,usernameTextBox.Text);
           
            GlobalConfig.connection.CreateUser(userModel);

        }
    }
}
