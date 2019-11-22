using System;

namespace FileManagementSystem
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
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.retypePassTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.retypeLabel = new System.Windows.Forms.Label();
            this.securityQuestionComboBox = new System.Windows.Forms.ComboBox();
            this.securityQuestionLabel = new System.Windows.Forms.Label();
            this.securityAnswerLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.helpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.securityAnswerTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(293, 97);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(321, 31);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(293, 152);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(321, 31);
            this.emailTextBox.TabIndex = 1;
            // 
            // retypePassTextBox
            // 
            this.retypePassTextBox.Location = new System.Drawing.Point(293, 383);
            this.retypePassTextBox.Name = "retypePassTextBox";
            this.retypePassTextBox.Size = new System.Drawing.Size(321, 31);
            this.retypePassTextBox.TabIndex = 5;
            this.retypePassTextBox.TextChanged += new System.EventHandler(this.retypePassTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(293, 332);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(321, 31);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(163, 99);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(116, 25);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(200, 155);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 25);
            this.emailLabel.TabIndex = 5;
            this.emailLabel.Text = "E-mail:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(166, 332);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(112, 25);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Password:";
            // 
            // retypeLabel
            // 
            this.retypeLabel.AutoSize = true;
            this.retypeLabel.Location = new System.Drawing.Point(89, 385);
            this.retypeLabel.Name = "retypeLabel";
            this.retypeLabel.Size = new System.Drawing.Size(193, 25);
            this.retypeLabel.TabIndex = 7;
            this.retypeLabel.Text = "Re-type Password:";
            // 
            // securityQuestionComboBox
            // 
            this.securityQuestionComboBox.FormattingEnabled = true;
            this.securityQuestionComboBox.Items.AddRange(new object[] {
            "What city were you born in?",
            "Whats your mothers maiden name?",
            "What city did you attend high school?"});
            this.securityQuestionComboBox.Location = new System.Drawing.Point(293, 439);
            this.securityQuestionComboBox.Name = "securityQuestionComboBox";
            this.securityQuestionComboBox.Size = new System.Drawing.Size(321, 33);
            this.securityQuestionComboBox.TabIndex = 6;
            // 
            // securityQuestionLabel
            // 
            this.securityQuestionLabel.AutoSize = true;
            this.securityQuestionLabel.Location = new System.Drawing.Point(96, 441);
            this.securityQuestionLabel.Name = "securityQuestionLabel";
            this.securityQuestionLabel.Size = new System.Drawing.Size(188, 25);
            this.securityQuestionLabel.TabIndex = 9;
            this.securityQuestionLabel.Text = "Security Question:";
            // 
            // securityAnswerLabel
            // 
            this.securityAnswerLabel.AutoSize = true;
            this.securityAnswerLabel.Location = new System.Drawing.Point(189, 495);
            this.securityAnswerLabel.Name = "securityAnswerLabel";
            this.securityAnswerLabel.Size = new System.Drawing.Size(89, 25);
            this.securityAnswerLabel.TabIndex = 11;
            this.securityAnswerLabel.Text = "Answer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(185, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(448, 51);
            this.label7.TabIndex = 12;
            this.label7.Text = "Register New Account";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(351, 560);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(183, 41);
            this.createAccountButton.TabIndex = 8;
            this.createAccountButton.Text = "Create Account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // helpLinkLabel
            // 
            this.helpLinkLabel.AutoSize = true;
            this.helpLinkLabel.Location = new System.Drawing.Point(554, 560);
            this.helpLinkLabel.Name = "helpLinkLabel";
            this.helpLinkLabel.Size = new System.Drawing.Size(56, 25);
            this.helpLinkLabel.TabIndex = 14;
            this.helpLinkLabel.TabStop = true;
            this.helpLinkLabel.Text = "Help";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(156, 214);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(122, 25);
            this.firstNameLabel.TabIndex = 15;
            this.firstNameLabel.Text = "First Name:";
            this.firstNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(158, 275);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 25);
            this.lastNameLabel.TabIndex = 16;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(293, 214);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(321, 31);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(293, 275);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(321, 31);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // securityAnswerTextbox
            // 
            this.securityAnswerTextbox.Location = new System.Drawing.Point(293, 495);
            this.securityAnswerTextbox.Name = "securityAnswerTextbox";
            this.securityAnswerTextbox.Size = new System.Drawing.Size(321, 31);
            this.securityAnswerTextbox.TabIndex = 7;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 753);
            this.Controls.Add(this.securityAnswerTextbox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.helpLinkLabel);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.securityAnswerLabel);
            this.Controls.Add(this.securityQuestionLabel);
            this.Controls.Add(this.securityQuestionComboBox);
            this.Controls.Add(this.retypeLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.retypePassTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
           
            // The password character is an asterisk.
            passwordTextBox.PasswordChar = '*';
        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox retypePassTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label retypeLabel;
        private System.Windows.Forms.ComboBox securityQuestionComboBox;
        private System.Windows.Forms.Label securityQuestionLabel;
        private System.Windows.Forms.Label securityAnswerLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.LinkLabel helpLinkLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox securityAnswerTextbox;
    }
}