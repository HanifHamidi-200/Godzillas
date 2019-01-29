namespace PROGB
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRLast = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.Location = new System.Drawing.Point(250, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(30, 46);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(199, 20);
            this.txt1.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(489, 342);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 60);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRLast
            // 
            this.btnRLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRLast.Location = new System.Drawing.Point(394, 342);
            this.btnRLast.Name = "btnRLast";
            this.btnRLast.Size = new System.Drawing.Size(89, 60);
            this.btnRLast.TabIndex = 6;
            this.btnRLast.Text = "RLast";
            this.btnRLast.UseVisualStyleBackColor = false;
            this.btnRLast.Click += new System.EventHandler(this.btnRLast_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(394, 46);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(219, 290);
            this.lst1.TabIndex = 5;
            // 
            // fSub3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRLast);
            this.Controls.Add(this.lst1);
            this.Name = "fSub3";
            this.Text = "MICompany_Subservients";
            this.Load += new System.EventHandler(this.fSub3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRLast;
        private System.Windows.Forms.ListBox lst1;
    }
}