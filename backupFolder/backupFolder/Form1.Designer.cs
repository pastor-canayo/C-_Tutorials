namespace backupFolder
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
            originalButton = new Button();
            label1 = new Label();
            original = new TextBox();
            textBox2 = new TextBox();
            backup = new Label();
            backupButton = new Button();
            createButton = new Button();
            SuspendLayout();
            // 
            // originalButton
            // 
            originalButton.Location = new Point(629, 54);
            originalButton.Name = "originalButton";
            originalButton.Size = new Size(75, 23);
            originalButton.TabIndex = 0;
            originalButton.Text = "Browse";
            originalButton.UseVisualStyleBackColor = true;
            originalButton.Click += originalButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 58);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Original";
            // 
            // original
            // 
            original.Location = new Point(301, 50);
            original.Name = "original";
            original.Size = new Size(275, 23);
            original.TabIndex = 2;
            original.TextChanged += original_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(301, 138);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(275, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // backup
            // 
            backup.AutoSize = true;
            backup.Location = new Point(159, 134);
            backup.Name = "backup";
            backup.Size = new Size(46, 15);
            backup.TabIndex = 4;
            backup.Text = "Backup";
            // 
            // backupButton
            // 
            backupButton.Location = new Point(629, 138);
            backupButton.Name = "backupButton";
            backupButton.Size = new Size(75, 23);
            backupButton.TabIndex = 5;
            backupButton.Text = "Browse";
            backupButton.UseVisualStyleBackColor = true;
            backupButton.Click += backupButton_Click;
            // 
            // createButton
            // 
            createButton.Location = new Point(301, 254);
            createButton.Name = "createButton";
            createButton.Size = new Size(260, 23);
            createButton.TabIndex = 6;
            createButton.Text = "Create Backup Folder";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createButton);
            Controls.Add(backupButton);
            Controls.Add(backup);
            Controls.Add(textBox2);
            Controls.Add(original);
            Controls.Add(label1);
            Controls.Add(originalButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button originalButton;
        private Label label1;
        private TextBox original;
        private TextBox textBox2;
        private Label backup;
        private Button backupButton;
        private Button createButton;
    }
}