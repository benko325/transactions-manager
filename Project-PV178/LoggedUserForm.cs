using Project_PV178.BussinessContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Project_PV178
{
    public partial class LoggedUserForm : Form
    {
        private static TransactionService _transactionService;
        private static RegisteredUserService _registeredUserService;
        private RegisteredUser _user;
        private Form _mainForm;

        public static async Task<LoggedUserForm> CreateAsync(RegisteredUser user, Form mainForm)
        {
            var form = new LoggedUserForm(user, mainForm);
            _transactionService = await TransactionService.CreateAsync();
            _registeredUserService = await RegisteredUserService.CreateAsync();
            return form;
        }
        private LoggedUserForm(RegisteredUser user, Form mainForm)
        {
            InitializeComponent();
            _user = user;
            signedUserLabel.Text += $" {user.Name} {user.Surname}";
            actionsPanel.Visible = true;
            if (!user.IsSuperuser)
            {
                showAllTransactionsButton.Enabled = false;
            }
            addTransactionPanel.Visible = false;
            showTransactionsPanel.Visible = false;
            transactionsDataPanel.Visible = false;
            editProfilePanel.Visible = false;
            _mainForm = mainForm;
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            actionsPanel.Visible = false;
            var chosen = false;

            if (addExpenseButton.Checked || addIncomeButton.Checked)
            {
                chosen = true;
                addTransactionPanel.Visible = true;

                if (addExpenseButton.Checked)
                {
                    expenseButton.Checked = true;
                }
                else
                {
                    incomeButton.Checked = true;
                }
            }

            if (showMyIncomesButton.Checked || showMyExpensesButton.Checked ||
                showMyTransactionsButton.Checked || showAllTransactionsButton.Checked)
            {
                chosen = true;
                showTransactionsPanel.Visible = true;

                if (showMyIncomesButton.Checked)
                {
                    incomeFilterButton.Checked = true;
                }
                if (showMyExpensesButton.Checked)
                {
                    expenseFilterButton.Checked = true;
                }
                if (showMyTransactionsButton.Checked || showAllTransactionsButton.Checked)
                {
                    allFilterButton.Checked = true;
                }
            }

            if (!chosen)
            {
                actionsPanel.Visible = true;
                MessageBox.Show(
                    "You have to choose type of action.",
                    "No type chosen",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void amountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _transactionService.CheckOnlyNumbericButtonsKeyPress(sender, e);
        }

        private async void addTransactionButton_Click(object sender, EventArgs e)
        {
            var valid = true;
            decimal amount = 0;
            if (amountTextBox.Text.Length == 0)
            {
                valid = false;
                MessageBox.Show(
                    "You have to type amount of the transaction.",
                    "Empty amount",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            {
                amount = decimal.Parse(amountTextBox.Text, CultureInfo.InvariantCulture);
                if (amount <= 0)
                {
                    valid = false;
                    MessageBox.Show(
                        "Amount has to be greater than 0.",
                        "Invalid value",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }

            if (descriptionTextBox.Text.Length == 0)
            {
                valid = false;
                MessageBox.Show(
                    "Description can not be empty.",
                    "Empty description",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            if (valid)
            {
                await _transactionService.AddNewTransactionAsync(incomeButton.Checked, amount,
                    descriptionTextBox.Text, dateTimePicker.Value.Date, _user.Id);
                MessageBox.Show("New transaction has been added.");
                amountTextBox.Text = "";
                descriptionTextBox.Text = "";
                dateTimePicker.Value = DateTime.Now.Date;
                actionsPanel.Visible = true;
                addTransactionPanel.Visible = false;
            }
        }

        private void minAmountTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _transactionService.CheckOnlyNumbericButtonsKeyPress(sender, e);
        }

        private void maxValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            _transactionService.CheckOnlyNumbericButtonsKeyPress(sender, e);
        }

        private async void findTransactionsButton_Click(object sender, EventArgs e)
        {
            var expenses = false;
            var incomes = false;

            if (allFilterButton.Checked)
            {
                expenses = true;
                incomes = true;
            }
            if (expenseFilterButton.Checked)
            {
                expenses = true;
            }
            if (incomeFilterButton.Checked)
            {
                incomes = true;
            }

            var minValue = decimal.MinValue;
            var maxValue = decimal.MaxValue;
            if (minAmountTextBox.Text.Length > 0)
            {
                minValue = decimal.Parse(minAmountTextBox.Text, CultureInfo.InvariantCulture);
            }
            if (maxAmountTextBox.Text.Length > 0)
            {
                maxValue = decimal.Parse(maxAmountTextBox.Text, CultureInfo.InvariantCulture);
            }

            showTransactionsPanel.Visible = false;
            transactionsDataPanel.Visible = true;

            List<BussinessContext.Transaction> transactions;
            if (showAllTransactionsButton.Checked)
            {
                transactions = await _transactionService.FindTransactionsAsync(0, expenses, incomes, minValue, maxValue,
                descriptionContainsTextBox.Text, minDateTimePicker.Value.Date, maxDateTimePicker.Value.Date);
            }
            else
            {
                transactions = await _transactionService.FindTransactionsAsync(_user.Id, expenses, incomes, minValue, maxValue,
                descriptionContainsTextBox.Text, minDateTimePicker.Value.Date, maxDateTimePicker.Value.Date);
            }

            var summary = await _transactionService.GetSummaryAsync(transactions);
            sumLabel.Text += summary.ToString();

            transactionDataGridView.DataSource = transactions;
            transactionDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            transactionDataGridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            transactionDataGridView.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

        private void closeTransactionsButton_Click(object sender, EventArgs e)
        {
            transactionsDataPanel.Visible = false;
            showTransactionsPanel.Visible = true;
            sumLabel.Text = "Sum: ";
        }

        private void backFilterButton_Click(object sender, EventArgs e)
        {
            minDateTimePicker.Value = DateTimePicker.MinimumDateTime;
            maxDateTimePicker.Value = DateTimePicker.MaximumDateTime;
            descriptionContainsTextBox.Text = "";
            minAmountTextBox.Text = "";
            maxAmountTextBox.Text = "";
            showTransactionsPanel.Visible = false;
            actionsPanel.Visible = true;
        }

        private void addTransactionBackButton_Click(object sender, EventArgs e)
        {
            addTransactionPanel.Visible = false;
            actionsPanel.Visible = true;
        }

        private void logoutLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            _mainForm.Show();
        }

        private void editProfileLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addTransactionPanel.Visible = false;
            showTransactionsPanel.Visible = false;
            transactionsDataPanel.Visible = false;
            actionsPanel.Visible = false;
            editProfilePanel.Visible = true;
        }

        private void backEditProfileButton_Click(object sender, EventArgs e)
        {
            newEmailTextBox.Text = "";
            newNameTextBox.Text = "";
            newSurnameTextBox.Text = "";
            oldPasswordTextBox.Text = "";
            newPasswordTextBox.Text = "";
            newPasswordAgainTextBox.Text = "";
            editProfilePanel.Visible = false;
            actionsPanel.Visible = true;
        }

        private async void editProfileButton_Click(object sender, EventArgs e)
        {
            var valid = true;

            if (newEmailTextBox.Text.Length > 0)
            {
                if (!_registeredUserService.CheckEmailValidation(newEmailTextBox.Text))
                {
                    valid = false;
                    MessageBox.Show(
                        "Given email is not valid! Try again.",
                        "Invalid email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }

                if (!await _registeredUserService.CheckEmailUniquenessAsync(newEmailTextBox.Text))
                {
                    valid = false;
                    MessageBox.Show(
                        "Given email is already used with another account! Try a new one.",
                        "Non-unique email",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }

            if (newNameTextBox.Text.Length > 0)
            {
                if (char.IsLower(newNameTextBox.Text[0]))
                {
                    valid = false;
                    MessageBox.Show(
                        "Name MUST start wich an uppercase letter.",
                        "Name starts witch lowercase letter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }

            if (newSurnameTextBox.Text.Length > 0)
            {
                if (char.IsLower(newSurnameTextBox.Text[0]))
                {
                    valid = false;
                    MessageBox.Show(
                        "Surname MUST start wich an uppercase letter.",
                        "Surname starts witch lowercase letter",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
            }

            // maybe too many ifs, but I do not know how to do it better
            if (oldPasswordTextBox.Text.Length > 0)
            {
                SHA256 sha256 = SHA256.Create();
                byte[] oldHashedPassword = sha256.ComputeHash(Encoding.UTF8.GetBytes(oldPasswordTextBox.Text));

                bool areEqual = false;
                if (oldHashedPassword.Length == _user.PasswordHash.Length)
                {
                    int i = 0;
                    while ((i < oldHashedPassword.Length) && (oldHashedPassword[i] == _user.PasswordHash[i]))
                    {
                        i++;
                    }

                    if (i == oldHashedPassword.Length)
                    {
                        areEqual = true;
                    }
                }

                if (!areEqual)
                {
                    valid = false;
                    MessageBox.Show(
                        "Given password does not belong to the signed in account.",
                        "Invalid password",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                }
                else
                {
                    if (newPasswordTextBox.Text.Length < 6)
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
                        if (!newPasswordTextBox.Text.Equals(newPasswordAgainTextBox.Text))
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
                }
            }

            var checkLen = newEmailTextBox.TextLength + newNameTextBox.TextLength + newSurnameTextBox.TextLength
                + oldPasswordTextBox.TextLength;

            if (checkLen == 0)
            {
                valid = false;
                MessageBox.Show(
                    "Edit at least 1 property!",
                    "Nothing to edit",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            if (valid)
            {
                var userId = _user.Id;
                _user = await _registeredUserService.UpdateUserAsync(userId, newEmailTextBox.Text,
                    newNameTextBox.Text, newSurnameTextBox.Text, newPasswordTextBox.Text);
                signedUserLabel.Text = $"Signed user: {_user.Name} {_user.Surname}";

                MessageBox.Show("Successfully edited.");
                newEmailTextBox.Text = "";
                newNameTextBox.Text = "";
                newSurnameTextBox.Text = "";
                oldPasswordTextBox.Text = "";
                newPasswordTextBox.Text = "";
                newPasswordAgainTextBox.Text = "";
                editProfilePanel.Visible = false;
                actionsPanel.Visible = true;
            }
        }
    }
}