using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagementSystem
{
    public partial class ProfileForm : Form
    { 

        DatabaseConnection database = new DatabaseConnection();
        public User userAccount;

        public ProfileForm(User userAccount)
        {
            InitializeComponent();
            this.userAccount = userAccount;
            Console.WriteLine(userAccount.userName);
            this.Text = (userAccount.userName + "'s Profile");
        }

        /*private void getAccountErrors()
        {

            passwordError = database.passwordError;
            confirmPasswordError = database.confirmPasswordError;

        }
*/
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {

            String ErrorMessage = "";
            int Accepted = 0;

            if (New.Text.Length < 13)
            {
                ErrorMessage = ErrorMessage + "Password must be at least 14 characters.\n";
                New.BackColor = Color.Salmon;
                Accepted = 1;
            }

            if (New.Text != retypePass.Text)
            {
                ErrorMessage = ErrorMessage + "Passwords do not match!\n";
                New.BackColor = Color.Salmon;
                retypePass.BackColor = Color.Salmon;
                Accepted = 1;
            }

            if (Accepted == 0 && DatabaseConnection.UpdatePassword(Current.Text, New.Text, userAccount.userName))
            {

                this.Close();
            }

            else
            {
                Current.BackColor = Color.Salmon;
                MessageBox.Show(ErrorMessage + "\nIncorrect Password", "Try again");
            }

        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {

        }

        private void retypePass_TextChanged(object sender, EventArgs e)
        {
            //The password character is displayed as an asterisk.
            retypePass.PasswordChar = '*';
        }

        private void New_TextChanged(object sender, EventArgs e)
        {
            // The password character is displayed as an asterisk.
             New.PasswordChar = '*';
        }

        private void Current_TextChanged(object sender, EventArgs e)
        {
            // The password character is displayed as an asterisk.
             Current.PasswordChar = '*';
        }

        private void UserName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            /*Show(userAccount.userName);*/
            
        }
    }
}
