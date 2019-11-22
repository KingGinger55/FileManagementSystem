namespace FileManagementSystem
{
    partial class LoginForm
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
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RememberLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.ForgotPassLinkLabel = new System.Windows.Forms.LinkLabel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.ProgramTitleLabel = new System.Windows.Forms.Label();
            this.HelpLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Location = new System.Drawing.Point(259, 189);
            this.userNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userNameTextBox.MaxLength = 60;
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(318, 31);
            this.userNameTextBox.TabIndex = 0;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(259, 254);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.MaxLength = 24;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(318, 31);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(137, 191);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(116, 25);
            this.UsernameLabel.TabIndex = 2;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(141, 257);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(112, 25);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(259, 358);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(168, 41);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RememberLoginCheckBox
            // 
            this.RememberLoginCheckBox.AutoSize = true;
            this.RememberLoginCheckBox.Location = new System.Drawing.Point(259, 308);
            this.RememberLoginCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.RememberLoginCheckBox.Name = "RememberLoginCheckBox";
            this.RememberLoginCheckBox.Size = new System.Drawing.Size(184, 29);
            this.RememberLoginCheckBox.TabIndex = 5;
            this.RememberLoginCheckBox.Text = "Remember Me";
            this.RememberLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // ForgotPassLinkLabel
            // 
            this.ForgotPassLinkLabel.AutoSize = true;
            this.ForgotPassLinkLabel.Location = new System.Drawing.Point(455, 366);
            this.ForgotPassLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ForgotPassLinkLabel.Name = "ForgotPassLinkLabel";
            this.ForgotPassLinkLabel.Size = new System.Drawing.Size(186, 25);
            this.ForgotPassLinkLabel.TabIndex = 6;
            this.ForgotPassLinkLabel.TabStop = true;
            this.ForgotPassLinkLabel.Text = "Forgot Password?";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(259, 417);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(168, 41);
            this.RegisterButton.TabIndex = 7;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // ProgramTitleLabel
            // 
            this.ProgramTitleLabel.AutoSize = true;
            this.ProgramTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramTitleLabel.Location = new System.Drawing.Point(255, 84);
            this.ProgramTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProgramTitleLabel.Name = "ProgramTitleLabel";
            this.ProgramTitleLabel.Size = new System.Drawing.Size(210, 73);
            this.ProgramTitleLabel.TabIndex = 8;
            this.ProgramTitleLabel.Text = "DSDB";
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(455, 425);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(115, 25);
            this.HelpLabel.TabIndex = 9;
            this.HelpLabel.TabStop = true;
            this.HelpLabel.Text = "Login Help";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(786, 600);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.ProgramTitleLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ForgotPassLinkLabel);
            this.Controls.Add(this.RememberLoginCheckBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userNameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox RememberLoginCheckBox;
        private System.Windows.Forms.LinkLabel ForgotPassLinkLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label ProgramTitleLabel;
        private System.Windows.Forms.LinkLabel HelpLabel;
    }
}

