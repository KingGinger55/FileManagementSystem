﻿using System;
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
        public MainMenuForm()
        {
            InitializeComponent();
            fileViewer.Url = new Uri("C:\\DSDB");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //var files = Directory.GetFiles("C:\\DSDB", textBox1.Text, SearchOption.TopDirectoryOnly);
            //For now we can search for specific file paths and it breaks if they are wrong
            //We want to use the top commented line, or some variation on it, to find all the files that may fit the search and show them
            fileViewer.Url = new Uri(textBox1.Text);
        }
    }
}
