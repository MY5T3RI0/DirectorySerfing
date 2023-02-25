
namespace DirectorySerfing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listOfFiles = new System.Windows.Forms.ListBox();
            this.openDirectory = new System.Windows.Forms.Button();
            this.watcher = new System.IO.FileSystemWatcher();
            this.AddDirectory = new System.Windows.Forms.Button();
            this.listOfDirectories = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfFiles
            // 
            this.listOfFiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listOfFiles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOfFiles.FormattingEnabled = true;
            this.listOfFiles.Location = new System.Drawing.Point(12, 12);
            this.listOfFiles.Name = "listOfFiles";
            this.listOfFiles.Size = new System.Drawing.Size(198, 431);
            this.listOfFiles.TabIndex = 0;
            // 
            // openDirectory
            // 
            this.openDirectory.Location = new System.Drawing.Point(216, 12);
            this.openDirectory.Name = "openDirectory";
            this.openDirectory.Size = new System.Drawing.Size(198, 50);
            this.openDirectory.TabIndex = 1;
            this.openDirectory.Text = "Select input directory";
            this.openDirectory.UseVisualStyleBackColor = true;
            this.openDirectory.Click += new System.EventHandler(this.openDirectory_Click);
            // 
            // watcher
            // 
            this.watcher.EnableRaisingEvents = true;
            this.watcher.SynchronizingObject = this;
            this.watcher.Changed += new System.IO.FileSystemEventHandler(this.watcher_Changed);
            this.watcher.Created += new System.IO.FileSystemEventHandler(this.watcher_Changed);
            this.watcher.Deleted += new System.IO.FileSystemEventHandler(this.watcher_Changed);
            this.watcher.Renamed += new System.IO.RenamedEventHandler(this.watcher_Changed);
            // 
            // AddDirectory
            // 
            this.AddDirectory.Location = new System.Drawing.Point(216, 68);
            this.AddDirectory.Name = "AddDirectory";
            this.AddDirectory.Size = new System.Drawing.Size(198, 50);
            this.AddDirectory.TabIndex = 3;
            this.AddDirectory.Text = "Add output directory";
            this.AddDirectory.UseVisualStyleBackColor = true;
            this.AddDirectory.Click += new System.EventHandler(this.AddDirectory_Click);
            // 
            // listOfDirectories
            // 
            this.listOfDirectories.FormattingEnabled = true;
            this.listOfDirectories.Location = new System.Drawing.Point(217, 127);
            this.listOfDirectories.Name = "listOfDirectories";
            this.listOfDirectories.Size = new System.Drawing.Size(197, 316);
            this.listOfDirectories.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.listOfDirectories);
            this.Controls.Add(this.AddDirectory);
            this.Controls.Add(this.openDirectory);
            this.Controls.Add(this.listOfFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.watcher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listOfFiles;
        private System.Windows.Forms.Button openDirectory;
        private System.IO.FileSystemWatcher watcher;
        private System.Windows.Forms.ListBox listOfDirectories;
        private System.Windows.Forms.Button AddDirectory;
    }
}

