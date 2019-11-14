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
        private int passwordError;
        private int confirmPasswordError;

        DatabaseConnection database = new DatabaseConnection();

        public ProfileForm()
        {
            InitializeComponent();
        }

        private void getAccountErrors()
        {
            
            passwordError = database.passwordError;
            confirmPasswordError = database.confirmPasswordError;
            
        }

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

            getAccountErrors();
            if (passwordError == 1 || confirmPasswordError == 1)
            {
                Current.BackColor = System.Drawing.Color.Salmon;
                retypePass.BackColor = System.Drawing.Color.Salmon;

            }

            if (New.Text.Length < 13)
            {
                ErrorMessage = ErrorMessage + "Password must be at least 14 characters.\n";
                Accepted = 1;
            }

            if (New.Text != retypePass.Text)
            {
                //MessageBox.Show("Passwords do not match!", "Try again");
                ErrorMessage = ErrorMessage + "Passwords do not match!\n";
                Accepted = 1;
            }

            MessageBox.Show(ErrorMessage, "Try again");

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

        }
    }
}
