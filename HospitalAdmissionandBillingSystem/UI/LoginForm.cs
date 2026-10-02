using System;
using System.Windows.Forms;
using BusinessLogic.Repository;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            txtPassword.UseSystemPasswordChar = true;

            button1.Click -= button1_Click;
            button1.Click += button1_Click;

            btnShow.Click -= btnShow_Click;
            btnShow.Click += btnShow_Click;
        }

        private void button1_Click(
            object sender,
            EventArgs e)
        {
            try
            {
                string username =
                    txtUsername.Text.Trim();

                string password =
                    txtPassword.Text;

                if (username == "" ||
                    password == "")
                {
                    MessageBox.Show(
                        "Please enter username and password.",
                        "Login",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                UserRepository repository =
                    new UserRepository();

                string role =
                    repository.Login(
                        username,
                        password);

                if (role == "")
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "Login Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                MessageBox.Show(
                    "Login successful!",
                    "Welcome",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LandingPage landingPage =
                    new LandingPage();

                landingPage.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Database connection error:\n\n" +
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnShow_Click(
            object sender,
            EventArgs e)
        {
            txtPassword.UseSystemPasswordChar =
                !txtPassword.UseSystemPasswordChar;
        }
    }
}