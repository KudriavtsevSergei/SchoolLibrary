namespace ToshoSystem
{
    partial class FrmYoyakuTorikeshi
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
            this.btnKakunin = new System.Windows.Forms.Button();
            this.txtGakuNo = new System.Windows.Forms.TextBox();
            this.txtGakuMei = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YoyakuDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnTorikeshi = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "学籍番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "氏名";
            // 
            // btnKakunin
            // 
            this.btnKakunin.Location = new System.Drawing.Point(409, 34);
            this.btnKakunin.Name = "btnKakunin";
            this.btnKakunin.Size = new System.Drawing.Size(97, 23);
            this.btnKakunin.TabIndex = 2;
            this.btnKakunin.Text = "予約確認";
            this.btnKakunin.UseVisualStyleBackColor = true;
            this.btnKakunin.Click += new System.EventHandler(this.btnKakunin_Click);
            // 
            // txtGakuNo
            // 
            this.txtGakuNo.Location = new System.Drawing.Point(126, 34);
            this.txtGakuNo.Name = "txtGakuNo";
            this.txtGakuNo.Size = new System.Drawing.Size(251, 23);
            this.txtGakuNo.TabIndex = 3;
            // 
            // txtGakuMei
            // 
            this.txtGakuMei.Location = new System.Drawing.Point(126, 81);
            this.txtGakuMei.Name = "txtGakuMei";
            this.txtGakuMei.ReadOnly = true;
            this.txtGakuMei.Size = new System.Drawing.Size(251, 23);
            this.txtGakuMei.TabIndex = 4;
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isbn,
            this.Title,
            this.YoyakuDate});
            this.dgvShow.Location = new System.Drawing.Point(48, 135);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.RowTemplate.Height = 21;
            this.dgvShow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvShow.Size = new System.Drawing.Size(693, 150);
            this.dgvShow.TabIndex = 5;
            this.dgvShow.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShow_CellContentDoubleClick);
            // 
            // Isbn
            // 
            this.Isbn.DataPropertyName = "Isbn";
            this.Isbn.HeaderText = "ISBNコード";
            this.Isbn.Name = "Isbn";
            this.Isbn.Width = 150;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "タイトル";
            this.Title.Name = "Title";
            this.Title.Width = 320;
            // 
            // YoyakuDate
            // 
            this.YoyakuDate.DataPropertyName = "YoyakuDate";
            this.YoyakuDate.HeaderText = "予約時間";
            this.YoyakuDate.Name = "YoyakuDate";
            this.YoyakuDate.Width = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISBNコード";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "タイトル";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(126, 324);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(251, 23);
            this.txtIsbn.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(126, 369);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(452, 23);
            this.txtTitle.TabIndex = 9;
            // 
            // btnTorikeshi
            // 
            this.btnTorikeshi.Location = new System.Drawing.Point(48, 418);
            this.btnTorikeshi.Name = "btnTorikeshi";
            this.btnTorikeshi.Size = new System.Drawing.Size(97, 23);
            this.btnTorikeshi.TabIndex = 10;
            this.btnTorikeshi.Text = "予約の取消";
            this.btnTorikeshi.UseVisualStyleBackColor = true;
            this.btnTorikeshi.Click += new System.EventHandler(this.btnTorikeshi_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(201, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmYoyakuTorikeshi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 497);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTorikeshi);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.txtGakuMei);
            this.Controls.Add(this.txtGakuNo);
            this.Controls.Add(this.btnKakunin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmYoyakuTorikeshi";
            this.Text = "貸出予約取消";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKakunin;
        private System.Windows.Forms.TextBox txtGakuNo;
        private System.Windows.Forms.TextBox txtGakuMei;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnTorikeshi;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn YoyakuDate;
    }
}