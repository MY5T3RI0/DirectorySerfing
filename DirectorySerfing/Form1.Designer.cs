
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
            this.downloadButton = new System.Windows.Forms.Button();
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
            this.listOfFiles.Size = new System.Drawing.Size(403, 431);
            this.listOfFiles.TabIndex = 0;
            // 
            // openDirectory
            // 
            this.openDirectory.Location = new System.Drawing.Point(12, 449);
            this.openDirectory.Name = "openDirectory";
            this.openDirectory.Size = new System.Drawing.Size(198, 50);
            this.openDirectory.TabIndex = 1;
            this.openDirectory.Text = "Select directory";
            this.openDirectory.UseVisualStyleBackColor = true;
            this.openDirectory.Click += new System.EventHandler(this.openDirectory_Click);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(216, 449);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(198, 50);
            this.downloadButton.TabIndex = 2;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 511);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.openDirectory);
            this.Controls.Add(this.listOfFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfFiles;
        private System.Windows.Forms.Button openDirectory;
        private System.Windows.Forms.Button downloadButton;
    }
}

