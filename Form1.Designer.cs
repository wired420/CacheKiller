namespace CacheKiller
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            githubToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            button1 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            checkBoxOperaGX = new CheckBox();
            checkBoxOpera = new CheckBox();
            checkBoxFirefox = new CheckBox();
            checkBoxEdge = new CheckBox();
            checkBoxChrome = new CheckBox();
            checkBoxBrave = new CheckBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            button2 = new Button();
            label4 = new Label();
            groupBox4 = new GroupBox();
            richTextBox1 = new RichTextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(526, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(92, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { githubToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // githubToolStripMenuItem
            // 
            githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            githubToolStripMenuItem.Size = new Size(180, 22);
            githubToolStripMenuItem.Text = "&Github";
            githubToolStripMenuItem.Click += githubToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 114);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Step 1";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(179, 46);
            button1.Name = "button1";
            button1.Size = new Size(125, 50);
            button1.TabIndex = 1;
            button1.Text = "Click To Scan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(156, 19);
            label1.Name = "label1";
            label1.Size = new Size(170, 15);
            label1.TabIndex = 0;
            label1.Text = "Scan for supported browsers.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(checkBoxOperaGX);
            groupBox2.Controls.Add(checkBoxOpera);
            groupBox2.Controls.Add(checkBoxFirefox);
            groupBox2.Controls.Add(checkBoxEdge);
            groupBox2.Controls.Add(checkBoxChrome);
            groupBox2.Controls.Add(checkBoxBrave);
            groupBox2.Controls.Add(label2);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(12, 147);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(502, 148);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Step 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 113);
            label3.Name = "label3";
            label3.Size = new Size(304, 15);
            label3.TabIndex = 7;
            label3.Text = "Check the boxes of detected browsers you wish to clean.";
            // 
            // checkBoxOperaGX
            // 
            checkBoxOperaGX.AutoSize = true;
            checkBoxOperaGX.Enabled = false;
            checkBoxOperaGX.Location = new Point(309, 80);
            checkBoxOperaGX.Name = "checkBoxOperaGX";
            checkBoxOperaGX.Size = new Size(76, 19);
            checkBoxOperaGX.TabIndex = 6;
            checkBoxOperaGX.Text = "Opera GT";
            checkBoxOperaGX.UseVisualStyleBackColor = true;
            checkBoxOperaGX.CheckedChanged += checkBoxOperaGX_CheckedChanged;
            // 
            // checkBoxOpera
            // 
            checkBoxOpera.AutoSize = true;
            checkBoxOpera.Enabled = false;
            checkBoxOpera.Location = new Point(214, 80);
            checkBoxOpera.Name = "checkBoxOpera";
            checkBoxOpera.Size = new Size(58, 19);
            checkBoxOpera.TabIndex = 5;
            checkBoxOpera.Text = "Opera";
            checkBoxOpera.UseVisualStyleBackColor = true;
            checkBoxOpera.CheckedChanged += checkBoxOpera_CheckedChanged;
            // 
            // checkBoxFirefox
            // 
            checkBoxFirefox.AutoSize = true;
            checkBoxFirefox.Enabled = false;
            checkBoxFirefox.Location = new Point(126, 80);
            checkBoxFirefox.Name = "checkBoxFirefox";
            checkBoxFirefox.Size = new Size(61, 19);
            checkBoxFirefox.TabIndex = 4;
            checkBoxFirefox.Text = "Firefox";
            checkBoxFirefox.UseVisualStyleBackColor = true;
            checkBoxFirefox.CheckedChanged += checkBoxFirefox_CheckedChanged;
            // 
            // checkBoxEdge
            // 
            checkBoxEdge.AutoSize = true;
            checkBoxEdge.Enabled = false;
            checkBoxEdge.Location = new Point(309, 55);
            checkBoxEdge.Name = "checkBoxEdge";
            checkBoxEdge.Size = new Size(52, 19);
            checkBoxEdge.TabIndex = 3;
            checkBoxEdge.Text = "Edge";
            checkBoxEdge.UseVisualStyleBackColor = true;
            checkBoxEdge.CheckedChanged += checkBoxEdge_CheckedChanged;
            // 
            // checkBoxChrome
            // 
            checkBoxChrome.AutoSize = true;
            checkBoxChrome.Enabled = false;
            checkBoxChrome.Location = new Point(214, 55);
            checkBoxChrome.Name = "checkBoxChrome";
            checkBoxChrome.Size = new Size(69, 19);
            checkBoxChrome.TabIndex = 2;
            checkBoxChrome.Text = "Chrome";
            checkBoxChrome.UseVisualStyleBackColor = true;
            checkBoxChrome.CheckedChanged += checkBoxChrome_CheckedChanged;
            // 
            // checkBoxBrave
            // 
            checkBoxBrave.AutoSize = true;
            checkBoxBrave.Enabled = false;
            checkBoxBrave.Location = new Point(126, 55);
            checkBoxBrave.Name = "checkBoxBrave";
            checkBoxBrave.Size = new Size(55, 19);
            checkBoxBrave.TabIndex = 1;
            checkBoxBrave.Text = "Brave";
            checkBoxBrave.UseVisualStyleBackColor = true;
            checkBoxBrave.CheckedChanged += checkBoxBrave_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(149, 24);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 0;
            label2.Text = "Detected Supported Browsers";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label4);
            groupBox3.Enabled = false;
            groupBox3.Location = new Point(12, 301);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(502, 123);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Step 3";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(179, 51);
            button2.Name = "button2";
            button2.Size = new Size(125, 50);
            button2.TabIndex = 2;
            button2.Text = "Click To Kill";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(195, 19);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 0;
            label4.Text = "Kill Your Cache";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(richTextBox1);
            groupBox4.Location = new Point(12, 430);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(502, 260);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Log";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 22);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(479, 232);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.WordWrap = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 706);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(526, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(64, 17);
            toolStripStatusLabel1.Text = "Status: Idle";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 728);
            Controls.Add(statusStrip1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "CacheKiller";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private GroupBox groupBox1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private CheckBox checkBoxOperaGX;
        private CheckBox checkBoxOpera;
        private CheckBox checkBoxFirefox;
        private CheckBox checkBoxEdge;
        private CheckBox checkBoxChrome;
        private CheckBox checkBoxBrave;
        private GroupBox groupBox3;
        private Label label4;
        private Button button2;
        private GroupBox groupBox4;
        private RichTextBox richTextBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem githubToolStripMenuItem;
    }
}
