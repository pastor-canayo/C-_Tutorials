namespace CreateFolderBackUp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            original = new TextBox();
            label2 = new Label();
            backup = new TextBox();
            originalBrowse = new Button();
            backupBrowse = new Button();
            createBackupFolder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 48);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Source";
            // 
            // original
            // 
            original.Location = new Point(322, 40);
            original.Name = "original";
            original.Size = new Size(253, 23);
            original.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 111);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 0;
            label2.Text = "Destination";
            // 
            // backup
            // 
            backup.Location = new Point(322, 108);
            backup.Name = "backup";
            backup.Size = new Size(253, 23);
            backup.TabIndex = 2;
            // 
            // originalBrowse
            // 
            originalBrowse.Location = new Point(641, 46);
            originalBrowse.Name = "originalBrowse";
            originalBrowse.Size = new Size(75, 23);
            originalBrowse.TabIndex = 3;
            originalBrowse.Text = "Browse";
            originalBrowse.UseVisualStyleBackColor = true;
            originalBrowse.Click += originalBrowse_Click;
            // 
            // backupBrowse
            // 
            backupBrowse.Location = new Point(641, 111);
            backupBrowse.Name = "backupBrowse";
            backupBrowse.Size = new Size(75, 23);
            backupBrowse.TabIndex = 4;
            backupBrowse.Text = "Browse";
            backupBrowse.UseVisualStyleBackColor = true;
            backupBrowse.Click += backupBrowse_Click;
            // 
            // createBackupFolder
            // 
            createBackupFolder.Location = new Point(303, 228);
            createBackupFolder.Name = "createBackupFolder";
            createBackupFolder.Size = new Size(297, 23);
            createBackupFolder.TabIndex = 5;
            createBackupFolder.Text = "Create Backup Folder";
            createBackupFolder.UseVisualStyleBackColor = true;
            createBackupFolder.Click += createBackupFolder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createBackupFolder);
            Controls.Add(backupBrowse);
            Controls.Add(originalBrowse);
            Controls.Add(backup);
            Controls.Add(original);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox original;
        private Label label2;
        private TextBox backup;
        private Button originalBrowse;
        private Button backupBrowse;
        private Button createBackupFolder;
    }
}