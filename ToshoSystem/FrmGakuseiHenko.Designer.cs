namespace ToshoSystem
{
    partial class FrmGakuseiHenko
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGakuno = new System.Windows.Forms.TextBox();
            this.txtGakuMei = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKakunin = new System.Windows.Forms.Button();
            this.cbZaiseki = new System.Windows.Forms.CheckBox();
            this.btnHen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(64, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "学籍番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(64, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "氏名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(64, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "メールアドレス";
            // 
            // txtGakuno
            // 
            this.txtGakuno.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.txtGakuno.Location = new System.Drawing.Point(201, 54);
            this.txtGakuno.Name = "txtGakuno";
            this.txtGakuno.Size = new System.Drawing.Size(276, 27);
            this.txtGakuno.TabIndex = 3;
            // 
            // txtGakuMei
            // 
            this.txtGakuMei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.txtGakuMei.Location = new System.Drawing.Point(201, 127);
            this.txtGakuMei.Name = "txtGakuMei";
            this.txtGakuMei.ReadOnly = true;
            this.txtGakuMei.Size = new System.Drawing.Size(276, 27);
            this.txtGakuMei.TabIndex = 4;
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.txtMail.Location = new System.Drawing.Point(201, 198);
            this.txtMail.Name = "txtMail";
            this.txtMail.ReadOnly = true;
            this.txtMail.Size = new System.Drawing.Size(276, 27);
            this.txtMail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(64, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "在籍";
            // 
            // btnKakunin
            // 
            this.btnKakunin.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.btnKakunin.Location = new System.Drawing.Point(539, 58);
            this.btnKakunin.Name = "btnKakunin";
            this.btnKakunin.Size = new System.Drawing.Size(176, 27);
            this.btnKakunin.TabIndex = 7;
            this.btnKakunin.Text = "学生確認";
            this.btnKakunin.UseVisualStyleBackColor = true;
            this.btnKakunin.Click += new System.EventHandler(this.btnKakunin_Click);
            // 
            // cbZaiseki
            // 
            this.cbZaiseki.AutoSize = true;
            this.cbZaiseki.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.cbZaiseki.Location = new System.Drawing.Point(201, 285);
            this.cbZaiseki.Name = "cbZaiseki";
            this.cbZaiseki.Size = new System.Drawing.Size(68, 24);
            this.cbZaiseki.TabIndex = 8;
            this.cbZaiseki.Text = "在籍";
            this.cbZaiseki.UseVisualStyleBackColor = true;
            // 
            // btnHen
            // 
            this.btnHen.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.btnHen.Location = new System.Drawing.Point(68, 366);
            this.btnHen.Name = "btnHen";
            this.btnHen.Size = new System.Drawing.Size(176, 27);
            this.btnHen.TabIndex = 9;
            this.btnHen.Text = "変更";
            this.btnHen.UseVisualStyleBackColor = true;
            this.btnHen.Click += new System.EventHandler(this.btnHen_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.btnClose.Location = new System.Drawing.Point(301, 366);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(176, 27);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmGakuseiHenko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnHen);
            this.Controls.Add(this.cbZaiseki);
            this.Controls.Add(this.btnKakunin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtGakuMei);
            this.Controls.Add(this.txtGakuno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGakuseiHenko";
            this.Text = "マスターメンテナンス（学生情報登録）";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGakuno;
        private System.Windows.Forms.TextBox txtGakuMei;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKakunin;
        private System.Windows.Forms.CheckBox cbZaiseki;
        private System.Windows.Forms.Button btnHen;
        private System.Windows.Forms.Button btnClose;
    }
}