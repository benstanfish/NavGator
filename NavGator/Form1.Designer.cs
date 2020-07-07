namespace NavGator
{
    partial class Form1
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
            this.buttonOriginal = new System.Windows.Forms.Button();
            this.labelOriginal = new System.Windows.Forms.Label();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.labelTargets = new System.Windows.Forms.Label();
            this.buttonTargets = new System.Windows.Forms.Button();
            this.checkedListBoxTargets = new System.Windows.Forms.CheckedListBox();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStartLine = new System.Windows.Forms.Label();
            this.labelEndLine = new System.Windows.Forms.Label();
            this.textBoxStartLine = new System.Windows.Forms.TextBox();
            this.textBoxEndLine = new System.Windows.Forms.TextBox();
            this.labelTargetFolder = new System.Windows.Forms.Label();
            this.textBoxTargetFolder = new System.Windows.Forms.TextBox();
            this.buttonTargetFolder = new System.Windows.Forms.Button();
            this.buttonOriginalOpenFolder = new System.Windows.Forms.Button();
            this.buttonOpenOutputFolder = new System.Windows.Forms.Button();
            this.buttonCycle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.targetFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkNoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOriginal
            // 
            this.buttonOriginal.BackColor = System.Drawing.Color.Pink;
            this.buttonOriginal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOriginal.Location = new System.Drawing.Point(29, 43);
            this.buttonOriginal.Name = "buttonOriginal";
            this.buttonOriginal.Size = new System.Drawing.Size(120, 34);
            this.buttonOriginal.TabIndex = 0;
            this.buttonOriginal.Text = "Select File...";
            this.buttonOriginal.UseVisualStyleBackColor = false;
            this.buttonOriginal.Click += new System.EventHandler(this.buttonOriginal_Click);
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(159, 29);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(83, 17);
            this.labelOriginal.TabIndex = 1;
            this.labelOriginal.Text = "Original File";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(162, 49);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(911, 22);
            this.textBoxOriginal.TabIndex = 2;
            this.textBoxOriginal.TextChanged += new System.EventHandler(this.textBoxOriginal_TextChanged);
            // 
            // labelTargets
            // 
            this.labelTargets.AutoSize = true;
            this.labelTargets.Location = new System.Drawing.Point(159, 445);
            this.labelTargets.Name = "labelTargets";
            this.labelTargets.Size = new System.Drawing.Size(83, 17);
            this.labelTargets.TabIndex = 3;
            this.labelTargets.Text = "Target Files";
            // 
            // buttonTargets
            // 
            this.buttonTargets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTargets.Location = new System.Drawing.Point(29, 465);
            this.buttonTargets.Name = "buttonTargets";
            this.buttonTargets.Size = new System.Drawing.Size(120, 34);
            this.buttonTargets.TabIndex = 4;
            this.buttonTargets.Text = "Select Files...";
            this.buttonTargets.UseVisualStyleBackColor = true;
            this.buttonTargets.Click += new System.EventHandler(this.buttonTargets_Click);
            // 
            // checkedListBoxTargets
            // 
            this.checkedListBoxTargets.CheckOnClick = true;
            this.checkedListBoxTargets.FormattingEnabled = true;
            this.checkedListBoxTargets.Location = new System.Drawing.Point(162, 465);
            this.checkedListBoxTargets.Name = "checkedListBoxTargets";
            this.checkedListBoxTargets.Size = new System.Drawing.Size(1025, 208);
            this.checkedListBoxTargets.TabIndex = 5;
            this.checkedListBoxTargets.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxTargets_SelectedIndexChanged);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonLoad.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.buttonLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLoad.Location = new System.Drawing.Point(29, 127);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(120, 34);
            this.buttonLoad.TabIndex = 6;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Location = new System.Drawing.Point(162, 127);
            this.textBoxPreview.Multiline = true;
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPreview.Size = new System.Drawing.Size(1020, 242);
            this.textBoxPreview.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nav Section Preview";
            // 
            // labelStartLine
            // 
            this.labelStartLine.AutoSize = true;
            this.labelStartLine.Location = new System.Drawing.Point(396, 97);
            this.labelStartLine.Name = "labelStartLine";
            this.labelStartLine.Size = new System.Drawing.Size(69, 17);
            this.labelStartLine.TabIndex = 9;
            this.labelStartLine.Text = "Start Line";
            // 
            // labelEndLine
            // 
            this.labelEndLine.AutoSize = true;
            this.labelEndLine.Location = new System.Drawing.Point(607, 97);
            this.labelEndLine.Name = "labelEndLine";
            this.labelEndLine.Size = new System.Drawing.Size(64, 17);
            this.labelEndLine.TabIndex = 10;
            this.labelEndLine.Text = "End Line";
            // 
            // textBoxStartLine
            // 
            this.textBoxStartLine.Location = new System.Drawing.Point(469, 94);
            this.textBoxStartLine.Name = "textBoxStartLine";
            this.textBoxStartLine.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartLine.TabIndex = 11;
            // 
            // textBoxEndLine
            // 
            this.textBoxEndLine.Location = new System.Drawing.Point(677, 94);
            this.textBoxEndLine.Name = "textBoxEndLine";
            this.textBoxEndLine.Size = new System.Drawing.Size(100, 22);
            this.textBoxEndLine.TabIndex = 12;
            // 
            // labelTargetFolder
            // 
            this.labelTargetFolder.AutoSize = true;
            this.labelTargetFolder.Location = new System.Drawing.Point(159, 382);
            this.labelTargetFolder.Name = "labelTargetFolder";
            this.labelTargetFolder.Size = new System.Drawing.Size(141, 17);
            this.labelTargetFolder.TabIndex = 13;
            this.labelTargetFolder.Text = "Output Parent Folder";
            // 
            // textBoxTargetFolder
            // 
            this.textBoxTargetFolder.Location = new System.Drawing.Point(162, 402);
            this.textBoxTargetFolder.Name = "textBoxTargetFolder";
            this.textBoxTargetFolder.Size = new System.Drawing.Size(911, 22);
            this.textBoxTargetFolder.TabIndex = 14;
            this.textBoxTargetFolder.TextChanged += new System.EventHandler(this.textBoxTargetFolder_TextChanged);
            // 
            // buttonTargetFolder
            // 
            this.buttonTargetFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTargetFolder.Location = new System.Drawing.Point(29, 396);
            this.buttonTargetFolder.Name = "buttonTargetFolder";
            this.buttonTargetFolder.Size = new System.Drawing.Size(120, 34);
            this.buttonTargetFolder.TabIndex = 15;
            this.buttonTargetFolder.Text = "Select Folder";
            this.buttonTargetFolder.UseVisualStyleBackColor = true;
            this.buttonTargetFolder.Click += new System.EventHandler(this.buttonTargetFolder_Click);
            // 
            // buttonOriginalOpenFolder
            // 
            this.buttonOriginalOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOriginalOpenFolder.Location = new System.Drawing.Point(1079, 43);
            this.buttonOriginalOpenFolder.Name = "buttonOriginalOpenFolder";
            this.buttonOriginalOpenFolder.Size = new System.Drawing.Size(105, 34);
            this.buttonOriginalOpenFolder.TabIndex = 16;
            this.buttonOriginalOpenFolder.Text = "Open Folder";
            this.buttonOriginalOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOriginalOpenFolder.Click += new System.EventHandler(this.buttonOriginalOpenFolder_Click);
            // 
            // buttonOpenOutputFolder
            // 
            this.buttonOpenOutputFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenOutputFolder.Location = new System.Drawing.Point(1079, 396);
            this.buttonOpenOutputFolder.Name = "buttonOpenOutputFolder";
            this.buttonOpenOutputFolder.Size = new System.Drawing.Size(105, 34);
            this.buttonOpenOutputFolder.TabIndex = 17;
            this.buttonOpenOutputFolder.Text = "Open Folder";
            this.buttonOpenOutputFolder.UseVisualStyleBackColor = true;
            this.buttonOpenOutputFolder.Click += new System.EventHandler(this.buttonOpenOutputFolder_Click);
            // 
            // buttonCycle
            // 
            this.buttonCycle.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCycle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCycle.Location = new System.Drawing.Point(29, 639);
            this.buttonCycle.Name = "buttonCycle";
            this.buttonCycle.Size = new System.Drawing.Size(120, 34);
            this.buttonCycle.TabIndex = 18;
            this.buttonCycle.Text = "Run!";
            this.buttonCycle.UseVisualStyleBackColor = false;
            this.buttonCycle.Click += new System.EventHandler(this.buttonCycle_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(29, 587);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 34);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAllToolStripMenuItem,
            this.targetFilesToolStripMenuItem});
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(72, 26);
            this.resetToolStripMenuItem.Text = "Actions";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.resetAllToolStripMenuItem.Text = "Reset All";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // targetFilesToolStripMenuItem
            // 
            this.targetFilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkAllToolStripMenuItem,
            this.checkNoneToolStripMenuItem});
            this.targetFilesToolStripMenuItem.Name = "targetFilesToolStripMenuItem";
            this.targetFilesToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.targetFilesToolStripMenuItem.Text = "Target Files";
            // 
            // checkAllToolStripMenuItem
            // 
            this.checkAllToolStripMenuItem.Name = "checkAllToolStripMenuItem";
            this.checkAllToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.checkAllToolStripMenuItem.Text = "Check All";
            this.checkAllToolStripMenuItem.Click += new System.EventHandler(this.checkAllToolStripMenuItem_Click);
            // 
            // checkNoneToolStripMenuItem
            // 
            this.checkNoneToolStripMenuItem.Name = "checkNoneToolStripMenuItem";
            this.checkNoneToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.checkNoneToolStripMenuItem.Text = "Check None";
            this.checkNoneToolStripMenuItem.Click += new System.EventHandler(this.checkNoneToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(64, 26);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(47, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 474);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 24;
            this.label5.Text = "4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 648);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 686);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCycle);
            this.Controls.Add(this.buttonOpenOutputFolder);
            this.Controls.Add(this.buttonOriginalOpenFolder);
            this.Controls.Add(this.buttonTargetFolder);
            this.Controls.Add(this.textBoxTargetFolder);
            this.Controls.Add(this.labelTargetFolder);
            this.Controls.Add(this.textBoxEndLine);
            this.Controls.Add(this.textBoxStartLine);
            this.Controls.Add(this.labelEndLine);
            this.Controls.Add(this.labelStartLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPreview);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.checkedListBoxTargets);
            this.Controls.Add(this.buttonTargets);
            this.Controls.Add(this.labelTargets);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.labelOriginal);
            this.Controls.Add(this.buttonOriginal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NavGator v0.4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOriginal;
        private System.Windows.Forms.Label labelOriginal;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.Label labelTargets;
        private System.Windows.Forms.Button buttonTargets;
        private System.Windows.Forms.CheckedListBox checkedListBoxTargets;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStartLine;
        private System.Windows.Forms.Label labelEndLine;
        private System.Windows.Forms.TextBox textBoxStartLine;
        private System.Windows.Forms.TextBox textBoxEndLine;
        private System.Windows.Forms.Label labelTargetFolder;
        private System.Windows.Forms.TextBox textBoxTargetFolder;
        private System.Windows.Forms.Button buttonTargetFolder;
        private System.Windows.Forms.Button buttonOriginalOpenFolder;
        private System.Windows.Forms.Button buttonOpenOutputFolder;
        private System.Windows.Forms.Button buttonCycle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem targetFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkNoneToolStripMenuItem;
    }
}

