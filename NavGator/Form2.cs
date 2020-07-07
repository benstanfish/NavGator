using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NavGator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Info();
        }

        private void Info()
        {
            labelVersion.Text = "v0.4";
            labelDeveloper.Text = "Ben Fisher, Copyright (C) 2020, All Rights Reserved";
            textBoxAbout.Text = 
                "This application copies the <nav></nav> data from a source " +
                "html file to several selected html files. If the destination file(s) " +
                "do not contain a <nav></nav> section this app inserts it immediately " +
                "following the <body> tag. This app also makes a backup copy of the " +
                "selected target files, as well as a modified version.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
