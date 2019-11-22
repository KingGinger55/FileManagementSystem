using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManagementSystem
{
    public partial class LoginForm : Form
    {
        private String[] userData;


        DatabaseConnection database = new DatabaseConnection();


        public LoginForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var RegisterScreen = new RegisterForm();
            RegisterScreen.Show();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            String userName = userNameTextBox.Text;
            String password = passwordTextBox.Text;
            this.userData = DatabaseConnection.Login(userName, password);

            if (userData.Length != 0)
            {
                for (int i = 0; i < userData.Length; i++)
                {
                    //Console.WriteLine(userData[i]);
                }
                this.Hide();
            }
            else
            {
                userNameTextBox.BackColor = Color.Salmon;
                passwordTextBox.BackColor = Color.Salmon;
            }



        }



        public String[] PushData()
        {


            return userData;
        }






        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            passwordTextBox.PasswordChar = '*';
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Closes application if login screen is exited.  This is so the main menu does not load.
            if (database.loginSuccess == false)
            {
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
