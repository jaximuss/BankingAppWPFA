using BankingLibrary;

namespace BankingAppWPFA
{
    public partial class Form1 : Form
    {
        UserModel user;
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
            user = GlobalConfig.connection.Login(usernameTextbox.Text, passwordTextbox.Text);

            if (user != null)
            {
                MessageBox.Show("Login Successful");

                Menu menu = new Menu(user); // pass the user object to the menu form
                menu.Show();
                this.Hide();
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

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}