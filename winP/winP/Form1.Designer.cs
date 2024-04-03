namespace winP
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
            header = new Panel();
            headerControl1 = new Controls.HeaderControl();
            navigation = new Panel();
            mainArea = new Panel();
            anotherControl1 = new Controls.AnotherControl();
            extraControl1 = new Controls.extraControl();
            header.SuspendLayout();
            navigation.SuspendLayout();
            mainArea.SuspendLayout();
            SuspendLayout();
            // 
            // header
            // 
            header.Controls.Add(headerControl1);
            header.Dock = DockStyle.Top;
            header.Location = new Point(0, 0);
            header.Name = "header";
            header.Size = new Size(800, 100);
            header.TabIndex = 0;
            // 
            // headerControl1
            // 
            headerControl1.BackColor = SystemColors.MenuHighlight;
            headerControl1.Dock = DockStyle.Fill;
            headerControl1.Location = new Point(0, 0);
            headerControl1.Name = "headerControl1";
            headerControl1.Size = new Size(800, 100);
            headerControl1.TabIndex = 0;
            // 
            // navigation
            // 
            navigation.Controls.Add(extraControl1);
            navigation.Dock = DockStyle.Left;
            navigation.Location = new Point(0, 100);
            navigation.Name = "navigation";
            navigation.Size = new Size(180, 350);
            navigation.TabIndex = 1;
            // 
            // mainArea
            // 
            mainArea.Controls.Add(anotherControl1);
            mainArea.Dock = DockStyle.Fill;
            mainArea.Location = new Point(180, 100);
            mainArea.Name = "mainArea";
            mainArea.Size = new Size(620, 350);
            mainArea.TabIndex = 2;
            // 
            // anotherControl1
            // 
            anotherControl1.BackColor = Color.IndianRed;
            anotherControl1.Dock = DockStyle.Fill;
            anotherControl1.Location = new Point(0, 0);
            anotherControl1.Name = "anotherControl1";
            anotherControl1.Size = new Size(620, 350);
            anotherControl1.TabIndex = 0;
            // 
            // extraControl1
            // 
            extraControl1.BackColor = Color.Chartreuse;
            extraControl1.Dock = DockStyle.Fill;
            extraControl1.Location = new Point(0, 0);
            extraControl1.Name = "extraControl1";
            extraControl1.Size = new Size(180, 350);
            extraControl1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainArea);
            Controls.Add(navigation);
            Controls.Add(header);
            Name = "Form1";
            Text = "Form1";
            header.ResumeLayout(false);
            navigation.ResumeLayout(false);
            mainArea.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel header;
        private Panel navigation;
        private Panel mainArea;
        private Controls.HeaderControl headerControl1;
        private Controls.extraControl extraControl1;
        private Controls.AnotherControl anotherControl1;
    }
}