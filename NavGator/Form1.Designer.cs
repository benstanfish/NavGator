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
            this.textBoxOriginal.Size = new System.Drawing.Size(662, 22);
            this.textBoxOriginal.TabIndex = 2;
            // 
            // labelTargets
            // 
            this.labelTargets.AutoSize = true;
            this.labelTargets.Location = new System.Drawing.Point(12, 69);
            this.labelTargets.Name = "labelTargets";
            this.labelTargets.Size = new System.Drawing.Size(83, 17);
            this.labelTargets.TabIndex = 3;
            this.labelTargets.Text = "Target Files";
            // 
            // buttonTargets
            // 
            this.buttonTargets.Location = new System.Drawing.Point(12, 89);
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
            this.checkedListBoxTargets.Location = new System.Drawing.Point(125, 89);
            this.checkedListBoxTargets.Name = "checkedListBoxTargets";
            this.checkedListBoxTargets.Size = new System.Drawing.Size(662, 140);
            this.checkedListBoxTargets.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Location = new System.Drawing.Point(126, 258);
            this.textBoxPreview.Multiline = true;
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPreview.Size = new System.Drawing.Size(662, 159);
            this.textBoxPreview.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Preview";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 430);
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
    }
}

