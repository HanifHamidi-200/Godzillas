namespace PROGB
{
    partial class fSub1
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
            this.btnRLast = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(388, 22);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(219, 290);
            this.lst1.TabIndex = 0;
            // 
            // btnRLast
            // 
            this.btnRLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRLast.Location = new System.Drawing.Point(388, 318);
            this.btnRLast.Name = "btnRLast";
            this.btnRLast.Size = new System.Drawing.Size(89, 60);
            this.btnRLast.TabIndex = 1;
            this.btnRLast.Text = "RLast";
            this.btnRLast.UseVisualStyleBackColor = false;
            this.btnRLast.Click += new System.EventHandler(this.btnRLast_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClear.Location = new System.Drawing.Point(483, 318);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 60);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(24, 22);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(199, 20);
            this.txt1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Yellow;
            this.btnAdd.Location = new System.Drawing.Point(244, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 36);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // fSub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRLast);
            this.Controls.Add(this.lst1);
            this.Name = "fSub1";
            this.Text = "PerellisLexusPLC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btnRLast;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button btnAdd;
    }
}