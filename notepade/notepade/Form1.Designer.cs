namespace notepade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.SaveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSplitButton2 = new System.Windows.Forms.ToolStripSplitButton();
            this.CopyToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DeselectToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TextColorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundColorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TextStyleToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignToolStrip = new System.Windows.Forms.ToolStripSplitButton();
            this.AlignLeftToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignRightToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.AlignCenterToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(471, 422);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripSplitButton2,
            this.AlignToolStrip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(494, 25);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStrip,
            this.OpenToolStrip});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(41, 22);
            this.toolStripSplitButton1.Text = "File";
            // 
            // SaveToolStrip
            // 
            this.SaveToolStrip.Name = "SaveToolStrip";
            this.SaveToolStrip.Size = new System.Drawing.Size(103, 22);
            this.SaveToolStrip.Text = "Save";
            this.SaveToolStrip.Click += new System.EventHandler(this.SaveToolStrip_Click);
            // 
            // OpenToolStrip
            // 
            this.OpenToolStrip.Name = "OpenToolStrip";
            this.OpenToolStrip.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStrip.Text = "Open";
            this.OpenToolStrip.Click += new System.EventHandler(this.OpenToolStrip_Click);
            // 
            // toolStripSplitButton2
            // 
            this.toolStripSplitButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStrip,
            this.PasteToolStrip,
            this.CutToolStrip,
            this.SelectToolStrip,
            this.DeselectToolStrip,
            this.TextColorToolStrip,
            this.BackgroundColorToolStrip,
            this.TextStyleToolStrip});
            this.toolStripSplitButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton2.Image")));
            this.toolStripSplitButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton2.Name = "toolStripSplitButton2";
            this.toolStripSplitButton2.Size = new System.Drawing.Size(44, 22);
            this.toolStripSplitButton2.Text = "Text";
            // 
            // CopyToolStrip
            // 
            this.CopyToolStrip.Name = "CopyToolStrip";
            this.CopyToolStrip.Size = new System.Drawing.Size(208, 22);
            this.CopyToolStrip.Text = "Copy           (Ctrl + C)";
            this.CopyToolStrip.Click += new System.EventHandler(this.CopyToolStrip_Click);
            // 
            // PasteToolStrip
            // 
            this.PasteToolStrip.Name = "PasteToolStrip";
            this.PasteToolStrip.Size = new System.Drawing.Size(208, 22);
            this.PasteToolStrip.Text = "Paste           (Ctrl + V)";
            this.PasteToolStrip.Click += new System.EventHandler(this.PasteToolStrip_Click);
            // 
            // CutToolStrip
            // 
            this.CutToolStrip.Name = "CutToolStrip";
            this.CutToolStrip.Size = new System.Drawing.Size(208, 22);
            this.CutToolStrip.Text = "Cut              (Ctrl + X)";
            this.CutToolStrip.Click += new System.EventHandler(this.CutToolStrip_Click);
            // 
            // SelectToolStrip
            // 
            this.SelectToolStrip.Name = "SelectToolStrip";
            this.SelectToolStrip.Size = new System.Drawing.Size(208, 22);
            this.SelectToolStrip.Text = "Select All     (Ctrl + A)";
            this.SelectToolStrip.Click += new System.EventHandler(this.SelectToolStrip_Click);
            // 
            // DeselectToolStrip
            // 
            this.DeselectToolStrip.Name = "DeselectToolStrip";
            this.DeselectToolStrip.Size = new System.Drawing.Size(208, 22);
            this.DeselectToolStrip.Text = "Deselect      (Ctrl + Space)";
            this.DeselectToolStrip.Click += new System.EventHandler(this.DeselectToolStrip_Click);
            // 
            // TextColorToolStrip
            // 
            this.TextColorToolStrip.Name = "TextColorToolStrip";
            this.TextColorToolStrip.Size = new System.Drawing.Size(208, 22);
            this.TextColorToolStrip.Text = "Text Color";
            this.TextColorToolStrip.Click += new System.EventHandler(this.TextColorToolStrip_Click);
            // 
            // BackgroundColorToolStrip
            // 
            this.BackgroundColorToolStrip.Name = "BackgroundColorToolStrip";
            this.BackgroundColorToolStrip.Size = new System.Drawing.Size(208, 22);
            this.BackgroundColorToolStrip.Text = "Background Color";
            this.BackgroundColorToolStrip.Click += new System.EventHandler(this.BackgroundColorToolStrip_Click);
            // 
            // TextStyleToolStrip
            // 
            this.TextStyleToolStrip.Name = "TextStyleToolStrip";
            this.TextStyleToolStrip.Size = new System.Drawing.Size(208, 22);
            this.TextStyleToolStrip.Text = "Text Style";
            this.TextStyleToolStrip.Click += new System.EventHandler(this.TextStyleToolStrip_Click);
            // 
            // AlignToolStrip
            // 
            this.AlignToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AlignToolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AlignLeftToolStrip,
            this.AlignRightToolStrip,
            this.AlignCenterToolStrip});
            this.AlignToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("AlignToolStrip.Image")));
            this.AlignToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AlignToolStrip.Name = "AlignToolStrip";
            this.AlignToolStrip.Size = new System.Drawing.Size(51, 22);
            this.AlignToolStrip.Text = "Align";
            this.AlignToolStrip.ButtonClick += new System.EventHandler(this.AlignLeftToolStrip_Click);
            // 
            // AlignLeftToolStrip
            // 
            this.AlignLeftToolStrip.Name = "AlignLeftToolStrip";
            this.AlignLeftToolStrip.Size = new System.Drawing.Size(180, 22);
            this.AlignLeftToolStrip.Text = "Left";
            this.AlignLeftToolStrip.Click += new System.EventHandler(this.AlignLeftToolStrip_Click);
            // 
            // AlignRightToolStrip
            // 
            this.AlignRightToolStrip.Name = "AlignRightToolStrip";
            this.AlignRightToolStrip.Size = new System.Drawing.Size(180, 22);
            this.AlignRightToolStrip.Text = "Right";
            this.AlignRightToolStrip.Click += new System.EventHandler(this.AlignRightToolStrip_Click);
            // 
            // AlignCenterToolStrip
            // 
            this.AlignCenterToolStrip.Name = "AlignCenterToolStrip";
            this.AlignCenterToolStrip.Size = new System.Drawing.Size(180, 22);
            this.AlignCenterToolStrip.Text = "Center";
            this.AlignCenterToolStrip.Click += new System.EventHandler(this.AlignCenterToolStrip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 461);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RichTextBox richTextBox1;
        private ToolStrip toolStrip1;
        private ToolStripSplitButton AlignToolStrip;
        private ToolStripMenuItem AlignLeftToolStrip;
        private ToolStripMenuItem AlignRightToolStrip;
        private ToolStripMenuItem AlignCenterToolStrip;
        private ToolStripSplitButton toolStripSplitButton1;
        private ToolStripSplitButton toolStripSplitButton2;
        private ToolStripMenuItem CopyToolStrip;
        private ToolStripMenuItem SaveToolStrip;
        private ToolStripMenuItem OpenToolStrip;
        private ToolStripMenuItem PasteToolStrip;
        private ToolStripMenuItem CutToolStrip;
        private ToolStripMenuItem SelectToolStrip;
        private ToolStripMenuItem DeselectToolStrip;
        private ToolStripMenuItem TextColorToolStrip;
        private ToolStripMenuItem BackgroundColorToolStrip;
        private ToolStripMenuItem TextStyleToolStrip;
    }
}