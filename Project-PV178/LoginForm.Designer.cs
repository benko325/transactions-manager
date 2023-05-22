namespace Project_PV178
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginButton = new Button();
            registerLinkLabel = new LinkLabel();
            label1 = new Label();
            passwordTextBox = new TextBox();
            emailTextBox = new TextBox();
            emailLabel = new Label();
            passwordLabel = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Location = new Point(207, 158);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(109, 43);
            loginButton.TabIndex = 3;
            loginButton.Text = "Log in";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += LoginButton_Click;
            // 
            // registerLinkLabel
            // 
            registerLinkLabel.AutoSize = true;
            registerLinkLabel.Location = new Point(307, 214);
            registerLinkLabel.Name = "registerLinkLabel";
            registerLinkLabel.Size = new Size(95, 20);
            registerLinkLabel.TabIndex = 4;
            registerLinkLabel.TabStop = true;
            registerLinkLabel.Text = "Register now";
            registerLinkLabel.LinkClicked += RegisterLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(113, 9);
            label1.Name = "label1";
            label1.Size = new Size(581, 46);
            label1.TabIndex = 2;
            label1.Text = "Your Expense and Income Manager";
            // 
            // passwordTextBox
            // 
            passwordTextBox.AccessibleName = "passwordLogin";
            passwordTextBox.Location = new Point(145, 125);
            passwordTextBox.MaxLength = 30;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(234, 27);
            passwordTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.AccessibleName = "emailLogin";
            emailTextBox.Location = new Point(145, 72);
            emailTextBox.MaxLength = 50;
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(234, 27);
            emailTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(145, 49);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(46, 20);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(145, 102);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(70, 20);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(registerLinkLabel);
            groupBox1.Controls.Add(passwordLabel);
            groupBox1.Controls.Add(loginButton);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(emailTextBox);
            groupBox1.Location = new Point(136, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(525, 281);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Log in or Register";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 214);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 7;
            label4.Text = "Do not have an account?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MinimumSize = new Size(818, 497);
            Name = "LoginForm";
            Text = "Log in";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginButton;
        private LinkLabel registerLinkLabel;
        private Label label1;
        private TextBox passwordTextBox;
        private TextBox emailTextBox;
        private Label emailLabel;
        private Label passwordLabel;
        private GroupBox groupBox1;
        private Label label4;
    }
}