namespace PLTCT
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnLookup4 = new System.Windows.Forms.Button();
            this.btnLookup1 = new System.Windows.Forms.Button();
            this.btnLookup3 = new System.Windows.Forms.Button();
            this.btnLookup2 = new System.Windows.Forms.Button();
            this.btnQNext = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.lst1 = new System.Windows.Forms.ComboBox();
            this.lst2 = new System.Windows.Forms.ComboBox();
            this.lst3 = new System.Windows.Forms.ComboBox();
            this.lst4 = new System.Windows.Forms.ComboBox();
            this.btnChecklist = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(566, 359);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(614, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnLookup4
            // 
            this.btnLookup4.Location = new System.Drawing.Point(480, 74);
            this.btnLookup4.Name = "btnLookup4";
            this.btnLookup4.Size = new System.Drawing.Size(33, 31);
            this.btnLookup4.TabIndex = 2;
            this.btnLookup4.Text = "L4";
            this.btnLookup4.UseVisualStyleBackColor = true;
            this.btnLookup4.Click += new System.EventHandler(this.btnLookup4_Click);
            // 
            // btnLookup1
            // 
            this.btnLookup1.Location = new System.Drawing.Point(192, 87);
            this.btnLookup1.Name = "btnLookup1";
            this.btnLookup1.Size = new System.Drawing.Size(33, 31);
            this.btnLookup1.TabIndex = 3;
            this.btnLookup1.Text = "L1";
            this.btnLookup1.UseVisualStyleBackColor = true;
            this.btnLookup1.Click += new System.EventHandler(this.btnLookup1_Click);
            // 
            // btnLookup3
            // 
            this.btnLookup3.Location = new System.Drawing.Point(402, 156);
            this.btnLookup3.Name = "btnLookup3";
            this.btnLookup3.Size = new System.Drawing.Size(33, 31);
            this.btnLookup3.TabIndex = 4;
            this.btnLookup3.Text = "L3";
            this.btnLookup3.UseVisualStyleBackColor = true;
            this.btnLookup3.Click += new System.EventHandler(this.btnLookup3_Click);
            // 
            // btnLookup2
            // 
            this.btnLookup2.Location = new System.Drawing.Point(125, 261);
            this.btnLookup2.Name = "btnLookup2";
            this.btnLookup2.Size = new System.Drawing.Size(33, 31);
            this.btnLookup2.TabIndex = 5;
            this.btnLookup2.Text = "L2";
            this.btnLookup2.UseVisualStyleBackColor = true;
            this.btnLookup2.Click += new System.EventHandler(this.btnLookup2_Click);
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(957, 44);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(81, 92);
            this.btnQNext.TabIndex = 6;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.Yellow;
            this.lblMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonth.Location = new System.Drawing.Point(620, 212);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(48, 15);
            this.lblMonth.TabIndex = 7;
            this.lblMonth.Text = "Month =";
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(623, 244);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(74, 17);
            this.chk1.TabIndex = 8;
            this.chk1.Text = "strawberry";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(623, 267);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(74, 17);
            this.chk2.TabIndex = 9;
            this.chk2.Text = "strawberry";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(623, 290);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(74, 17);
            this.chk3.TabIndex = 10;
            this.chk3.Text = "strawberry";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(623, 313);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(74, 17);
            this.chk4.TabIndex = 11;
            this.chk4.Text = "strawberry";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Items.AddRange(new object[] {
            "(L1) Orchard",
            "(L2) Coldframe",
            "(L3) thepits",
            "(L4) theraking"});
            this.lst1.Location = new System.Drawing.Point(721, 244);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(112, 21);
            this.lst1.TabIndex = 12;
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Items.AddRange(new object[] {
            "(L1) Orchard",
            "(L2) Coldframe",
            "(L3) thepits",
            "(L4) theraking"});
            this.lst2.Location = new System.Drawing.Point(721, 263);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(112, 21);
            this.lst2.TabIndex = 13;
            // 
            // lst3
            // 
            this.lst3.FormattingEnabled = true;
            this.lst3.Items.AddRange(new object[] {
            "(L1) Orchard",
            "(L2) Coldframe",
            "(L3) thepits",
            "(L4) theraking"});
            this.lst3.Location = new System.Drawing.Point(721, 286);
            this.lst3.Name = "lst3";
            this.lst3.Size = new System.Drawing.Size(112, 21);
            this.lst3.TabIndex = 14;
            // 
            // lst4
            // 
            this.lst4.FormattingEnabled = true;
            this.lst4.Items.AddRange(new object[] {
            "(L1) Orchard",
            "(L2) Coldframe",
            "(L3) thepits",
            "(L4) theraking"});
            this.lst4.Location = new System.Drawing.Point(721, 311);
            this.lst4.Name = "lst4";
            this.lst4.Size = new System.Drawing.Size(112, 21);
            this.lst4.TabIndex = 15;
            // 
            // btnChecklist
            // 
            this.btnChecklist.BackColor = System.Drawing.Color.Yellow;
            this.btnChecklist.Location = new System.Drawing.Point(957, 142);
            this.btnChecklist.Name = "btnChecklist";
            this.btnChecklist.Size = new System.Drawing.Size(81, 45);
            this.btnChecklist.TabIndex = 16;
            this.btnChecklist.Text = "Checklist";
            this.btnChecklist.UseVisualStyleBackColor = false;
            this.btnChecklist.Click += new System.EventHandler(this.btnChecklist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 450);
            this.Controls.Add(this.btnChecklist);
            this.Controls.Add(this.lst4);
            this.Controls.Add(this.lst3);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.chk4);
            this.Controls.Add(this.chk3);
            this.Controls.Add(this.chk2);
            this.Controls.Add(this.chk1);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.btnLookup2);
            this.Controls.Add(this.btnLookup3);
            this.Controls.Add(this.btnLookup1);
            this.Controls.Add(this.btnLookup4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "PLTCT";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnLookup4;
        private System.Windows.Forms.Button btnLookup1;
        private System.Windows.Forms.Button btnLookup3;
        private System.Windows.Forms.Button btnLookup2;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.ComboBox lst1;
        private System.Windows.Forms.ComboBox lst2;
        private System.Windows.Forms.ComboBox lst3;
        private System.Windows.Forms.ComboBox lst4;
        private System.Windows.Forms.Button btnChecklist;
    }
}

