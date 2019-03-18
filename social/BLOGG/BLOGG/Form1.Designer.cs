namespace BLOGG
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
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.btnOpen3 = new System.Windows.Forms.Button();
            this.btnOpen4 = new System.Windows.Forms.Button();
            this.btnOpen5 = new System.Windows.Forms.Button();
            this.btnOpen6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen1.Location = new System.Drawing.Point(43, 27);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(319, 44);
            this.btnOpen1.TabIndex = 0;
            this.btnOpen1.Text = "YoutubeManuscript_(PopularVersion)";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen2.Location = new System.Drawing.Point(43, 77);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(319, 44);
            this.btnOpen2.TabIndex = 1;
            this.btnOpen2.Text = "BloggingRights";
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // btnOpen3
            // 
            this.btnOpen3.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen3.Location = new System.Drawing.Point(43, 127);
            this.btnOpen3.Name = "btnOpen3";
            this.btnOpen3.Size = new System.Drawing.Size(319, 44);
            this.btnOpen3.TabIndex = 2;
            this.btnOpen3.Text = "MarsReporting";
            this.btnOpen3.UseVisualStyleBackColor = false;
            this.btnOpen3.Click += new System.EventHandler(this.btnOpen3_Click);
            // 
            // btnOpen4
            // 
            this.btnOpen4.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen4.Location = new System.Drawing.Point(43, 177);
            this.btnOpen4.Name = "btnOpen4";
            this.btnOpen4.Size = new System.Drawing.Size(319, 44);
            this.btnOpen4.TabIndex = 3;
            this.btnOpen4.Text = "IMCF";
            this.btnOpen4.UseVisualStyleBackColor = false;
            this.btnOpen4.Click += new System.EventHandler(this.btnOpen4_Click);
            // 
            // btnOpen5
            // 
            this.btnOpen5.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen5.Location = new System.Drawing.Point(43, 227);
            this.btnOpen5.Name = "btnOpen5";
            this.btnOpen5.Size = new System.Drawing.Size(319, 44);
            this.btnOpen5.TabIndex = 4;
            this.btnOpen5.Text = "VideoEditer";
            this.btnOpen5.UseVisualStyleBackColor = false;
            this.btnOpen5.Click += new System.EventHandler(this.btnOpen5_Click);
            // 
            // btnOpen6
            // 
            this.btnOpen6.BackColor = System.Drawing.Color.Yellow;
            this.btnOpen6.Location = new System.Drawing.Point(43, 277);
            this.btnOpen6.Name = "btnOpen6";
            this.btnOpen6.Size = new System.Drawing.Size(319, 44);
            this.btnOpen6.TabIndex = 5;
            this.btnOpen6.Text = "TechnicalDrawings";
            this.btnOpen6.UseVisualStyleBackColor = false;
            this.btnOpen6.Click += new System.EventHandler(this.btnOpen6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpen6);
            this.Controls.Add(this.btnOpen5);
            this.Controls.Add(this.btnOpen4);
            this.Controls.Add(this.btnOpen3);
            this.Controls.Add(this.btnOpen2);
            this.Controls.Add(this.btnOpen1);
            this.Name = "Form1";
            this.Text = "BLOGG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen1;
        private System.Windows.Forms.Button btnOpen2;
        private System.Windows.Forms.Button btnOpen3;
        private System.Windows.Forms.Button btnOpen4;
        private System.Windows.Forms.Button btnOpen5;
        private System.Windows.Forms.Button btnOpen6;
    }
}

