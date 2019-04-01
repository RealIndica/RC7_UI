namespace RC7_UI
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.ToolBar = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.openButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.muteButton = new System.Windows.Forms.Button();
            this.roexploitButton = new System.Windows.Forms.Button();
            this.downloadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.WButton = new System.Windows.Forms.Button();
            this.AButton = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.ToolBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolBar
            // 
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.ToolBar.Location = new System.Drawing.Point(0, 0);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.Size = new System.Drawing.Size(339, 24);
            this.ToolBar.TabIndex = 0;
            this.ToolBar.Text = "Settings";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem4.Text = "Tabs";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Settings";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOutputToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showOutputToolStripMenuItem
            // 
            this.showOutputToolStripMenuItem.Name = "showOutputToolStripMenuItem";
            this.showOutputToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.showOutputToolStripMenuItem.Text = "Show Output";
            this.showOutputToolStripMenuItem.Click += new System.EventHandler(this.showOutputToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem2.Text = "Commands";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem3.Text = "Help";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem5.Text = "Edit Theme";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Location = new System.Drawing.Point(8, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 301);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(42, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(283, 301);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(275, 275);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "*.lua";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(269, 269);
            this.webBrowser1.TabIndex = 0;
            // 
            // openButton
            // 
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openButton.FlatAppearance.BorderSize = 0;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.openButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.openButton.Location = new System.Drawing.Point(8, 325);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(95, 25);
            this.openButton.TabIndex = 2;
            this.openButton.TabStop = false;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.MouseEnter += new System.EventHandler(this.openButton_MouseEnter);
            this.openButton.MouseLeave += new System.EventHandler(this.openButton_MouseLeave);
            // 
            // executeButton
            // 
            this.executeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.executeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.executeButton.FlatAppearance.BorderSize = 0;
            this.executeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.executeButton.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.executeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.executeButton.Location = new System.Drawing.Point(102, 325);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(95, 25);
            this.executeButton.TabIndex = 3;
            this.executeButton.TabStop = false;
            this.executeButton.Text = "Execute";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.MouseEnter += new System.EventHandler(this.executeButton_MouseEnter);
            this.executeButton.MouseLeave += new System.EventHandler(this.executeButton_MouseLeave);
            // 
            // clearButton
            // 
            this.clearButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.clearButton.Location = new System.Drawing.Point(196, 325);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(95, 25);
            this.clearButton.TabIndex = 4;
            this.clearButton.TabStop = false;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.MouseEnter += new System.EventHandler(this.clearButton_MouseEnter);
            this.clearButton.MouseLeave += new System.EventHandler(this.clearButton_MouseLeave);
            // 
            // muteButton
            // 
            this.muteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.muteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muteButton.Location = new System.Drawing.Point(5, 293);
            this.muteButton.Name = "muteButton";
            this.muteButton.Size = new System.Drawing.Size(30, 30);
            this.muteButton.TabIndex = 5;
            this.muteButton.UseVisualStyleBackColor = true;
            // 
            // roexploitButton
            // 
            this.roexploitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.roexploitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.roexploitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roexploitButton.Location = new System.Drawing.Point(5, 257);
            this.roexploitButton.Name = "roexploitButton";
            this.roexploitButton.Size = new System.Drawing.Size(30, 30);
            this.roexploitButton.TabIndex = 7;
            this.roexploitButton.UseVisualStyleBackColor = true;
            // 
            // downloadButton
            // 
            this.downloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downloadButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.downloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.downloadButton.Location = new System.Drawing.Point(5, 221);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(30, 30);
            this.downloadButton.TabIndex = 8;
            this.downloadButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Location = new System.Drawing.Point(5, 113);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(30, 30);
            this.saveButton.TabIndex = 11;
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // WButton
            // 
            this.WButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.WButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WButton.Location = new System.Drawing.Point(5, 149);
            this.WButton.Name = "WButton";
            this.WButton.Size = new System.Drawing.Size(30, 30);
            this.WButton.TabIndex = 10;
            this.WButton.UseVisualStyleBackColor = true;
            // 
            // AButton
            // 
            this.AButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AButton.Location = new System.Drawing.Point(5, 185);
            this.AButton.Name = "AButton";
            this.AButton.Size = new System.Drawing.Size(30, 30);
            this.AButton.TabIndex = 9;
            this.AButton.UseVisualStyleBackColor = true;
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.muteButton);
            this.rightPanel.Controls.Add(this.roexploitButton);
            this.rightPanel.Controls.Add(this.downloadButton);
            this.rightPanel.Controls.Add(this.AButton);
            this.rightPanel.Controls.Add(this.WButton);
            this.rightPanel.Controls.Add(this.saveButton);
            this.rightPanel.Location = new System.Drawing.Point(300, 24);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(39, 328);
            this.rightPanel.TabIndex = 12;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(339, 352);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ToolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ToolBar;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ToolBar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button muteButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button roexploitButton;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button WButton;
        private System.Windows.Forms.Button AButton;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOutputToolStripMenuItem;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

