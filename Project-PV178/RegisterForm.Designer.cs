namespace Project_PV178
{
    partial class RegisterForm
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            surnameLabel = new Label();
            surnameTextBox = new TextBox();
            nameLabel = new Label();
            nameTextBox = new TextBox();
            passwordAgainTextBox = new TextBox();
            passwordAgainLabel = new Label();
            passwordTextBox = new TextBox();
            passwordLabel = new Label();
            registerButton = new Button();
            emailLabel = new Label();
            emailTextBox = new TextBox();
            roleSelector = new GroupBox();
            regularUserButton = new RadioButton();
            superuserButton = new RadioButton();
            groupBox1.SuspendLayout();
            roleSelector.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(105, 9);
            label1.Name = "label1";
            label1.Size = new Size(581, 46);
            label1.TabIndex = 8;
            label1.Text = "Your Expense and Income Manager";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(surnameLabel);
            groupBox1.Controls.Add(surnameTextBox);
            groupBox1.Controls.Add(nameLabel);
            groupBox1.Controls.Add(nameTextBox);
            groupBox1.Controls.Add(passwordAgainTextBox);
            groupBox1.Controls.Add(passwordAgainLabel);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(passwordLabel);
            groupBox1.Controls.Add(registerButton);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Controls.Add(roleSelector);
            groupBox1.Location = new Point(99, 114);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 306);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Register here";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(341, 147);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 14;
            label7.Text = "Select role";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new Point(341, 94);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(67, 20);
            surnameLabel.TabIndex = 12;
            surnameLabel.Text = "Surname";
            // 
            // surnameTextBox
            // 
            surnameTextBox.AccessibleName = "emailLogin";
            surnameTextBox.Location = new Point(341, 117);
            surnameTextBox.MaxLength = 50;
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(234, 27);
            surnameTextBox.TabIndex = 5;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(341, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            nameTextBox.AccessibleName = "emailLogin";
            nameTextBox.Location = new Point(341, 64);
            nameTextBox.MaxLength = 50;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(234, 27);
            nameTextBox.TabIndex = 4;
            // 
            // passwordAgainTextBox
            // 
            passwordAgainTextBox.AccessibleName = "passwordLogin";
            passwordAgainTextBox.Location = new Point(6, 170);
            passwordAgainTextBox.MaxLength = 30;
            passwordAgainTextBox.Name = "passwordAgainTextBox";
            passwordAgainTextBox.PasswordChar = '*';
            passwordAgainTextBox.Size = new Size(234, 27);
            passwordAgainTextBox.TabIndex = 3;
            // 
            // passwordAgainLabel
            // 
            passwordAgainLabel.AutoSize = true;
            passwordAgainLabel.Location = new Point(6, 147);
            passwordAgainLabel.Name = "passwordAgainLabel";
            passwordAgainLabel.Size = new Size(111, 20);
            passwordAgainLabel.TabIndex = 7;
            passwordAgainLabel.Text = "Password again";
            // 
            // passwordTextBox
            // 
            passwordTextBox.AccessibleName = "passwordLogin";
            passwordTextBox.Location = new Point(6, 117);
            passwordTextBox.MaxLength = 30;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(234, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(6, 94);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(195, 20);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password (min. 6 characters)";
            // 
            // registerButton
            // 
            registerButton.Location = new Point(244, 239);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(109, 43);
            registerButton.TabIndex = 7;
            registerButton.Text = "Register now";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += RegisterButton_Click;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(6, 41);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            // 
            // emailTextBox
            // 
            emailTextBox.AccessibleName = "emailLogin";
            emailTextBox.Location = new Point(6, 64);
            emailTextBox.MaxLength = 50;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(234, 27);
            emailTextBox.TabIndex = 1;
            // 
            // roleSelector
            // 
            roleSelector.Controls.Add(regularUserButton);
            roleSelector.Controls.Add(superuserButton);
            roleSelector.Location = new Point(341, 158);
            roleSelector.Name = "roleSelector";
            roleSelector.Size = new Size(234, 39);
            roleSelector.TabIndex = 6;
            roleSelector.TabStop = false;
            // 
            // regularUserButton
            // 
            regularUserButton.AutoSize = true;
            regularUserButton.Location = new Point(114, 13);
            regularUserButton.Name = "regularUserButton";
            regularUserButton.Size = new Size(114, 24);
            regularUserButton.TabIndex = 1;
            regularUserButton.TabStop = true;
            regularUserButton.Text = "Regular User";
            regularUserButton.UseVisualStyleBackColor = true;
            // 
            // superuserButton
            // 
            superuserButton.AutoSize = true;
            superuserButton.Location = new Point(6, 13);
            superuserButton.Name = "superuserButton";
            superuserButton.Size = new Size(95, 24);
            superuserButton.TabIndex = 0;
            superuserButton.TabStop = true;
            superuserButton.Text = "Superuser";
            superuserButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MinimumSize = new Size(818, 497);
            Name = "RegisterForm";
            Text = "Register";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            roleSelector.ResumeLayout(false);
            roleSelector.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox passwordTextBox;
        private Label passwordLabel;
        private Button registerButton;
        private Label emailLabel;
        private TextBox emailTextBox;
        private Label passwordAgainLabel;
        private Label surnameLabel;
        private TextBox surnameTextBox;
        private Label nameLabel;
        private TextBox nameTextBox;
        private TextBox passwordAgainTextBox;
        private Label label7;
        private GroupBox roleSelector;
        private RadioButton regularUserButton;
        private RadioButton superuserButton;
    }
}