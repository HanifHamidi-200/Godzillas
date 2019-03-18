namespace TWINLN
{
    partial class fVersion3
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
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Items.AddRange(new object[] {
            "Pasture in (earlySpring)",
            "Pasture out (SummerAutumn)",
            "Tracter working (Autumn)",
            "[Tractertart] (AutumnWinter)"});
            this.lst1.Location = new System.Drawing.Point(54, 23);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(237, 134);
            this.lst1.TabIndex = 0;
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Items.AddRange(new object[] {
            "SpringSummer -> artwork",
            "WinterSpring -> NewYearPreparations"});
            this.lst2.Location = new System.Drawing.Point(54, 176);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(237, 134);
            this.lst2.TabIndex = 1;
            // 
            // fVersion3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Name = "fVersion3";
            this.Text = "fVersion3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
    }
}