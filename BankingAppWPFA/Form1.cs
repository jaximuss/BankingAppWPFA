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
            // Load the user data from the file
            List<UserModel> users = TextConnectorProcessor.FullFilePath("users.csv").LoadFile().ConvertToUserModel();

            // Get the username and password from the input fields
            string username = usernameTextbox.Text;
            string password = passwordTextbox.Text;

            // Find the user with matching credentials
            UserModel user = users.FirstOrDefault(u => u.UserName == username && u.Password == password);

            // If a user is found, display a welcome message and close the form
            if (user != null)
            {
                MessageBox.Show($"Welcome back, {user.FirstName} {user.LastName}!");
                this.Close();
            }
            // Otherwise, display an error message
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
        private void signUp_Click(object sender, EventArgs e)
        {
            SignUpForm signup = new SignUpForm();

            signup.Show();
        }
    }
}