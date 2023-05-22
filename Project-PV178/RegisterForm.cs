using Project_PV178.BussinessContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_PV178
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void RegisterButton_Click(object sender, EventArgs e)
        {
            var rus = await RegisteredUserService.CreateAsync();
            var valid = true;

            if (!rus.CheckEmailValidation(emailTextBox.Text))
            {
                valid = false;
                MessageBox.Show(
                    "Given email is not valid! Try again.",
                    "Invalid email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            if (!await rus.CheckEmailUniquenessAsync(emailTextBox.Text))
            {
                valid = false;
                MessageBox.Show(
                    "Given email is already used with another account! Try a new one.",
                    "Non-unique email",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            if (passwordTextBox.Text.Length < 6)
            {
                valid = false;
                MessageBox.Show(
                    "Password has to have at least 6 characters! Enter BOTH again.",
                    "Short password",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                if (!passwordTextBox.Text.Equals(passwordAgainTextBox.Text))
                {
                    valid = false;
                    MessageBox.Show(
                        "Passwords are not equal! Enter BOTH again.",
                        "Non-equal passwords",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }

            if (nameTextBox.Text.Length == 0 || surnameTextBox.Text.Length == 0)
            {
                valid = false;
                MessageBox.Show(
                    "Name and surname MUST be entered.",
                    "Missing name and (or) surname",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                if (char.IsLower(nameTextBox.Text[0]) || char.IsLower(surnameTextBox.Text[0]))
                {
                    valid = false;
                    MessageBox.Show(
                        "Name and surname MUST start wich an uppercase letter.",
                        "Name and (or) surname start witch lowercase letter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }

            if (!superuserButton.Checked && !regularUserButton.Checked)
            {
                valid = false;
                MessageBox.Show(
                    "You have to choose wether user is regular or superuser.",
                    "Missing user type",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            if (valid)
            {
                await rus.RegisterNewUserAsync(emailTextBox.Text, passwordTextBox.Text, nameTextBox.Text,
                    surnameTextBox.Text, superuserButton.Checked);
                MessageBox.Show($"New user {nameTextBox.Text} {surnameTextBox.Text} has been registered.");
                this.Close();
            }
        }
    }
}
