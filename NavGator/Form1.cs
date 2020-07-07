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

        public void ChooseFolder()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
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

        private bool FindNav(string fileName)
        {
            var lines = File.ReadAllLines(fileName);
            bool aVal = false;
            foreach (var line in lines)
            {
                if (line.Contains("<nav") || line.Contains("</nav>"))
                {
                    aVal = true;
                }
            }
            return aVal;
        }

        private static int FindStart(string fileName)
        {
            if (fileName == "")
            {
                return -1;
            }
            else
            {
                try
                {
                    int counter = 0;
                    string line;

                    StreamReader sr = new StreamReader(fileName);
 
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("<nav"))
                        {
                            break;
                        }
                        counter++;
                    }

                    Console.WriteLine("Nav code spans from lines: {0}", counter);

                    sr.Close();
                    return counter;
                }
                catch
                {
                    return -2;
                }
            }
                
        }

        private static int FindEnd(string fileName)
        {
            if (fileName == "")
            {
                return -1;
            }
            else
            {
                try
                {
                    int counter = 0;
                    string line;

                    StreamReader sr = new StreamReader(fileName);

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line.Contains("</nav>"))
                        {
                            break;
                        }
                        counter++;
                    }

                    Console.WriteLine("Nav code spans from lines: {0}", counter);

                    sr.Close();
                    return counter;
                }
                catch
                {
                    return -2;
                }
            }

        }

        private void LoadLines()
        {
            int start = FindStart(textBoxOriginal.Text) + 1;
            int end = FindEnd(textBoxOriginal.Text) + 1;

            textBoxStartLine.Text = start.ToString();
            textBoxEndLine.Text = end.ToString();
        }

        private string[] BufferHead(string fileName)
        {

            int headLastLine = FindStart(fileName);
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

            int tailFirstLine = FindEnd(fileName);
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

            int headLastLine = FindStart(fileName);
            int tailFirstLine = FindEnd(fileName);
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
            int start = FindStart(textBoxOriginal.Text);
            int end = FindEnd(textBoxOriginal.Text);
            if (start == -1 || start == -2)
            {
                MessageBox.Show("No file selected");
            }
            else
            {
                // MessageBox.Show(start.ToString() + " to " + end.ToString());
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
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(origFileDir, "echoNAV.txt")))
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


        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(FindNav(textBoxOriginal.Text));
            if (FindNav(textBoxOriginal.Text) == false)
            {
                MessageBox.Show("No <Nav></Nav> Section Found!");
                textBoxStartLine.Text = "";
                textBoxEndLine.Text = "";
                textBoxPreview.Text = "";
            }
            else
            {
                LoadLines();

                string[] head = BufferHead(textBoxOriginal.Text);
                string[] nav = BufferNav(@"C:\Users\benst\Documents\_JapaneseGrammar_ORG\_Experimental\_nav.html");
                string[] tail = BufferTail(textBoxOriginal.Text);

                string targetFile = @"C:\Users\benst\Documents\_JapaneseGrammar_ORG\_Experimental\_nav.html";

                WriteNewFile(head, nav, tail, targetFile, textBoxTargetFolder.Text);
                EchoNav();
            }

        }

        private void buttonTargetFolder_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
    }
}
