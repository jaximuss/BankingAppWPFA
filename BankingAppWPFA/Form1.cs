using BankingLibrary;

namespace BankingAppWPFA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            UserModel user = GlobalConfig.connection.Login(usernameTextbox.Text, passwordTextbox.Text);

            if (user != null)
            {
                MessageBox.Show("Login Successful");

                Menu menu = new Menu();
                menu.Show();
            }
            else
            {
                // Display an error message indicating invalid login credentials
                MessageBox.Show("Login failed");

            }
        }
        private void signUp_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();

            signup.Show();
        }

    }
}