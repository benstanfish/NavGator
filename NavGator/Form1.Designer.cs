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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelStartLine = new System.Windows.Forms.Label();
            this.labelEndLine = new System.Windows.Forms.Label();
            this.textBoxStartLine = new System.Windows.Forms.TextBox();
            this.textBoxEndLine = new System.Windows.Forms.TextBox();
            this.labelTargetFolder = new System.Windows.Forms.Label();
            this.textBoxTargetFolder = new System.Windows.Forms.TextBox();
            this.buttonTargetFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOriginal
            // 
            this.buttonOriginal.Location = new System.Drawing.Point(12, 29);
            this.buttonOriginal.Name = "buttonOriginal";
            this.buttonOriginal.Size = new System.Drawing.Size(107, 23);
            this.buttonOriginal.TabIndex = 0;
            this.buttonOriginal.Text = "Select File...";
            this.buttonOriginal.UseVisualStyleBackColor = true;
            this.buttonOriginal.Click += new System.EventHandler(this.buttonOriginal_Click);
            // 
            // labelOriginal
            // 
            this.labelOriginal.AutoSize = true;
            this.labelOriginal.Location = new System.Drawing.Point(12, 9);
            this.labelOriginal.Name = "labelOriginal";
            this.labelOriginal.Size = new System.Drawing.Size(83, 17);
            this.labelOriginal.TabIndex = 1;
            this.labelOriginal.Text = "Original File";
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(126, 29);
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(1024, 22);
            this.textBoxOriginal.TabIndex = 2;
            // 
            // labelTargets
            // 
            this.labelTargets.AutoSize = true;
            this.labelTargets.Location = new System.Drawing.Point(12, 369);
            this.labelTargets.Name = "labelTargets";
            this.labelTargets.Size = new System.Drawing.Size(83, 17);
            this.labelTargets.TabIndex = 3;
            this.labelTargets.Text = "Target Files";
            // 
            // buttonTargets
            // 
            this.buttonTargets.Location = new System.Drawing.Point(12, 389);
            this.buttonTargets.Name = "buttonTargets";
            this.buttonTargets.Size = new System.Drawing.Size(107, 23);
            this.buttonTargets.TabIndex = 4;
            this.buttonTargets.Text = "Select Files...";
            this.buttonTargets.UseVisualStyleBackColor = true;
            this.buttonTargets.Click += new System.EventHandler(this.buttonTargets_Click);
            // 
            // checkedListBoxTargets
            // 
            this.checkedListBoxTargets.FormattingEnabled = true;
            this.checkedListBoxTargets.Location = new System.Drawing.Point(125, 389);
            this.checkedListBoxTargets.Name = "checkedListBoxTargets";
            this.checkedListBoxTargets.Size = new System.Drawing.Size(1025, 140);
            this.checkedListBoxTargets.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Location = new System.Drawing.Point(125, 112);
            this.textBoxPreview.Multiline = true;
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPreview.Size = new System.Drawing.Size(1024, 242);
            this.textBoxPreview.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preview/Editor";
            // 
            // labelStartLine
            // 
            this.labelStartLine.AutoSize = true;
            this.labelStartLine.Location = new System.Drawing.Point(123, 87);
            this.labelStartLine.Name = "labelStartLine";
            this.labelStartLine.Size = new System.Drawing.Size(69, 17);
            this.labelStartLine.TabIndex = 9;
            this.labelStartLine.Text = "Start Line";
            // 
            // labelEndLine
            // 
            this.labelEndLine.AutoSize = true;
            this.labelEndLine.Location = new System.Drawing.Point(361, 87);
            this.labelEndLine.Name = "labelEndLine";
            this.labelEndLine.Size = new System.Drawing.Size(64, 17);
            this.labelEndLine.TabIndex = 10;
            this.labelEndLine.Text = "End Line";
            // 
            // textBoxStartLine
            // 
            this.textBoxStartLine.Location = new System.Drawing.Point(198, 84);
            this.textBoxStartLine.Name = "textBoxStartLine";
            this.textBoxStartLine.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartLine.TabIndex = 11;
            // 
            // textBoxEndLine
            // 
            this.textBoxEndLine.Location = new System.Drawing.Point(431, 84);
            this.textBoxEndLine.Name = "textBoxEndLine";
            this.textBoxEndLine.Size = new System.Drawing.Size(100, 22);
            this.textBoxEndLine.TabIndex = 12;
            // 
            // labelTargetFolder
            // 
            this.labelTargetFolder.AutoSize = true;
            this.labelTargetFolder.Location = new System.Drawing.Point(12, 552);
            this.labelTargetFolder.Name = "labelTargetFolder";
            this.labelTargetFolder.Size = new System.Drawing.Size(94, 17);
            this.labelTargetFolder.TabIndex = 13;
            this.labelTargetFolder.Text = "Target Folder";
            // 
            // textBoxTargetFolder
            // 
            this.textBoxTargetFolder.Location = new System.Drawing.Point(126, 577);
            this.textBoxTargetFolder.Name = "textBoxTargetFolder";
            this.textBoxTargetFolder.Size = new System.Drawing.Size(1023, 22);
            this.textBoxTargetFolder.TabIndex = 14;
            // 
            // buttonTargetFolder
            // 
            this.buttonTargetFolder.Location = new System.Drawing.Point(12, 577);
            this.buttonTargetFolder.Name = "buttonTargetFolder";
            this.buttonTargetFolder.Size = new System.Drawing.Size(105, 23);
            this.buttonTargetFolder.TabIndex = 15;
            this.buttonTargetFolder.Text = "Select Folder";
            this.buttonTargetFolder.UseVisualStyleBackColor = true;
            this.buttonTargetFolder.Click += new System.EventHandler(this.buttonTargetFolder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 701);
            this.Controls.Add(this.buttonTargetFolder);
            this.Controls.Add(this.textBoxTargetFolder);
            this.Controls.Add(this.labelTargetFolder);
            this.Controls.Add(this.textBoxEndLine);
            this.Controls.Add(this.textBoxStartLine);
            this.Controls.Add(this.labelEndLine);
            this.Controls.Add(this.labelStartLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPreview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkedListBoxTargets);
            this.Controls.Add(this.buttonTargets);
            this.Controls.Add(this.labelTargets);
            this.Controls.Add(this.textBoxOriginal);
            this.Controls.Add(this.labelOriginal);
            this.Controls.Add(this.buttonOriginal);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "NavGator v0.0";
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelStartLine;
        private System.Windows.Forms.Label labelEndLine;
        private System.Windows.Forms.TextBox textBoxStartLine;
        private System.Windows.Forms.TextBox textBoxEndLine;
        private System.Windows.Forms.Label labelTargetFolder;
        private System.Windows.Forms.TextBox textBoxTargetFolder;
        private System.Windows.Forms.Button buttonTargetFolder;
    }
}

