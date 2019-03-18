namespace DTRACK
{
    partial class fAsk
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.btnGo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.opt4);
            this.groupBox1.Controls.Add(this.opt3);
            this.groupBox1.Controls.Add(this.opt2);
            this.groupBox1.Controls.Add(this.opt1);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ask";
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.BackColor = System.Drawing.Color.Yellow;
            this.opt1.Location = new System.Drawing.Point(22, 47);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(46, 17);
            this.opt1.TabIndex = 0;
            this.opt1.TabStop = true;
            this.opt1.Text = "opt1";
            this.opt1.UseVisualStyleBackColor = false;
            this.opt1.CheckedChanged += new System.EventHandler(this.opt1_CheckedChanged);
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.BackColor = System.Drawing.Color.Yellow;
            this.opt2.Location = new System.Drawing.Point(22, 83);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(46, 17);
            this.opt2.TabIndex = 1;
            this.opt2.TabStop = true;
            this.opt2.Text = "opt2";
            this.opt2.UseVisualStyleBackColor = false;
            this.opt2.CheckedChanged += new System.EventHandler(this.opt2_CheckedChanged);
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.BackColor = System.Drawing.Color.Yellow;
            this.opt3.Location = new System.Drawing.Point(22, 116);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(46, 17);
            this.opt3.TabIndex = 2;
            this.opt3.TabStop = true;
            this.opt3.Text = "opt3";
            this.opt3.UseVisualStyleBackColor = false;
            this.opt3.CheckedChanged += new System.EventHandler(this.opt3_CheckedChanged);
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.BackColor = System.Drawing.Color.Yellow;
            this.opt4.Location = new System.Drawing.Point(22, 150);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(46, 17);
            this.opt4.TabIndex = 3;
            this.opt4.TabStop = true;
            this.opt4.Text = "opt4";
            this.opt4.UseVisualStyleBackColor = false;
            this.opt4.CheckedChanged += new System.EventHandler(this.opt4_CheckedChanged);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGo.Location = new System.Drawing.Point(358, 40);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(103, 71);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // fAsk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 274);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.groupBox1);
            this.Name = "fAsk";
            this.Text = "fAsk";
            this.Load += new System.EventHandler(this.fAsk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton opt4;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.Button btnGo;
    }
}