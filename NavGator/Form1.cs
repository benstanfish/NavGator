using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace NavGator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOriginal_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "HTML files (*.htm, *.html)|*.htm;*.html;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                textBoxOriginal.Text = selectedFileName;
            }
        }

        private void buttonTargets_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "HTML files (*.htm, *.html)|*.htm;*.html;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                checkedListBoxTargets.Items.AddRange(openFileDialog1.FileNames);
                for (int i = 0; i < checkedListBoxTargets.Items.Count; i++)
                {
                    checkedListBoxTargets.SetItemChecked(i, true);
                }
            }
        }




        private int FindLine(string lookFor,
                             string fileName)
        {
            // returns the line number (Base 0) for the lookFor text.
            // if no file specified, returns -1.
            // if file does not contain the lookFor text, returns -2.
            // if other error occurs, returns -3.

            if (fileName == "")
            {
                return -1;
            }
            else
            {
                try
                {
                    var lines = File.ReadAllLines(fileName);
                    bool isFound = false;
                    foreach (var line in lines)
                    {
                        if (line.Contains(lookFor))
                        {
                            isFound = true;
                        }
                    }
                    if (isFound)
                    {
                        int counter = 0;
                        string line;
                        StreamReader sr = new StreamReader(fileName);
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.Contains(lookFor))
                            {
                                break;
                            }
                            counter++;
                        }
                        // Console.WriteLine(lookFor + " found at {0}", counter);
                        sr.Close();
                        return counter;
                    }
                    else
                    {
                        return -2;
                    }
                }
                catch
                {
                    return -3;
                }
            }
            
        }

        private void LoadLines()
        {
            int start = FindLine("<nav", textBoxOriginal.Text) + 1;
            int end = FindLine("</nav>", textBoxOriginal.Text) + 1;

            if (start < 1 || end < 1)
            {
                textBoxStartLine.Text = "";
                textBoxEndLine.Text = "";
            }
            else
            {
                textBoxStartLine.Text = start.ToString();
                textBoxEndLine.Text = end.ToString();
            }
        }

        private string[] BufferHead(string fileName)
        {
            int headLastLine = FindLine("<nav", fileName);
            using (StreamReader file = new StreamReader(fileName))
            {
                List<string> list = new List<string>();
                string temp = null;
                int i = 0;
                while ((temp = file.ReadLine()) != null)
                {
                    if (i < headLastLine)
                    {
                        list.Add(temp);
                    }
                    i++;
                }
                string[] lines = list.ToArray();
                string origFileDir = Path.GetDirectoryName(fileName);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(origFileDir, "bufferHead.txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                file.Close();
                return lines;
            }
        }

        private string[] BufferTail(string fileName)
        {
            int tailFirstLine = FindLine("</nav>", fileName);
            using (StreamReader file = new StreamReader(fileName))
            {
                List<string> list = new List<string>();
                string temp = null;
                int i = 0;
                while ((temp = file.ReadLine()) != null)
                {
                    if (i > tailFirstLine)
                    {
                        list.Add(temp);
                    }
                    i++;
                }
                string[] lines = list.ToArray();
                string origFileDir = Path.GetDirectoryName(fileName);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(origFileDir, "bufferTail.txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                file.Close();
                return lines;
            }
        }

        private string[] BufferNav(string fileName)
        {
            int headLastLine = FindLine("<nav", fileName);
            int tailFirstLine = FindLine("</nav>", fileName);
            using (StreamReader file = new StreamReader(fileName))
            {
                List<string> list = new List<string>();
                string temp = null;
                int i = 0;
                while ((temp = file.ReadLine()) != null)
                {
                    if (i > headLastLine - 1 && i < tailFirstLine + 1)
                    {
                        list.Add(temp);
                    }
                    i++;
                }
                string[] lines = list.ToArray();
                string origFileDir = Path.GetDirectoryName(fileName);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(origFileDir, "bufferNav.txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                file.Close();
                return lines;
            }
        }



        private void EchoNav()
        {
            int start = FindLine("<nav", textBoxOriginal.Text);
            int end = FindLine("</nav>", textBoxOriginal.Text);
            if (start < 1)
            {
            }
            else
            {
                using (StreamReader file = new StreamReader(textBoxOriginal.Text))
                {
                    List<string> list = new List<string>();
                    string temp = null;
                    int i = 0;
                    while ((temp = file.ReadLine()) != null)
                    {
                        if (i > start - 1 && i < end + 1)
                        {
                            list.Add(temp);
                        }
                        i++;
                    }
                    string[] lines = list.ToArray();
                    string origFileDir = Path.GetDirectoryName(textBoxOriginal.Text);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(origFileDir, "echo.log")))
                    {
                        foreach (string line in lines)
                            outputFile.WriteLine(line);
                    }
                    textBoxPreview.Text = string.Join("\r\n", lines);
                    file.Close();
                }
            }
        }

        private void WriteNewFile(string[] head, string[] nav, string[] tail, string targetFile, string targetFolder)
        {
            string myFile = Path.GetFileName(targetFile);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(targetFolder, myFile)))
            {
                foreach (string line in head)
                    outputFile.WriteLine(line);

                foreach (string line in nav)
                    outputFile.WriteLine(line);

                foreach (string line in tail)
                    outputFile.WriteLine(line);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            
            if (textBoxOriginal.Text == "")
            {
                MessageBox.Show("No file was selected.");
                textBoxStartLine.Text = "";
                textBoxEndLine.Text = "";
                textBoxPreview.Text = "";
            }
            else if (FindLine("<nav", textBoxOriginal.Text) == -2)
            {
                MessageBox.Show("No <nav></nav> section found in file. Will search for <body>.");
                int body = FindLine("<body", textBoxOriginal.Text);
                if (body > 0)
                {
                    textBoxStartLine.Text = body.ToString();
                }
                else
                {
                    textBoxStartLine.Text = "";
                    textBoxEndLine.Text = "";
                    textBoxPreview.Text = "";
                }
            }
            else
            {
                LoadLines();

                /*
                string[] head = BufferHead(textBoxOriginal.Text);
                string[] nav = BufferNav(@"C:\Users\benst\Documents\_JapaneseGrammar_ORG\_Experimental\_nav.html");
                string[] tail = BufferTail(textBoxOriginal.Text);

                string targetFile = @"C:\Users\benst\Documents\_JapaneseGrammar_ORG\_Experimental\_nav.html";

                WriteNewFile(head, nav, tail, targetFile, textBoxTargetFolder.Text);
                */

                EchoNav();
            }
            
        }


        public void ChooseFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (textBoxOriginal.Text != "")
            {
                fbd.SelectedPath = Path.GetDirectoryName(textBoxOriginal.Text);
            }

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxTargetFolder.Text = fbd.SelectedPath;
            }
            else if (textBoxOriginal.Text != "")
            {
                textBoxTargetFolder.Text = Path.GetDirectoryName(textBoxOriginal.Text);
            }
            else
            {
                textBoxTargetFolder.Text = "";
            }
        }
        private void buttonTargetFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenFolderOfFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Process.Start("explorer.exe", Path.GetDirectoryName(filePath));
            }
        }
        private void OpenFolder(string filePath)
        {
            if (File.Exists(filePath))
            {
                Process.Start("explorer.exe", filePath);
            }
        }

        private void buttonOriginalOpenFolder_Click(object sender, EventArgs e)
        {
            OpenFolder(textBoxOriginal.Text);
        }

        private void buttonOpenOutputFolder_Click(object sender, EventArgs e)
        {
            if (textBoxTargetFolder.Text != "")
            {
                Process.Start(textBoxTargetFolder.Text + "\\");
            }
        }
    }
}
