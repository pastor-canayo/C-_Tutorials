namespace UserControl2
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            firstUserControl1 = new Controls.FirstUserControl();
            secondUserControl1 = new Controls.SecondUserControl();
            lastUserControl1 = new Controls.LastUserControl();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(firstUserControl1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(secondUserControl1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 100);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 350);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(lastUserControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(200, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 350);
            panel3.TabIndex = 2;
            // 
            // firstUserControl1
            // 
            firstUserControl1.BackColor = Color.Red;
            firstUserControl1.Dock = DockStyle.Fill;
            firstUserControl1.Location = new Point(0, 0);
            firstUserControl1.Name = "firstUserControl1";
            firstUserControl1.Size = new Size(800, 100);
            firstUserControl1.TabIndex = 0;
            // 
            // secondUserControl1
            // 
            secondUserControl1.BackColor = Color.Yellow;
            secondUserControl1.Dock = DockStyle.Fill;
            secondUserControl1.Location = new Point(0, 0);
            secondUserControl1.Name = "secondUserControl1";
            secondUserControl1.Size = new Size(200, 350);
            secondUserControl1.TabIndex = 0;
            // 
            // lastUserControl1
            // 
            lastUserControl1.BackColor = Color.Lime;
            lastUserControl1.Dock = DockStyle.Fill;
            lastUserControl1.Location = new Point(0, 0);
            lastUserControl1.Name = "lastUserControl1";
            lastUserControl1.Size = new Size(600, 350);
            lastUserControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Controls.FirstUserControl firstUserControl1;
        private Controls.SecondUserControl secondUserControl1;
        private Controls.LastUserControl lastUserControl1;
    }
}