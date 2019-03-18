namespace VUEX
{
    partial class fSub3
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
            this.btnQNext = new System.Windows.Forms.Button();
            this.fra1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.fra1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(567, 31);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(99, 88);
            this.btnQNext.TabIndex = 8;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // fra1
            // 
            this.fra1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.fra1.Controls.Add(this.btnSave);
            this.fra1.Controls.Add(this.txtEntry);
            this.fra1.Controls.Add(this.lst1);
            this.fra1.Location = new System.Drawing.Point(36, 31);
            this.fra1.Name = "fra1";
            this.fra1.Size = new System.Drawing.Size(489, 223);
            this.fra1.TabIndex = 7;
            this.fra1.TabStop = false;
            this.fra1.Text = "Border";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Location = new System.Drawing.Point(211, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 29);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(34, 183);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(161, 20);
            this.txtEntry.TabIndex = 1;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(34, 34);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(414, 134);
            this.lst1.TabIndex = 0;
            // 
            // fSub3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 276);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.fra1);
            this.Name = "fSub3";
            this.Text = "Planet9Possibilities";
            this.Load += new System.EventHandler(this.fSub3_Load);
            this.fra1.ResumeLayout(false);
            this.fra1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.GroupBox fra1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.ListBox lst1;
    }
}