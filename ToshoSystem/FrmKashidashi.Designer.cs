namespace ToshoSystem
{
    partial class FrmKashidashi
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
            this.lblGakuNo = new System.Windows.Forms.Label();
            this.lblGakumei = new System.Windows.Forms.Label();
            this.txtGakuno = new System.Windows.Forms.TextBox();
            this.txtGakuMei = new System.Windows.Forms.TextBox();
            this.btnGakuseiKakuninn = new System.Windows.Forms.Button();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.btnToshoKakunin = new System.Windows.Forms.Button();
            this.txtTittle = new System.Windows.Forms.TextBox();
            this.btnKashidashi = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kashidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yoteidate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGakuNo
            // 
            this.lblGakuNo.AutoSize = true;
            this.lblGakuNo.Location = new System.Drawing.Point(27, 31);
            this.lblGakuNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGakuNo.Name = "lblGakuNo";
            this.lblGakuNo.Size = new System.Drawing.Size(85, 19);
            this.lblGakuNo.TabIndex = 0;
            this.lblGakuNo.Text = "学生番号";
            // 
            // lblGakumei
            // 
            this.lblGakumei.AutoSize = true;
            this.lblGakumei.Location = new System.Drawing.Point(27, 83);
            this.lblGakumei.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblGakumei.Name = "lblGakumei";
            this.lblGakumei.Size = new System.Drawing.Size(47, 19);
            this.lblGakumei.TabIndex = 1;
            this.lblGakumei.Text = "氏名";
            // 
            // txtGakuno
            // 
            this.txtGakuno.Location = new System.Drawing.Point(128, 24);
            this.txtGakuno.Name = "txtGakuno";
            this.txtGakuno.Size = new System.Drawing.Size(222, 26);
            this.txtGakuno.TabIndex = 2;
            // 
            // txtGakuMei
            // 
            this.txtGakuMei.Location = new System.Drawing.Point(128, 76);
            this.txtGakuMei.Name = "txtGakuMei";
            this.txtGakuMei.ReadOnly = true;
            this.txtGakuMei.Size = new System.Drawing.Size(222, 26);
            this.txtGakuMei.TabIndex = 3;
            // 
            // btnGakuseiKakuninn
            // 
            this.btnGakuseiKakuninn.Location = new System.Drawing.Point(406, 24);
            this.btnGakuseiKakuninn.Name = "btnGakuseiKakuninn";
            this.btnGakuseiKakuninn.Size = new System.Drawing.Size(149, 26);
            this.btnGakuseiKakuninn.TabIndex = 4;
            this.btnGakuseiKakuninn.Text = "学生確認";
            this.btnGakuseiKakuninn.UseVisualStyleBackColor = true;
            this.btnGakuseiKakuninn.Click += new System.EventHandler(this.btnGakuseiKakuninn_Click);
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbn,
            this.title,
            this.kashidate,
            this.yoteidate});
            this.dgvInfo.Location = new System.Drawing.Point(31, 142);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowTemplate.Height = 21;
            this.dgvInfo.Size = new System.Drawing.Size(849, 150);
            this.dgvInfo.TabIndex = 5;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.Location = new System.Drawing.Point(27, 327);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(92, 19);
            this.lblIsbn.TabIndex = 6;
            this.lblIsbn.Text = "ISBNコード";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(27, 371);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 19);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "タイトル";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(128, 327);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(222, 26);
            this.txtISBN.TabIndex = 8;
            this.txtISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtISBN_KeyPress);
            // 
            // btnToshoKakunin
            // 
            this.btnToshoKakunin.Location = new System.Drawing.Point(406, 327);
            this.btnToshoKakunin.Name = "btnToshoKakunin";
            this.btnToshoKakunin.Size = new System.Drawing.Size(149, 26);
            this.btnToshoKakunin.TabIndex = 9;
            this.btnToshoKakunin.Text = "図書確認";
            this.btnToshoKakunin.UseVisualStyleBackColor = true;
            this.btnToshoKakunin.Click += new System.EventHandler(this.btnToshoKakunin_Click);
            // 
            // txtTittle
            // 
            this.txtTittle.Location = new System.Drawing.Point(128, 368);
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.ReadOnly = true;
            this.txtTittle.Size = new System.Drawing.Size(427, 26);
            this.txtTittle.TabIndex = 10;
            // 
            // btnKashidashi
            // 
            this.btnKashidashi.Location = new System.Drawing.Point(31, 424);
            this.btnKashidashi.Name = "btnKashidashi";
            this.btnKashidashi.Size = new System.Drawing.Size(166, 36);
            this.btnKashidashi.TabIndex = 11;
            this.btnKashidashi.Text = "貸し出し";
            this.btnKashidashi.UseVisualStyleBackColor = true;
            this.btnKashidashi.Click += new System.EventHandler(this.btnKashidashi_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(240, 424);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 36);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // isbn
            // 
            this.isbn.DataPropertyName = "isbn";
            this.isbn.HeaderText = "ISBNコード";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Width = 200;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "タイトル";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 300;
            // 
            // kashidate
            // 
            this.kashidate.DataPropertyName = "kashidate";
            this.kashidate.HeaderText = "貸し出し年月日";
            this.kashidate.Name = "kashidate";
            this.kashidate.ReadOnly = true;
            this.kashidate.Width = 155;
            // 
            // yoteidate
            // 
            this.yoteidate.DataPropertyName = "yoteidate";
            this.yoteidate.HeaderText = "返却予定";
            this.yoteidate.Name = "yoteidate";
            this.yoteidate.ReadOnly = true;
            this.yoteidate.Width = 150;
            // 
            // FrmKashidashi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 485);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnKashidashi);
            this.Controls.Add(this.txtTittle);
            this.Controls.Add(this.btnToshoKakunin);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblIsbn);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.btnGakuseiKakuninn);
            this.Controls.Add(this.txtGakuMei);
            this.Controls.Add(this.txtGakuno);
            this.Controls.Add(this.lblGakumei);
            this.Controls.Add(this.lblGakuNo);
            this.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKashidashi";
            this.Text = "FrmKashidashi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGakuNo;
        private System.Windows.Forms.Label lblGakumei;
        private System.Windows.Forms.TextBox txtGakuno;
        private System.Windows.Forms.TextBox txtGakuMei;
        private System.Windows.Forms.Button btnGakuseiKakuninn;
        private System.Windows.Forms.DataGridView dgvInfo;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Button btnToshoKakunin;
        private System.Windows.Forms.TextBox txtTittle;
        private System.Windows.Forms.Button btnKashidashi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn kashidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn yoteidate;
    }
}