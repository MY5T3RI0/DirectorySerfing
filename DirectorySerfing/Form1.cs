using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DirectorySerfing
{
    public partial class Form1 : Form
    {
        private FileInfo[] files { get; set; }
        private DirectoryInfo directory { get; set; }
        public List<string> outDirectories { get; set; }

        public Form1()
        {
            InitializeComponent();
            outDirectories = new List<string>();
        }

        private void openDirectory_Click(object sender, EventArgs e)
        {
            string folderPath = string.Empty;

            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                    folderPath = folderBrowser.SelectedPath;

            directory = new DirectoryInfo(folderPath);

            files = directory.GetFiles();

            listOfFiles.Items.Clear();
            listOfFiles.Items.AddRange(files.Select(f => f.Name).ToArray());

            watcher.Path = folderPath;

            watcher.NotifyFilter = NotifyFilters.Attributes
                                | NotifyFilters.CreationTime
                                | NotifyFilters.DirectoryName
                                | NotifyFilters.FileName
                                | NotifyFilters.LastAccess
                                | NotifyFilters.LastWrite
                                | NotifyFilters.Security
                                | NotifyFilters.Size;

        }

        private void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            files = directory.GetFiles();
            listOfFiles.Items.Clear();
            listOfFiles.Items.AddRange(files.Select(f => f.Name).ToArray());

            using (FileContext fc = new FileContext())
            {
                foreach (var directory in outDirectories)
                    foreach (var file in files)
                    {
                        System.IO.File.Copy(file.FullName, directory + "\\" + file.Name, true);

                        var File = new File
                        {
                            Name = file.Name,
                            Size = file.Length,
                            Extention = file.Extension,
                            BaseDir = file.Directory.FullName,
                            CopyDate = DateTime.Now,
                            CreationDate = file.CreationTime,
                            LastChange = file.LastWriteTime,
                            Hash = file.GetHashCode()
                        };

                        Directory Directory;
                        var ExistFile = fc.Files.FirstOrDefault(f => f.Name == File.Name);

                        if (ExistFile == default)
                            Directory = new Directory { FileId = File.FileId, Name = directory };
                        else
                            Directory = new Directory { FileId = ExistFile.FileId, Name = directory };

                        bool isFileExist = false;
                        bool isDirectoryExist = false;

                        foreach (var f in fc.Files)
                            isFileExist |= f.BaseDir == File.BaseDir && f.Name == File.Name;
                        if(!isFileExist) fc.Files.Add(File);

                        foreach (var d in fc.Directories)
                            isDirectoryExist |= d.FileId == Directory.FileId && d.Name == Directory.Name;
                        if (!isDirectoryExist) fc.Directories.Add(Directory);

                        fc.SaveChanges();
                    }
            }
        }

        private void AddDirectory_Click(object sender, EventArgs e)
        {
            string folderPath = string.Empty;

            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                    folderPath = folderBrowser.SelectedPath;

            listOfDirectories.Items.Add(new DirectoryInfo(folderPath).Name);
            outDirectories.Add(folderPath);
            watcher_Changed(sender, new FileSystemEventArgs(new WatcherChangeTypes(), "", ""));
        }
    }
}