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


    public partial class RegisterForm : Form
    {

        //Database connection Class, for performing queries on the DB
        DatabaseConnection database = new DatabaseConnection();


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            


            int[] errorArray = DatabaseConnection.AuthenticateRegistrationForm(usernameTextBox.Text, emailTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, passwordTextBox.Text, retypePassTextBox.Text, securityQuestionComboBox.Text, securityAnswerTextbox.Text);
            TextBox[] boxes = { usernameTextBox, emailTextBox, firstNameTextBox, lastNameTextBox, passwordTextBox, retypePassTextBox, securityAnswerTextbox };


            int errorSum = 0;

            for (int i = 0; i < errorArray.Length - 1; i++)
            {
                errorSum += errorArray[i];
                if (errorArray[i] == 1)
                {
                    boxes[i].BackColor = Color.Salmon;
                }
              
            }
            if (errorArray[6] == 1)
            {
                securityQuestionComboBox.BackColor = Color.Salmon;
            }

            if (errorSum == 0)
            {
                //Creates an admin from the registration form, this will need to be modified so that all users arent admins (found in databaseConnection class)
                DatabaseConnection.CreateUser(usernameTextBox.Text, emailTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, passwordTextBox.Text, retypePassTextBox.Text, securityQuestionComboBox.Text, securityAnswerTextbox.Text);
                this.Close();
            }

            errorSum = 0;
        }
    

        private void retypePassTextBox_TextChanged(object sender, EventArgs e)
        {

            //The password character is displayed as an asterisk.
            retypePassTextBox.PasswordChar = '*';
        }


      

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }

}

