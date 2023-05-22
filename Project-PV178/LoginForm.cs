using Project_PV178.BussinessContext;
using System.Text;
using System.Security.Cryptography;

namespace Project_PV178
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void RegisterLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;
            var rus = await RegisteredUserService.CreateAsync();

            if (!await rus.CheckEmailUniquenessAsync(email))
            {
                var user = await rus.IsPasswordCorrectAsync(email, password);

                if (user != null)
                {
                    var loggedUserForm = await LoggedUserForm.CreateAsync(user, this);
                    loggedUserForm.Closed += (s, args) => this.Close();
                    this.Hide();
                    loggedUserForm.Show();
                }
                else
                {
                    MessageBox.Show(
                        $"Given password does not belong to the account with email {email}.",
                        "Invalid password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    "Given email was not registered!",
                    "Invalid email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}