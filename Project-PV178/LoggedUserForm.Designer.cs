namespace Project_PV178
{
    partial class LoggedUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedUserForm));
            label1 = new Label();
            signedUserLabel = new Label();
            actionsPanel = new Panel();
            pictureBox1 = new PictureBox();
            showAllTransactionsButton = new RadioButton();
            showMyIncomesButton = new RadioButton();
            showMyExpensesButton = new RadioButton();
            showMyTransactionsButton = new RadioButton();
            addIncomeButton = new RadioButton();
            actionButton = new Button();
            addExpenseButton = new RadioButton();
            actionsLabel = new Label();
            showTransactionsPanel = new Panel();
            backFilterButton = new Button();
            findTransactionsButton = new Button();
            dateFilterGroupBox = new GroupBox();
            maxDateLabel = new Label();
            maxDateTimePicker = new DateTimePicker();
            minDateLabel = new Label();
            minDateTimePicker = new DateTimePicker();
            descriptionFilterGroupBox = new GroupBox();
            descriptionContainsTextBox = new TextBox();
            transactionAmountGroupBox = new GroupBox();
            maxAmountTextBox = new TextBox();
            maxAmountLabel = new Label();
            minAmountLabel = new Label();
            minAmountTextBox = new TextBox();
            transactionTypeGroupBox = new GroupBox();
            allFilterButton = new RadioButton();
            incomeFilterButton = new RadioButton();
            expenseFilterButton = new RadioButton();
            filterTransactionsLabel = new Label();
            addTransactionPanel = new Panel();
            transactionPictureBox = new PictureBox();
            addTransactionBackButton = new Button();
            addTransactionButton = new Button();
            dateTimeLabel = new Label();
            dateTimePicker = new DateTimePicker();
            descriptionTextBox = new RichTextBox();
            descriptionLabel = new Label();
            amountTextBox = new TextBox();
            amountLabel = new Label();
            transactionType = new GroupBox();
            expenseButton = new RadioButton();
            incomeButton = new RadioButton();
            addNewTransactionLabel = new Label();
            transactionsDataPanel = new Panel();
            sumLabel = new Label();
            closeTransactionsButton = new Button();
            transactionDataGridView = new DataGridView();
            logoutLabel = new LinkLabel();
            editProfileLinkLabel = new LinkLabel();
            editProfilePanel = new Panel();
            pictureBox2 = new PictureBox();
            backEditProfileButton = new Button();
            editProfileButton = new Button();
            newPasswordGroupBox = new GroupBox();
            newPasswordAgainTextBox = new TextBox();
            newPasswordAgainLabel = new Label();
            newPasswordTextBox = new TextBox();
            newPasswordLabel = new Label();
            oldPasswordTextBox = new TextBox();
            oldPasswordLabel = new Label();
            newSurnameTextBox = new TextBox();
            label2 = new Label();
            newNameTextBox = new TextBox();
            newNameLabel = new Label();
            newEmailTextBox = new TextBox();
            newEmailLabel = new Label();
            editNoteLabel = new Label();
            editProfileLabel = new Label();
            actionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            showTransactionsPanel.SuspendLayout();
            dateFilterGroupBox.SuspendLayout();
            descriptionFilterGroupBox.SuspendLayout();
            transactionAmountGroupBox.SuspendLayout();
            transactionTypeGroupBox.SuspendLayout();
            addTransactionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionPictureBox).BeginInit();
            transactionType.SuspendLayout();
            transactionsDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).BeginInit();
            editProfilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            newPasswordGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(152, 9);
            label1.Name = "label1";
            label1.Size = new Size(684, 54);
            label1.TabIndex = 3;
            label1.Text = "Your Expense and Income Manager";
            // 
            // signedUserLabel
            // 
            signedUserLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            signedUserLabel.AutoSize = true;
            signedUserLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            signedUserLabel.Location = new Point(620, 67);
            signedUserLabel.Name = "signedUserLabel";
            signedUserLabel.Size = new Size(109, 25);
            signedUserLabel.TabIndex = 4;
            signedUserLabel.Text = "Signed user:";
            // 
            // actionsPanel
            // 
            actionsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            actionsPanel.BorderStyle = BorderStyle.FixedSingle;
            actionsPanel.Controls.Add(pictureBox1);
            actionsPanel.Controls.Add(showAllTransactionsButton);
            actionsPanel.Controls.Add(showMyIncomesButton);
            actionsPanel.Controls.Add(showMyExpensesButton);
            actionsPanel.Controls.Add(showMyTransactionsButton);
            actionsPanel.Controls.Add(addIncomeButton);
            actionsPanel.Controls.Add(actionButton);
            actionsPanel.Controls.Add(addExpenseButton);
            actionsPanel.Controls.Add(actionsLabel);
            actionsPanel.Location = new Point(36, 93);
            actionsPanel.Name = "actionsPanel";
            actionsPanel.Size = new Size(904, 429);
            actionsPanel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.transactions_data;
            pictureBox1.Location = new Point(619, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // showAllTransactionsButton
            // 
            showAllTransactionsButton.AutoSize = true;
            showAllTransactionsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showAllTransactionsButton.Location = new Point(326, 255);
            showAllTransactionsButton.Name = "showAllTransactionsButton";
            showAllTransactionsButton.Size = new Size(216, 32);
            showAllTransactionsButton.TabIndex = 7;
            showAllTransactionsButton.TabStop = true;
            showAllTransactionsButton.Text = "Show all transactions";
            showAllTransactionsButton.UseVisualStyleBackColor = true;
            // 
            // showMyIncomesButton
            // 
            showMyIncomesButton.AutoSize = true;
            showMyIncomesButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showMyIncomesButton.Location = new Point(326, 161);
            showMyIncomesButton.Name = "showMyIncomesButton";
            showMyIncomesButton.Size = new Size(190, 32);
            showMyIncomesButton.TabIndex = 6;
            showMyIncomesButton.TabStop = true;
            showMyIncomesButton.Text = "Show my incomes";
            showMyIncomesButton.UseVisualStyleBackColor = true;
            // 
            // showMyExpensesButton
            // 
            showMyExpensesButton.AutoSize = true;
            showMyExpensesButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showMyExpensesButton.Location = new Point(326, 114);
            showMyExpensesButton.Name = "showMyExpensesButton";
            showMyExpensesButton.Size = new Size(196, 32);
            showMyExpensesButton.TabIndex = 5;
            showMyExpensesButton.TabStop = true;
            showMyExpensesButton.Text = "Show my expenses";
            showMyExpensesButton.UseVisualStyleBackColor = true;
            // 
            // showMyTransactionsButton
            // 
            showMyTransactionsButton.AutoSize = true;
            showMyTransactionsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showMyTransactionsButton.Location = new Point(326, 208);
            showMyTransactionsButton.Name = "showMyTransactionsButton";
            showMyTransactionsButton.Size = new Size(248, 32);
            showMyTransactionsButton.TabIndex = 4;
            showMyTransactionsButton.TabStop = true;
            showMyTransactionsButton.Text = "Show all my transactions";
            showMyTransactionsButton.UseVisualStyleBackColor = true;
            // 
            // addIncomeButton
            // 
            addIncomeButton.AutoSize = true;
            addIncomeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addIncomeButton.Location = new Point(31, 163);
            addIncomeButton.Name = "addIncomeButton";
            addIncomeButton.Size = new Size(179, 32);
            addIncomeButton.TabIndex = 3;
            addIncomeButton.TabStop = true;
            addIncomeButton.Text = "Add new income";
            addIncomeButton.UseVisualStyleBackColor = true;
            // 
            // actionButton
            // 
            actionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            actionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            actionButton.Location = new Point(717, 345);
            actionButton.Name = "actionButton";
            actionButton.Size = new Size(134, 54);
            actionButton.TabIndex = 2;
            actionButton.Text = "Do chosen";
            actionButton.UseVisualStyleBackColor = true;
            actionButton.Click += actionButton_Click;
            // 
            // addExpenseButton
            // 
            addExpenseButton.AutoSize = true;
            addExpenseButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addExpenseButton.Location = new Point(31, 116);
            addExpenseButton.Name = "addExpenseButton";
            addExpenseButton.Size = new Size(185, 32);
            addExpenseButton.TabIndex = 1;
            addExpenseButton.TabStop = true;
            addExpenseButton.Text = "Add new expense";
            addExpenseButton.UseVisualStyleBackColor = true;
            // 
            // actionsLabel
            // 
            actionsLabel.AutoSize = true;
            actionsLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            actionsLabel.Location = new Point(29, 19);
            actionsLabel.Name = "actionsLabel";
            actionsLabel.Size = new Size(126, 46);
            actionsLabel.TabIndex = 0;
            actionsLabel.Text = "Actions";
            // 
            // showTransactionsPanel
            // 
            showTransactionsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showTransactionsPanel.BorderStyle = BorderStyle.FixedSingle;
            showTransactionsPanel.Controls.Add(backFilterButton);
            showTransactionsPanel.Controls.Add(findTransactionsButton);
            showTransactionsPanel.Controls.Add(dateFilterGroupBox);
            showTransactionsPanel.Controls.Add(descriptionFilterGroupBox);
            showTransactionsPanel.Controls.Add(transactionAmountGroupBox);
            showTransactionsPanel.Controls.Add(transactionTypeGroupBox);
            showTransactionsPanel.Controls.Add(filterTransactionsLabel);
            showTransactionsPanel.Location = new Point(36, 93);
            showTransactionsPanel.Name = "showTransactionsPanel";
            showTransactionsPanel.Size = new Size(904, 429);
            showTransactionsPanel.TabIndex = 7;
            // 
            // backFilterButton
            // 
            backFilterButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backFilterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            backFilterButton.Location = new Point(17, 363);
            backFilterButton.Name = "backFilterButton";
            backFilterButton.Size = new Size(120, 45);
            backFilterButton.TabIndex = 7;
            backFilterButton.Text = "Back";
            backFilterButton.UseVisualStyleBackColor = true;
            backFilterButton.Click += backFilterButton_Click;
            // 
            // findTransactionsButton
            // 
            findTransactionsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            findTransactionsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            findTransactionsButton.Location = new Point(760, 363);
            findTransactionsButton.Name = "findTransactionsButton";
            findTransactionsButton.Size = new Size(120, 45);
            findTransactionsButton.TabIndex = 6;
            findTransactionsButton.Text = "Find";
            findTransactionsButton.UseVisualStyleBackColor = true;
            findTransactionsButton.Click += findTransactionsButton_Click;
            // 
            // dateFilterGroupBox
            // 
            dateFilterGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateFilterGroupBox.Controls.Add(maxDateLabel);
            dateFilterGroupBox.Controls.Add(maxDateTimePicker);
            dateFilterGroupBox.Controls.Add(minDateLabel);
            dateFilterGroupBox.Controls.Add(minDateTimePicker);
            dateFilterGroupBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateFilterGroupBox.Location = new Point(565, 68);
            dateFilterGroupBox.Name = "dateFilterGroupBox";
            dateFilterGroupBox.Size = new Size(321, 156);
            dateFilterGroupBox.TabIndex = 5;
            dateFilterGroupBox.TabStop = false;
            dateFilterGroupBox.Text = "Date";
            // 
            // maxDateLabel
            // 
            maxDateLabel.AutoSize = true;
            maxDateLabel.Location = new Point(6, 84);
            maxDateLabel.Name = "maxDateLabel";
            maxDateLabel.Size = new Size(31, 23);
            maxDateLabel.TabIndex = 3;
            maxDateLabel.Text = "To:";
            // 
            // maxDateTimePicker
            // 
            maxDateTimePicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxDateTimePicker.Location = new Point(6, 107);
            maxDateTimePicker.Name = "maxDateTimePicker";
            maxDateTimePicker.Size = new Size(277, 27);
            maxDateTimePicker.TabIndex = 2;
            maxDateTimePicker.Value = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // minDateLabel
            // 
            minDateLabel.AutoSize = true;
            minDateLabel.Location = new Point(6, 23);
            minDateLabel.Name = "minDateLabel";
            minDateLabel.Size = new Size(53, 23);
            minDateLabel.TabIndex = 1;
            minDateLabel.Text = "From:";
            // 
            // minDateTimePicker
            // 
            minDateTimePicker.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            minDateTimePicker.Location = new Point(6, 49);
            minDateTimePicker.Name = "minDateTimePicker";
            minDateTimePicker.Size = new Size(277, 27);
            minDateTimePicker.TabIndex = 0;
            minDateTimePicker.Value = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // descriptionFilterGroupBox
            // 
            descriptionFilterGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionFilterGroupBox.Controls.Add(descriptionContainsTextBox);
            descriptionFilterGroupBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionFilterGroupBox.Location = new Point(17, 252);
            descriptionFilterGroupBox.Name = "descriptionFilterGroupBox";
            descriptionFilterGroupBox.Size = new Size(827, 92);
            descriptionFilterGroupBox.TabIndex = 4;
            descriptionFilterGroupBox.TabStop = false;
            descriptionFilterGroupBox.Text = "Description contains";
            // 
            // descriptionContainsTextBox
            // 
            descriptionContainsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionContainsTextBox.Location = new Point(6, 39);
            descriptionContainsTextBox.Name = "descriptionContainsTextBox";
            descriptionContainsTextBox.Size = new Size(627, 31);
            descriptionContainsTextBox.TabIndex = 0;
            // 
            // transactionAmountGroupBox
            // 
            transactionAmountGroupBox.Controls.Add(maxAmountTextBox);
            transactionAmountGroupBox.Controls.Add(maxAmountLabel);
            transactionAmountGroupBox.Controls.Add(minAmountLabel);
            transactionAmountGroupBox.Controls.Add(minAmountTextBox);
            transactionAmountGroupBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            transactionAmountGroupBox.Location = new Point(17, 142);
            transactionAmountGroupBox.Name = "transactionAmountGroupBox";
            transactionAmountGroupBox.Size = new Size(284, 98);
            transactionAmountGroupBox.TabIndex = 3;
            transactionAmountGroupBox.TabStop = false;
            transactionAmountGroupBox.Text = "Amount";
            // 
            // maxAmountTextBox
            // 
            maxAmountTextBox.Location = new Point(148, 51);
            maxAmountTextBox.Name = "maxAmountTextBox";
            maxAmountTextBox.Size = new Size(113, 31);
            maxAmountTextBox.TabIndex = 3;
            maxAmountTextBox.KeyPress += maxValueTextBox_KeyPress;
            // 
            // maxAmountLabel
            // 
            maxAmountLabel.AutoSize = true;
            maxAmountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            maxAmountLabel.Location = new Point(148, 23);
            maxAmountLabel.Name = "maxAmountLabel";
            maxAmountLabel.Size = new Size(46, 23);
            maxAmountLabel.TabIndex = 2;
            maxAmountLabel.Text = "Max:";
            // 
            // minAmountLabel
            // 
            minAmountLabel.AutoSize = true;
            minAmountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            minAmountLabel.Location = new Point(6, 23);
            minAmountLabel.Name = "minAmountLabel";
            minAmountLabel.Size = new Size(43, 23);
            minAmountLabel.TabIndex = 1;
            minAmountLabel.Text = "Min:";
            // 
            // minAmountTextBox
            // 
            minAmountTextBox.Location = new Point(6, 51);
            minAmountTextBox.Name = "minAmountTextBox";
            minAmountTextBox.Size = new Size(113, 31);
            minAmountTextBox.TabIndex = 0;
            minAmountTextBox.KeyPress += minAmountTextBox_KeyPress;
            // 
            // transactionTypeGroupBox
            // 
            transactionTypeGroupBox.Controls.Add(allFilterButton);
            transactionTypeGroupBox.Controls.Add(incomeFilterButton);
            transactionTypeGroupBox.Controls.Add(expenseFilterButton);
            transactionTypeGroupBox.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            transactionTypeGroupBox.Location = new Point(18, 60);
            transactionTypeGroupBox.Name = "transactionTypeGroupBox";
            transactionTypeGroupBox.Size = new Size(283, 76);
            transactionTypeGroupBox.TabIndex = 2;
            transactionTypeGroupBox.TabStop = false;
            transactionTypeGroupBox.Text = "Type";
            // 
            // allFilterButton
            // 
            allFilterButton.AutoSize = true;
            allFilterButton.Location = new Point(224, 30);
            allFilterButton.Name = "allFilterButton";
            allFilterButton.Size = new Size(53, 29);
            allFilterButton.TabIndex = 5;
            allFilterButton.TabStop = true;
            allFilterButton.Text = "All";
            allFilterButton.UseVisualStyleBackColor = true;
            // 
            // incomeFilterButton
            // 
            incomeFilterButton.AutoSize = true;
            incomeFilterButton.Location = new Point(117, 30);
            incomeFilterButton.Name = "incomeFilterButton";
            incomeFilterButton.Size = new Size(92, 29);
            incomeFilterButton.TabIndex = 4;
            incomeFilterButton.TabStop = true;
            incomeFilterButton.Text = "Income";
            incomeFilterButton.UseVisualStyleBackColor = true;
            // 
            // expenseFilterButton
            // 
            expenseFilterButton.AutoSize = true;
            expenseFilterButton.Location = new Point(5, 30);
            expenseFilterButton.Name = "expenseFilterButton";
            expenseFilterButton.Size = new Size(97, 29);
            expenseFilterButton.TabIndex = 3;
            expenseFilterButton.TabStop = true;
            expenseFilterButton.Text = "Expense";
            expenseFilterButton.UseVisualStyleBackColor = true;
            // 
            // filterTransactionsLabel
            // 
            filterTransactionsLabel.AutoSize = true;
            filterTransactionsLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            filterTransactionsLabel.Location = new Point(18, 12);
            filterTransactionsLabel.Name = "filterTransactionsLabel";
            filterTransactionsLabel.Size = new Size(232, 38);
            filterTransactionsLabel.TabIndex = 1;
            filterTransactionsLabel.Text = "Filter transactions";
            // 
            // addTransactionPanel
            // 
            addTransactionPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            addTransactionPanel.BorderStyle = BorderStyle.FixedSingle;
            addTransactionPanel.Controls.Add(transactionPictureBox);
            addTransactionPanel.Controls.Add(addTransactionBackButton);
            addTransactionPanel.Controls.Add(addTransactionButton);
            addTransactionPanel.Controls.Add(dateTimeLabel);
            addTransactionPanel.Controls.Add(dateTimePicker);
            addTransactionPanel.Controls.Add(descriptionTextBox);
            addTransactionPanel.Controls.Add(descriptionLabel);
            addTransactionPanel.Controls.Add(amountTextBox);
            addTransactionPanel.Controls.Add(amountLabel);
            addTransactionPanel.Controls.Add(transactionType);
            addTransactionPanel.Controls.Add(addNewTransactionLabel);
            addTransactionPanel.Location = new Point(36, 93);
            addTransactionPanel.Name = "addTransactionPanel";
            addTransactionPanel.Size = new Size(904, 429);
            addTransactionPanel.TabIndex = 6;
            // 
            // transactionPictureBox
            // 
            transactionPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            transactionPictureBox.ErrorImage = null;
            transactionPictureBox.Image = Properties.Resources.transaction;
            transactionPictureBox.InitialImage = (Image)resources.GetObject("transactionPictureBox.InitialImage");
            transactionPictureBox.Location = new Point(595, 14);
            transactionPictureBox.Name = "transactionPictureBox";
            transactionPictureBox.Size = new Size(256, 161);
            transactionPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            transactionPictureBox.TabIndex = 10;
            transactionPictureBox.TabStop = false;
            // 
            // addTransactionBackButton
            // 
            addTransactionBackButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addTransactionBackButton.Location = new Point(30, 361);
            addTransactionBackButton.Name = "addTransactionBackButton";
            addTransactionBackButton.Size = new Size(130, 45);
            addTransactionBackButton.TabIndex = 9;
            addTransactionBackButton.Text = "Back";
            addTransactionBackButton.UseVisualStyleBackColor = true;
            addTransactionBackButton.Click += addTransactionBackButton_Click;
            // 
            // addTransactionButton
            // 
            addTransactionButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addTransactionButton.Location = new Point(744, 361);
            addTransactionButton.Name = "addTransactionButton";
            addTransactionButton.Size = new Size(130, 45);
            addTransactionButton.TabIndex = 8;
            addTransactionButton.Text = "Add";
            addTransactionButton.UseVisualStyleBackColor = true;
            addTransactionButton.Click += addTransactionButton_Click;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeLabel.Location = new Point(346, 183);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(49, 25);
            dateTimeLabel.TabIndex = 7;
            dateTimeLabel.Text = "Date";
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.Location = new Point(346, 211);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(267, 27);
            dateTimePicker.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(30, 285);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(486, 56);
            descriptionTextBox.TabIndex = 5;
            descriptionTextBox.Text = "";
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(30, 257);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(148, 25);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Short description";
            // 
            // amountTextBox
            // 
            amountTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            amountTextBox.Location = new Point(30, 211);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(164, 27);
            amountTextBox.TabIndex = 3;
            amountTextBox.KeyPress += amountTextBox_KeyPress;
            // 
            // amountLabel
            // 
            amountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            amountLabel.Location = new Point(30, 183);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(77, 25);
            amountLabel.TabIndex = 2;
            amountLabel.Text = "Amount";
            // 
            // transactionType
            // 
            transactionType.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transactionType.Controls.Add(expenseButton);
            transactionType.Controls.Add(incomeButton);
            transactionType.Location = new Point(30, 66);
            transactionType.Name = "transactionType";
            transactionType.Size = new Size(315, 96);
            transactionType.TabIndex = 1;
            transactionType.TabStop = false;
            transactionType.Text = "Transaction type";
            // 
            // expenseButton
            // 
            expenseButton.Anchor = AnchorStyles.Right;
            expenseButton.AutoSize = true;
            expenseButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            expenseButton.Location = new Point(174, 39);
            expenseButton.Name = "expenseButton";
            expenseButton.Size = new Size(97, 29);
            expenseButton.TabIndex = 1;
            expenseButton.TabStop = true;
            expenseButton.Text = "Expense";
            expenseButton.UseVisualStyleBackColor = true;
            // 
            // incomeButton
            // 
            incomeButton.Anchor = AnchorStyles.Left;
            incomeButton.AutoSize = true;
            incomeButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            incomeButton.Location = new Point(33, 39);
            incomeButton.Name = "incomeButton";
            incomeButton.Size = new Size(92, 29);
            incomeButton.TabIndex = 0;
            incomeButton.TabStop = true;
            incomeButton.Text = "Income";
            incomeButton.UseVisualStyleBackColor = true;
            // 
            // addNewTransactionLabel
            // 
            addNewTransactionLabel.AutoSize = true;
            addNewTransactionLabel.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            addNewTransactionLabel.Location = new Point(33, 14);
            addNewTransactionLabel.Name = "addNewTransactionLabel";
            addNewTransactionLabel.Size = new Size(227, 31);
            addNewTransactionLabel.TabIndex = 0;
            addNewTransactionLabel.Text = "Add new transaction";
            // 
            // transactionsDataPanel
            // 
            transactionsDataPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transactionsDataPanel.Controls.Add(sumLabel);
            transactionsDataPanel.Controls.Add(closeTransactionsButton);
            transactionsDataPanel.Controls.Add(transactionDataGridView);
            transactionsDataPanel.Location = new Point(36, 93);
            transactionsDataPanel.Name = "transactionsDataPanel";
            transactionsDataPanel.Size = new Size(904, 429);
            transactionsDataPanel.TabIndex = 8;
            // 
            // sumLabel
            // 
            sumLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            sumLabel.AutoSize = true;
            sumLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            sumLabel.Location = new Point(13, 396);
            sumLabel.Name = "sumLabel";
            sumLabel.Size = new Size(57, 25);
            sumLabel.TabIndex = 2;
            sumLabel.Text = "Sum: ";
            // 
            // closeTransactionsButton
            // 
            closeTransactionsButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            closeTransactionsButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            closeTransactionsButton.Location = new Point(789, 395);
            closeTransactionsButton.Name = "closeTransactionsButton";
            closeTransactionsButton.Size = new Size(94, 29);
            closeTransactionsButton.TabIndex = 1;
            closeTransactionsButton.Text = "Close";
            closeTransactionsButton.UseVisualStyleBackColor = true;
            closeTransactionsButton.Click += closeTransactionsButton_Click;
            // 
            // transactionDataGridView
            // 
            transactionDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            transactionDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            transactionDataGridView.Location = new Point(13, 8);
            transactionDataGridView.Name = "transactionDataGridView";
            transactionDataGridView.RowHeadersWidth = 51;
            transactionDataGridView.RowTemplate.Height = 29;
            transactionDataGridView.Size = new Size(870, 378);
            transactionDataGridView.TabIndex = 0;
            // 
            // logoutLabel
            // 
            logoutLabel.AutoSize = true;
            logoutLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            logoutLabel.Location = new Point(99, 67);
            logoutLabel.Name = "logoutLabel";
            logoutLabel.Size = new Size(74, 25);
            logoutLabel.TabIndex = 9;
            logoutLabel.TabStop = true;
            logoutLabel.Text = "Log out";
            logoutLabel.LinkClicked += logoutLabel_LinkClicked;
            // 
            // editProfileLinkLabel
            // 
            editProfileLinkLabel.AutoSize = true;
            editProfileLinkLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            editProfileLinkLabel.Location = new Point(172, 67);
            editProfileLinkLabel.Name = "editProfileLinkLabel";
            editProfileLinkLabel.Size = new Size(97, 25);
            editProfileLinkLabel.TabIndex = 10;
            editProfileLinkLabel.TabStop = true;
            editProfileLinkLabel.Text = "Edit Profile";
            editProfileLinkLabel.LinkClicked += editProfileLinkLabel_LinkClicked;
            // 
            // editProfilePanel
            // 
            editProfilePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            editProfilePanel.BorderStyle = BorderStyle.FixedSingle;
            editProfilePanel.Controls.Add(pictureBox2);
            editProfilePanel.Controls.Add(backEditProfileButton);
            editProfilePanel.Controls.Add(editProfileButton);
            editProfilePanel.Controls.Add(newPasswordGroupBox);
            editProfilePanel.Controls.Add(newSurnameTextBox);
            editProfilePanel.Controls.Add(label2);
            editProfilePanel.Controls.Add(newNameTextBox);
            editProfilePanel.Controls.Add(newNameLabel);
            editProfilePanel.Controls.Add(newEmailTextBox);
            editProfilePanel.Controls.Add(newEmailLabel);
            editProfilePanel.Controls.Add(editNoteLabel);
            editProfilePanel.Controls.Add(editProfileLabel);
            editProfilePanel.Location = new Point(36, 93);
            editProfilePanel.Name = "editProfilePanel";
            editProfilePanel.Size = new Size(904, 429);
            editProfilePanel.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.profile_picture_default;
            pictureBox2.Location = new Point(620, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(142, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // backEditProfileButton
            // 
            backEditProfileButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            backEditProfileButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            backEditProfileButton.Location = new Point(33, 364);
            backEditProfileButton.Name = "backEditProfileButton";
            backEditProfileButton.Size = new Size(145, 49);
            backEditProfileButton.TabIndex = 10;
            backEditProfileButton.Text = "Back to actions";
            backEditProfileButton.UseVisualStyleBackColor = true;
            backEditProfileButton.Click += backEditProfileButton_Click;
            // 
            // editProfileButton
            // 
            editProfileButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            editProfileButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            editProfileButton.Location = new Point(741, 364);
            editProfileButton.Name = "editProfileButton";
            editProfileButton.Size = new Size(122, 49);
            editProfileButton.TabIndex = 9;
            editProfileButton.Text = "Edit";
            editProfileButton.UseVisualStyleBackColor = true;
            editProfileButton.Click += editProfileButton_Click;
            // 
            // newPasswordGroupBox
            // 
            newPasswordGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            newPasswordGroupBox.Controls.Add(newPasswordAgainTextBox);
            newPasswordGroupBox.Controls.Add(newPasswordAgainLabel);
            newPasswordGroupBox.Controls.Add(newPasswordTextBox);
            newPasswordGroupBox.Controls.Add(newPasswordLabel);
            newPasswordGroupBox.Controls.Add(oldPasswordTextBox);
            newPasswordGroupBox.Controls.Add(oldPasswordLabel);
            newPasswordGroupBox.Location = new Point(478, 134);
            newPasswordGroupBox.Name = "newPasswordGroupBox";
            newPasswordGroupBox.Size = new Size(373, 215);
            newPasswordGroupBox.TabIndex = 8;
            newPasswordGroupBox.TabStop = false;
            newPasswordGroupBox.Text = "New password";
            // 
            // newPasswordAgainTextBox
            // 
            newPasswordAgainTextBox.Location = new Point(6, 175);
            newPasswordAgainTextBox.Name = "newPasswordAgainTextBox";
            newPasswordAgainTextBox.PasswordChar = '*';
            newPasswordAgainTextBox.Size = new Size(297, 27);
            newPasswordAgainTextBox.TabIndex = 13;
            // 
            // newPasswordAgainLabel
            // 
            newPasswordAgainLabel.AutoSize = true;
            newPasswordAgainLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordAgainLabel.Location = new Point(6, 149);
            newPasswordAgainLabel.Name = "newPasswordAgainLabel";
            newPasswordAgainLabel.Size = new Size(167, 23);
            newPasswordAgainLabel.TabIndex = 12;
            newPasswordAgainLabel.Text = "New password again";
            // 
            // newPasswordTextBox
            // 
            newPasswordTextBox.Location = new Point(6, 110);
            newPasswordTextBox.Name = "newPasswordTextBox";
            newPasswordTextBox.PasswordChar = '*';
            newPasswordTextBox.Size = new Size(297, 27);
            newPasswordTextBox.TabIndex = 11;
            // 
            // newPasswordLabel
            // 
            newPasswordLabel.AutoSize = true;
            newPasswordLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            newPasswordLabel.Location = new Point(6, 84);
            newPasswordLabel.Name = "newPasswordLabel";
            newPasswordLabel.Size = new Size(265, 23);
            newPasswordLabel.TabIndex = 10;
            newPasswordLabel.Text = "New password (min. 6 characters)";
            // 
            // oldPasswordTextBox
            // 
            oldPasswordTextBox.Location = new Point(6, 53);
            oldPasswordTextBox.Name = "oldPasswordTextBox";
            oldPasswordTextBox.PasswordChar = '*';
            oldPasswordTextBox.Size = new Size(297, 27);
            oldPasswordTextBox.TabIndex = 9;
            // 
            // oldPasswordLabel
            // 
            oldPasswordLabel.AutoSize = true;
            oldPasswordLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            oldPasswordLabel.Location = new Point(6, 27);
            oldPasswordLabel.Name = "oldPasswordLabel";
            oldPasswordLabel.Size = new Size(113, 23);
            oldPasswordLabel.TabIndex = 0;
            oldPasswordLabel.Text = "Old password";
            // 
            // newSurnameTextBox
            // 
            newSurnameTextBox.Location = new Point(43, 317);
            newSurnameTextBox.Name = "newSurnameTextBox";
            newSurnameTextBox.Size = new Size(297, 27);
            newSurnameTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(43, 287);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 6;
            label2.Text = "New surname";
            // 
            // newNameTextBox
            // 
            newNameTextBox.Location = new Point(43, 240);
            newNameTextBox.Name = "newNameTextBox";
            newNameTextBox.Size = new Size(297, 27);
            newNameTextBox.TabIndex = 5;
            // 
            // newNameLabel
            // 
            newNameLabel.AutoSize = true;
            newNameLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            newNameLabel.Location = new Point(43, 210);
            newNameLabel.Name = "newNameLabel";
            newNameLabel.Size = new Size(96, 25);
            newNameLabel.TabIndex = 4;
            newNameLabel.Text = "New name";
            // 
            // newEmailTextBox
            // 
            newEmailTextBox.Location = new Point(43, 164);
            newEmailTextBox.Name = "newEmailTextBox";
            newEmailTextBox.Size = new Size(297, 27);
            newEmailTextBox.TabIndex = 3;
            // 
            // newEmailLabel
            // 
            newEmailLabel.AutoSize = true;
            newEmailLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            newEmailLabel.Location = new Point(43, 134);
            newEmailLabel.Name = "newEmailLabel";
            newEmailLabel.Size = new Size(94, 25);
            newEmailLabel.TabIndex = 2;
            newEmailLabel.Text = "New email";
            // 
            // editNoteLabel
            // 
            editNoteLabel.AutoSize = true;
            editNoteLabel.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            editNoteLabel.Location = new Point(41, 66);
            editNoteLabel.Name = "editNoteLabel";
            editNoteLabel.Size = new Size(254, 20);
            editNoteLabel.TabIndex = 1;
            editNoteLabel.Text = "Fill in only the parts you want to edit!";
            // 
            // editProfileLabel
            // 
            editProfileLabel.AutoSize = true;
            editProfileLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point);
            editProfileLabel.Location = new Point(36, 27);
            editProfileLabel.Name = "editProfileLabel";
            editProfileLabel.Size = new Size(271, 38);
            editProfileLabel.TabIndex = 0;
            editProfileLabel.Text = "Edit your profile here";
            // 
            // LoggedUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 543);
            Controls.Add(editProfilePanel);
            Controls.Add(editProfileLinkLabel);
            Controls.Add(logoutLabel);
            Controls.Add(transactionsDataPanel);
            Controls.Add(addTransactionPanel);
            Controls.Add(actionsPanel);
            Controls.Add(showTransactionsPanel);
            Controls.Add(signedUserLabel);
            Controls.Add(label1);
            MinimumSize = new Size(995, 590);
            Name = "LoggedUserForm";
            Text = "Work with your expenses and incomes";
            actionsPanel.ResumeLayout(false);
            actionsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            showTransactionsPanel.ResumeLayout(false);
            showTransactionsPanel.PerformLayout();
            dateFilterGroupBox.ResumeLayout(false);
            dateFilterGroupBox.PerformLayout();
            descriptionFilterGroupBox.ResumeLayout(false);
            descriptionFilterGroupBox.PerformLayout();
            transactionAmountGroupBox.ResumeLayout(false);
            transactionAmountGroupBox.PerformLayout();
            transactionTypeGroupBox.ResumeLayout(false);
            transactionTypeGroupBox.PerformLayout();
            addTransactionPanel.ResumeLayout(false);
            addTransactionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionPictureBox).EndInit();
            transactionType.ResumeLayout(false);
            transactionType.PerformLayout();
            transactionsDataPanel.ResumeLayout(false);
            transactionsDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transactionDataGridView).EndInit();
            editProfilePanel.ResumeLayout(false);
            editProfilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            newPasswordGroupBox.ResumeLayout(false);
            newPasswordGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label signedUserLabel;
        private Panel actionsPanel;
        private Button actionButton;
        private RadioButton addExpenseButton;
        private Label actionsLabel;
        private Panel addTransactionPanel;
        private Label addNewTransactionLabel;
        private RadioButton addIncomeButton;
        private RadioButton showMyExpensesButton;
        private RadioButton showMyTransactionsButton;
        private RadioButton showMyIncomesButton;
        private GroupBox transactionType;
        private RadioButton expenseButton;
        private RadioButton incomeButton;
        private TextBox amountTextBox;
        private Label amountLabel;
        private RichTextBox descriptionTextBox;
        private Label descriptionLabel;
        private Label dateTimeLabel;
        private DateTimePicker dateTimePicker;
        private Button addTransactionButton;
        private Panel showTransactionsPanel;
        private Label filterTransactionsLabel;
        private GroupBox transactionTypeGroupBox;
        private RadioButton allFilterButton;
        private RadioButton incomeFilterButton;
        private RadioButton expenseFilterButton;
        private GroupBox transactionAmountGroupBox;
        private TextBox maxAmountTextBox;
        private Label maxAmountLabel;
        private Label minAmountLabel;
        private TextBox minAmountTextBox;
        private GroupBox descriptionFilterGroupBox;
        private TextBox descriptionContainsTextBox;
        private GroupBox dateFilterGroupBox;
        private Label maxDateLabel;
        private DateTimePicker maxDateTimePicker;
        private Label minDateLabel;
        private DateTimePicker minDateTimePicker;
        private Button findTransactionsButton;
        private RadioButton showAllTransactionsButton;
        private Panel transactionsDataPanel;
        private DataGridView transactionDataGridView;
        private Button closeTransactionsButton;
        private Button backFilterButton;
        private Button addTransactionBackButton;
        private LinkLabel logoutLabel;
        private Label sumLabel;
        public PictureBox transactionPictureBox;
        private PictureBox pictureBox1;
        private LinkLabel editProfileLinkLabel;
        private Panel editProfilePanel;
        private Label editProfileLabel;
        private Label editNoteLabel;
        private TextBox newSurnameTextBox;
        private Label label2;
        private TextBox newNameTextBox;
        private Label newNameLabel;
        private TextBox newEmailTextBox;
        private Label newEmailLabel;
        private Button backEditProfileButton;
        private Button editProfileButton;
        private GroupBox newPasswordGroupBox;
        private TextBox newPasswordAgainTextBox;
        private Label newPasswordAgainLabel;
        private TextBox newPasswordTextBox;
        private Label newPasswordLabel;
        private TextBox oldPasswordTextBox;
        private Label oldPasswordLabel;
        private PictureBox pictureBox2;
    }
}