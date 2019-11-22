namespace FileManagementSystem
{
    partial class ProfileForm
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
            this.NewPassword = new System.Windows.Forms.Label();
            this.New = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Authenticate = new System.Windows.Forms.Label();
            this.retypePass = new System.Windows.Forms.TextBox();
            this.Current = new System.Windows.Forms.TextBox();
            this.ConfirmNew = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Location = new System.Drawing.Point(92, 236);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(154, 25);
            this.NewPassword.TabIndex = 7;
            this.NewPassword.Text = "New Password";
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(309, 230);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(417, 31);
            this.New.TabIndex = 11;
            this.New.TextChanged += new System.EventHandler(this.New_TextChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(118, 430);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(122, 62);
            this.Save.TabIndex = 12;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(526, 430);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(122, 62);
            this.Cancel.TabIndex = 13;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // Authenticate
            // 
            this.Authenticate.AutoSize = true;
            this.Authenticate.Location = new System.Drawing.Point(63, 137);
            this.Authenticate.Name = "Authenticate";
            this.Authenticate.Size = new System.Drawing.Size(183, 25);
            this.Authenticate.TabIndex = 14;
            this.Authenticate.Text = "Current Password";
            // 
            // retypePass
            // 
            this.retypePass.ForeColor = System.Drawing.SystemColors.WindowText;
            this.retypePass.Location = new System.Drawing.Point(309, 333);
            this.retypePass.Name = "retypePass";
            this.retypePass.Size = new System.Drawing.Size(417, 31);
            this.retypePass.TabIndex = 15;
            this.retypePass.TextChanged += new System.EventHandler(this.retypePass_TextChanged);
            // 
            // Current
            // 
            this.Current.Location = new System.Drawing.Point(309, 131);
            this.Current.Name = "Current";
            this.Current.Size = new System.Drawing.Size(417, 31);
            this.Current.TabIndex = 16;
            this.Current.TextChanged += new System.EventHandler(this.Current_TextChanged);
            // 
            // ConfirmNew
            // 
            this.ConfirmNew.AutoSize = true;
            this.ConfirmNew.Location = new System.Drawing.Point(66, 339);
            this.ConfirmNew.Name = "ConfirmNew";
            this.ConfirmNew.Size = new System.Drawing.Size(180, 25);
            this.ConfirmNew.TabIndex = 17;
            this.ConfirmNew.Text = "Retype Password";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 600);
            this.Controls.Add(this.ConfirmNew);
            this.Controls.Add(this.Current);
            this.Controls.Add(this.retypePass);
            this.Controls.Add(this.Authenticate);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.New);
            this.Controls.Add(this.NewPassword);
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.TextBox New;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label Authenticate;
        private System.Windows.Forms.TextBox retypePass;
        private System.Windows.Forms.TextBox Current;
        private System.Windows.Forms.Label ConfirmNew;
    }
}

