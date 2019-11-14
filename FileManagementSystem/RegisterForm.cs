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
        private int userNameError;
        private int fNameError;
        private int lNameError;
        private int emailError;
        private int passwordError;
        private int confirmPasswordError;
        private int securityQuestionError;
        private int securityAnswerError;
        private int closeWindow;
        
        //Database connection Class, for performing queries on the DB
        DatabaseConnection database = new DatabaseConnection();


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            //Creates an admin from the registration form, this will need to be modified so that all users arent admins (found in databaseConnection class)
            database.CreateUser(usernameTextBox.Text, emailTextBox.Text, firstNameTextBox.Text, lastNameTextBox.Text, passwordTextBox.Text, retypePassTextBox.Text, securityQuestionComboBox.Text, securityAnswerTextbox.Text);


            //This method updates the class variables above, if the variables contain a 1 then the text field related to the variable is highlighted.
            getRegisterErrors();


            //Text field error checking
            if (userNameError == 1)
            {
                usernameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            if (fNameError == 1)
            {
                firstNameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            if (lNameError == 1)
            {
                lastNameTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            if (emailError == 1)
            {
                emailTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            if (passwordError == 1 || confirmPasswordError == 1)
            {
                passwordTextBox.BackColor = System.Drawing.Color.Salmon;
                retypePassTextBox.BackColor = System.Drawing.Color.Salmon;
            }
            if (securityQuestionError == 1)
            {
                securityQuestionComboBox.BackColor = System.Drawing.Color.Salmon;
            }
            if (securityAnswerError == 1)
            {
                securityAnswerTextbox.BackColor = System.Drawing.Color.Salmon;
            }
            //Closes the register form upon successful admin creation
            if(closeWindow == 1)
            {
                this.Close();
            }
        }

        
        private void retypePassTextBox_TextChanged(object sender, EventArgs e)
        {
         
            //The password character is displayed as an asterisk.
            retypePassTextBox.PasswordChar = '*';
        }


        //This method updates the class variables above, if the variables contain a 1 then the text field related to the variable is highlighted.
        private void getRegisterErrors()
        {
            userNameError = database.userNameError;
            fNameError = database.fNameError;
            lNameError = database.lNameError;
            emailError = database.emailError;
            passwordError = database.passwordError;
            confirmPasswordError = database.confirmPasswordError;
            securityQuestionError = database.securityQuestionError;
            securityAnswerError = database.securityAnswerError;
            closeWindow = database.closeWindow;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
    }

}

