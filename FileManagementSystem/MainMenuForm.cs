using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FileManagementSystem
{
    public partial class MainMenuForm : Form
    {
        public User userAccount;




        public MainMenuForm(String[] userData)
        {

            InitializeComponent();
            this.userAccount = new User(userData[0], userData[1], userData[2], userData[3], userData[4], userData[5]);
            Console.WriteLine(userAccount.userName);
            fileViewer.Url = new Uri($"C:/DSDB/{userAccount.userName}");
            

        }






        private void searchButton_Click(object sender, EventArgs e)
        {
            DirectoryInfo currentDir = new DirectoryInfo(fileViewer.Url.AbsolutePath);//Creates DirectoryInfo from the current fileViewer path
            FileInfo[] files = currentDir.GetFiles("*" + searchBar.Text + "*", SearchOption.AllDirectories);//creates an array of FileInfo objects by searching the currently directory and down for the text in the searchBar
            listView.Items.Clear();//Clears the previous items from the list, would be from the previous search
            foreach(FileInfo file in files)//For each file info, add the diretory name to the list
            {
                listView.Items.Add(file.Name + ": " + file.FullName);
            }
            listView.Update();//Updates the view of the list once all is done
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {

            String currentDirectory = Directory.GetCurrentDirectory();

            //Gives the current working directory in the fileviewer
            Uri location = fileViewer.Url;
            Console.WriteLine(location);




        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            showCurrentUser();
        }

        public void initalizeFiles()
        {
            fileViewer.Url = new Uri("C:/DSDB");
        }



        public void showCurrentUser()
        {
            MessageBox.Show(userAccount.userName);
        }






        public void getAccountInformation(User userAccount)
        {
            this.userAccount = userAccount;
            MessageBox.Show("Main menu received user account!");
        }

        private void fileViewer_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo($"C:/DSDB/{userAccount.userName}");
            DirectoryInfo[] folders = dir.GetDirectories();
            fileDropDown.Items.AddRange(folders);
            fileDropDown.Items.Add("Home Directory");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            String changeDir = fileDropDown.Text;

            if (changeDir == "Home Directory")
            {
                fileViewer.Url = new Uri($"C:/DSDB/{userAccount.userName}");
            }
            else
            {
                fileViewer.Url = new Uri($"C:/DSDB/{userAccount.userName}/{changeDir}");
            }

            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        
        }
    }
    
}
