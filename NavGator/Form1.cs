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
            InitialButtons();

            NavStatus.isNavFound = false;
        }

        private void buttonOriginal_Click(object sender, EventArgs e)
        {
            ClearAll();

            OpenFileDialog openFileDialog1 = new OpenFileDialog();


            openFileDialog1.Filter = "HTML files (*.htm, *.html)|*.htm;*.html;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                textBoxOriginal.Text = selectedFileName;
                buttonLoad.PerformClick();
            }
        }

        private void buttonTargets_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (textBoxOriginal.Text != "")
            {
                openFileDialog1.InitialDirectory = Path.GetDirectoryName(textBoxOriginal.Text);
            }
            openFileDialog1.Filter = "HTML files (*.htm, *.html)|*.htm;*.html;";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.Multiselect = true;
            openFileDialog1.RestoreDirectory = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                checkedListBoxTargets.Items.AddRange(openFileDialog1.FileNames);
                for (int i = 0; i < checkedListBoxTargets.Items.Count; i++)
                {
                    checkedListBoxTargets.SetItemChecked(i, true);
                }
            }

            TestForCycle();
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

            if (start < 0 || end < 0)
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

        private string[] BufferHead(int lineNumber, string fileName)
        {

            using (StreamReader file = new StreamReader(fileName))
            {
                List<string> list = new List<string>();
                string temp = null;
                int i = 0;
                while ((temp = file.ReadLine()) != null)
                {
                    if (i < lineNumber)
                    {
                        list.Add(temp);
                    }
                    i++;
                }
                string[] lines = list.ToArray();
                /*
                string origFileDir = Path.GetDirectoryName(fileName);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(origFileDir, "bufferHead.txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                file.Close();
                */
                return lines;
            }
        }

        private string[] BufferTail(int lineNumber, string fileName)
        {
            using (StreamReader file = new StreamReader(fileName))
            {
                List<string> list = new List<string>();
                string temp = null;
                int i = 0;
                while ((temp = file.ReadLine()) != null)
                {
                    if (i > lineNumber)
                    {
                        list.Add(temp);
                    }
                    i++;
                }
                string[] lines = list.ToArray();
                /*
                string origFileDir = Path.GetDirectoryName(fileName);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(origFileDir, "bufferTail.txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                file.Close();
                */
                return lines;
            }
        }

        private string[] BufferNav(int start, int end, string fileName)
        {

            using (StreamReader file = new StreamReader(fileName))
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
                /*
                string origFileDir = Path.GetDirectoryName(fileName);
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(origFileDir, "bufferNav.txt")))
                {
                    foreach (string line in lines)
                        outputFile.WriteLine(line);
                }
                file.Close();
                */
                return lines;
            }
        }

        private string[] PreviewNav()
        {
            int start = FindLine("<nav", textBoxOriginal.Text);
            int end = FindLine("</nav>", textBoxOriginal.Text);
            if (start < 0)
            {
                return new string[0];
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
                    /*
                    string origFileDir = Path.GetDirectoryName(textBoxOriginal.Text);
                    using (StreamWriter outputFile = new StreamWriter(Path.Combine(origFileDir, "_echo.log")))
                    {
                        foreach (string line in lines)
                            outputFile.WriteLine(line);
                    }
                    */
                    textBoxPreview.Text = string.Join("\r\n", lines);
                    file.Close();
                    return lines;
                }
            }
        }

        private void PreLoad()
        {
            if (textBoxTargetFolder.Text == "")
            {
                String destDir = Path.GetDirectoryName(textBoxOriginal.Text) + @"\";
                textBoxTargetFolder.Text = destDir;
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
                NavStatus.isNavFound = false;
                textBoxStartLine.Text = "";
                textBoxEndLine.Text = "";
                textBoxPreview.Text = "";
            }
            else if (FindLine("<nav", textBoxOriginal.Text) == -2)
            {
                MessageBox.Show("No <nav></nav> section found in file. Will search for <body>.");
                NavStatus.isNavFound = false;
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
                NavStatus.isNavFound = true;
                LoadLines();
                PreviewNav();
                PreLoad();
            }

        }


        public void ChooseFolder(string path = "")
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (path != "")
            {
                fbd.SelectedPath = path;
            }

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
            ChooseFolder(textBoxOriginal.Text + @"\");
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
            OpenFolderOfFile(textBoxOriginal.Text);
        }

        private void buttonOpenOutputFolder_Click(object sender, EventArgs e)
        {
            if (textBoxTargetFolder.Text != "")
            {
                Process.Start(textBoxTargetFolder.Text + @"\");
            }
        }

        private int[] TestTargetFile(string fileName)
        {
            // determines if TargetFile has <nav> or <body>
            int navStart = FindLine("<nav", fileName);
            int navEnd = FindLine("</nav>", fileName);
            int body = FindLine("<body", fileName);
            int[] ret = { navStart, navEnd, body };

            return ret;
        }

        private string FormattedNow()
        {
            string dt = DateTime.Now.ToString("yyyyMMddhhmmss");
            Console.WriteLine(dt);
            return dt;
        }

        private void MakeDir(string dirName)
        {
            System.IO.Directory.CreateDirectory(dirName);
        }

        private void DupFile(string sourceFile, string dir)
        {
            try
            {
                if (dir.Substring(dir.Length - 1) == @"\")
                {
                }
                else
                {
                    dir = dir + @"\";
                }
                string destFile = dir + Path.GetFileName(sourceFile);
                File.Copy(sourceFile, destFile, true);
            }
            catch (IOException iox)
            {
                Console.WriteLine(iox.Message);
            }
        }

        private void CreateBackups(string[] files)
        {
            String destDir = Path.GetDirectoryName(textBoxOriginal.Text) + @"\" + FormattedNow() + @"_Backup\";
            MakeDir(destDir);
            foreach (string file in files)
            {
                DupFile(file, destDir);
            }
        }

        private void TestCreateBackups()
        {
            String destDir = Path.GetDirectoryName(textBoxOriginal.Text) + @"\" + FormattedNow() + @"_Backup\";
            Console.WriteLine(destDir);
            MakeDir(destDir);
            foreach (string item in checkedListBoxTargets.CheckedItems)
            {
                // Write code here to operate on each file
                DupFile(item, destDir);
            }
        }

        private void CycleTargets()
        {
            DateTime st = DateTime.Now;
            int start = FindLine("<nav", textBoxOriginal.Text);
            int end = FindLine("</nav>", textBoxOriginal.Text);
            string[] nav = BufferNav(start, end, textBoxOriginal.Text);
            string nowFormatted = FormattedNow();
            string rootPrefix;

            if (textBoxTargetFolder.Text != "")
            {
                rootPrefix = textBoxTargetFolder.Text + @"\";
            }
            else if (textBoxOriginal.Text != "")
            {
                rootPrefix = textBoxOriginal.Text + @"\";
            }
            else
            {
                MessageBox.Show("No destination folder selected.");
                rootPrefix = textBoxOriginal.Text + @"\";
            }

            string backupDir = rootPrefix + nowFormatted + @"_backups\";
            string editedDir = rootPrefix + nowFormatted + @"_edited\";
            MakeDir(backupDir);
            MakeDir(editedDir);

            foreach (string item in checkedListBoxTargets.CheckedItems)
            {
                // Write code here to operate on each file
                DupFile(item, backupDir);

                int[] vals = TestTargetFile(item);
                string[] head;
                string[] tail;
                if (vals[0] > 0 && vals[1] > 0)
                {
                    head = BufferHead(vals[0], item);
                    tail = BufferTail(vals[1], item);
                    WriteNewFile(head, nav, tail, item, editedDir);
                }
                else if (vals[2] > 0)
                {
                    head = BufferHead(vals[2] + 1, item);
                    tail = BufferTail(vals[2], item);
                    WriteNewFile(head, nav, tail, item, editedDir);
                }
                else
                {
                    continue;
                }
            }

            DateTime ed = DateTime.Now;
            TimeSpan ts = ed - st;
            MessageBox.Show("Files edited, job completed. Total time: " + ts.ToString("fff") + " msec.");
        }

        private void buttonCycle_Click(object sender, EventArgs e)
        {
            CycleTargets();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (checkedListBoxTargets.CheckedItems.Count > 0)
            {
                TestCreateBackups();
            }
            else
            {
                MessageBox.Show("Please select files to be duplicated.");
            }
        }


        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form about = new Form2();
            about.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ClearAll()
        {
            textBoxOriginal.Text = "";
            textBoxPreview.Text = "";
            textBoxTargetFolder.Text = "";
            checkedListBoxTargets.Items.Clear();
        }

        private void EnableButton(Button button, bool isEnabled)
        {
            if (isEnabled == true) {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        private void InitialButtons()
        {
            EnableButton(buttonLoad, false);
            EnableButton(buttonTargetFolder, false);
            EnableButton(buttonCycle, false);
        }

        private void TestForOriginal()
        {
            if (textBoxOriginal.Text != "")
            {
                EnableButton(buttonLoad, true);
                EnableButton(buttonTargetFolder, true);
            }
            else if (textBoxOriginal.Text == "")
            {
                EnableButton(buttonLoad, false);
                EnableButton(buttonTargetFolder, false);
            }
        }
        private void TestForCycle()
        {
            if (textBoxOriginal.Text != "" && textBoxTargetFolder.Text != "" && checkedListBoxTargets.CheckedItems.Count > 0 && NavStatus.isNavFound == true)
            {
                EnableButton(buttonCycle, true);
            }
            else
            {
                EnableButton(buttonCycle, false);
            }
        }

        private void UncheckAll()
        {
            while (checkedListBoxTargets.CheckedIndices.Count > 0)
            {
                checkedListBoxTargets.SetItemChecked(checkedListBoxTargets.CheckedIndices[0], false);
            }

        }
        private void CheckAll()
        {
            for (int i = 0; i < checkedListBoxTargets.Items.Count; i++)
            {
                checkedListBoxTargets.SetItemChecked(i, true);
            }
        }
        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        private void checkAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckAll();
        }
        private void checkNoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UncheckAll();
        }

        private void textBoxOriginal_TextChanged(object sender, EventArgs e)
        {
            TestForOriginal();
        }

        private void textBoxTargetFolder_TextChanged(object sender, EventArgs e)
        {
            TestForCycle();
        }

        private void checkedListBoxTargets_SelectedIndexChanged(object sender, EventArgs e)
        {
            TestForCycle();
        }

        private void buttonCheckAll_Click(object sender, EventArgs e)
        {
            CheckAll();
        }

        private void buttonCheckNone_Click(object sender, EventArgs e)
        {
            UncheckAll();
        }

        private void resetAllToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
