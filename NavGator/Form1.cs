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

        static string ReadMyLines(string file, int start, int end)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                    for (int i = start; i < end; i++)
                        sr.ReadLine();
                    return sr.ReadLine();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int start = FindStart(textBoxOriginal.Text);
            int end = FindEnd(textBoxOriginal.Text);
            if (start == -1 || start == -2)
            {
                MessageBox.Show("No file selected");
            }
            else
            {
                //MessageBox.Show(start.ToString() + " to " + end.ToString());
                using (StreamReader file = new StreamReader(textBoxOriginal.Text))
                {
                    List<string> list = new List<string>();
                    // string myText = null;
                    string temp = null;
                    int i = 0;

                    while ((temp = file.ReadLine()) != null)
                    {
                        if (i > start -1 && i < end + 1)
                        {
                            list.Add(temp);
                        }
                        i++;
                    }


                    /*
                    while ((temp = file.ReadLine()) != null)
                    {
                        if (i == start)
                        {
                            myText = temp;
                        }
                        else if (i > start && i < end + 1)
                        {
                            myText += "\r\n" + temp;
                        }
                        i++;
                    }
                    */


                    string[] lines = list.ToArray();


                    string origFileDir = Path.GetDirectoryName(textBoxOriginal.Text);
                    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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



    }
}
