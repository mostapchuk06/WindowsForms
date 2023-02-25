namespace Find_next
{
    partial class ChooseTheLvlForm
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
            this.EasyLvlBtn = new System.Windows.Forms.Button();
            this.MediumLvlBtn = new System.Windows.Forms.Button();
            this.HardLvlBtn = new System.Windows.Forms.Button();
            this.ChooseTheLvlLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EasyLvlBtn
            // 
            this.EasyLvlBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.EasyLvlBtn.Location = new System.Drawing.Point(29, 294);
            this.EasyLvlBtn.Name = "EasyLvlBtn";
            this.EasyLvlBtn.Size = new System.Drawing.Size(178, 74);
            this.EasyLvlBtn.TabIndex = 0;
            this.EasyLvlBtn.Text = "Easy";
            this.EasyLvlBtn.UseVisualStyleBackColor = false;
            this.EasyLvlBtn.Click += new System.EventHandler(this.EasyBtnClicked);
            // 
            // MediumLvlBtn
            // 
            this.MediumLvlBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.MediumLvlBtn.Location = new System.Drawing.Point(213, 294);
            this.MediumLvlBtn.Name = "MediumLvlBtn";
            this.MediumLvlBtn.Size = new System.Drawing.Size(178, 74);
            this.MediumLvlBtn.TabIndex = 1;
            this.MediumLvlBtn.Text = "Medium";
            this.MediumLvlBtn.UseVisualStyleBackColor = false;
            this.MediumLvlBtn.Click += new System.EventHandler(this.MediumBtnClicked);
            // 
            // HardLvlBtn
            // 
            this.HardLvlBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.HardLvlBtn.Location = new System.Drawing.Point(397, 294);
            this.HardLvlBtn.Name = "HardLvlBtn";
            this.HardLvlBtn.Size = new System.Drawing.Size(178, 74);
            this.HardLvlBtn.TabIndex = 2;
            this.HardLvlBtn.Text = "Hard";
            this.HardLvlBtn.UseVisualStyleBackColor = false;
            this.HardLvlBtn.Click += new System.EventHandler(this.HardBtnClicked);
            // 
            // ChooseTheLvlLbl
            // 
            this.ChooseTheLvlLbl.AutoSize = true;
            this.ChooseTheLvlLbl.Font = new System.Drawing.Font("Segoe UI", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChooseTheLvlLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChooseTheLvlLbl.Location = new System.Drawing.Point(134, 116);
            this.ChooseTheLvlLbl.Name = "ChooseTheLvlLbl";
            this.ChooseTheLvlLbl.Size = new System.Drawing.Size(363, 62);
            this.ChooseTheLvlLbl.TabIndex = 3;
            this.ChooseTheLvlLbl.Text = "Choose the level";
            // 
            // ChooseTheLvlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(610, 436);
            this.Controls.Add(this.ChooseTheLvlLbl);
            this.Controls.Add(this.HardLvlBtn);
            this.Controls.Add(this.MediumLvlBtn);
            this.Controls.Add(this.EasyLvlBtn);
            this.Name = "ChooseTheLvlForm";
            this.Text = "Find Next";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button EasyLvlBtn;
        private Button MediumLvlBtn;
        private Button HardLvlBtn;
        private Label ChooseTheLvlLbl;
    }
}