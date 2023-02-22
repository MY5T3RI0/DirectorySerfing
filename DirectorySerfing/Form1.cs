using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorySerfing
{
    public partial class Form1 : Form
    {
        private FileInfo[] files { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void openDirectory_Click(object sender, EventArgs e)
        {
            var folderPath = string.Empty;

            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified directory
                    folderPath = folderBrowser.SelectedPath;

                    DirectoryInfo directory = new DirectoryInfo(folderPath);

                    //Read the contents of the directory
                    files = directory.GetFiles();

                    listOfFiles.Items.AddRange(files.Select(f => f.Name).ToArray());
                }
            }
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            using(FileContext fc = new FileContext())
            {
                fc.Files.RemoveRange(fc.Files);

                foreach(var file in files)
                    fc.Files.Add(new File { Name = file.Name, Size = file.Length, Extention = file.Extension});

                fc.SaveChanges();

                var users = fc.Files;
                listOfFiles.Items.AddRange(users.Select(f => f.Size.ToString()).ToArray());
            }
        }
    }
}
