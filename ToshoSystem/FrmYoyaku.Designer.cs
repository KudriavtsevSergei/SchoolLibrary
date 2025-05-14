namespace ToshoSystem
{
    partial class FrmYoyaku
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnKensaku = new System.Windows.Forms.Button();
            this.dvgYoyaku = new System.Windows.Forms.DataGridView();
            this.Isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtTitle2 = new System.Windows.Forms.TextBox();
            this.txtWriter = new System.Windows.Forms.TextBox();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGakuNo = new System.Windows.Forms.TextBox();
            this.txtGakumei = new System.Windows.Forms.TextBox();
            this.btnYoyaku = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnKakunin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgYoyaku)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "図書のタイトル（－部）";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(148, 17);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(192, 19);
            this.txtTitle.TabIndex = 1;
            // 
            // btnKensaku
            // 
            this.btnKensaku.Location = new System.Drawing.Point(349, 13);
            this.btnKensaku.Name = "btnKensaku";
            this.btnKensaku.Size = new System.Drawing.Size(137, 23);
            this.btnKensaku.TabIndex = 2;
            this.btnKensaku.Text = "検索";
            this.btnKensaku.UseVisualStyleBackColor = true;
            this.btnKensaku.Click += new System.EventHandler(this.btnKensaku_Click);
            // 
            // dvgYoyaku
            // 
            this.dvgYoyaku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgYoyaku.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Isbn,
            this.Title,
            this.Writer,
            this.Publisher});
            this.dvgYoyaku.Location = new System.Drawing.Point(34, 67);
            this.dvgYoyaku.Name = "dvgYoyaku";
            this.dvgYoyaku.RowTemplate.Height = 21;
            this.dvgYoyaku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgYoyaku.Size = new System.Drawing.Size(738, 115);
            this.dvgYoyaku.TabIndex = 3;
            this.dvgYoyaku.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgYoyaku_CellContentDoubleClick);
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
            this.Title.Width = 250;
            // 
            // Writer
            // 
            this.Writer.DataPropertyName = "Writer";
            this.Writer.HeaderText = "著者";
            this.Writer.Name = "Writer";
            this.Writer.Width = 160;
            // 
            // Publisher
            // 
            this.Publisher.DataPropertyName = "Publisher";
            this.Publisher.HeaderText = "出版社";
            this.Publisher.Name = "Publisher";
            this.Publisher.Width = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "タイトル";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "著者";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "出版社";
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(102, 203);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.ReadOnly = true;
            this.txtIsbn.Size = new System.Drawing.Size(192, 19);
            this.txtIsbn.TabIndex = 8;
            // 
            // txtTitle2
            // 
            this.txtTitle2.Location = new System.Drawing.Point(102, 225);
            this.txtTitle2.Name = "txtTitle2";
            this.txtTitle2.ReadOnly = true;
            this.txtTitle2.Size = new System.Drawing.Size(371, 19);
            this.txtTitle2.TabIndex = 9;
            // 
            // txtWriter
            // 
            this.txtWriter.Location = new System.Drawing.Point(102, 248);
            this.txtWriter.Name = "txtWriter";
            this.txtWriter.ReadOnly = true;
            this.txtWriter.Size = new System.Drawing.Size(371, 19);
            this.txtWriter.TabIndex = 10;
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(102, 273);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.ReadOnly = true;
            this.txtPublisher.Size = new System.Drawing.Size(371, 19);
            this.txtPublisher.TabIndex = 11;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(34, 310);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(439, 19);
            this.txtStatus.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "学籍番号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 369);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "氏名";
            // 
            // txtGakuNo
            // 
            this.txtGakuNo.Location = new System.Drawing.Point(102, 341);
            this.txtGakuNo.Name = "txtGakuNo";
            this.txtGakuNo.Size = new System.Drawing.Size(201, 19);
            this.txtGakuNo.TabIndex = 15;
            // 
            // txtGakumei
            // 
            this.txtGakumei.Location = new System.Drawing.Point(102, 362);
            this.txtGakumei.Name = "txtGakumei";
            this.txtGakumei.ReadOnly = true;
            this.txtGakumei.Size = new System.Drawing.Size(201, 19);
            this.txtGakumei.TabIndex = 16;
            // 
            // btnYoyaku
            // 
            this.btnYoyaku.Enabled = false;
            this.btnYoyaku.Location = new System.Drawing.Point(34, 406);
            this.btnYoyaku.Name = "btnYoyaku";
            this.btnYoyaku.Size = new System.Drawing.Size(137, 23);
            this.btnYoyaku.TabIndex = 17;
            this.btnYoyaku.Text = "予約";
            this.btnYoyaku.UseVisualStyleBackColor = true;
            this.btnYoyaku.Click += new System.EventHandler(this.btnYoyaku_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(203, 406);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(137, 23);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "閉じる";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnKakunin
            // 
            this.btnKakunin.Location = new System.Drawing.Point(349, 339);
            this.btnKakunin.Name = "btnKakunin";
            this.btnKakunin.Size = new System.Drawing.Size(137, 23);
            this.btnKakunin.TabIndex = 19;
            this.btnKakunin.Text = "学生の確認";
            this.btnKakunin.UseVisualStyleBackColor = true;
            this.btnKakunin.Click += new System.EventHandler(this.btnKakunin_Click);
            // 
            // FrmYoyaku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.btnKakunin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnYoyaku);
            this.Controls.Add(this.txtGakumei);
            this.Controls.Add(this.txtGakuNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPublisher);
            this.Controls.Add(this.txtWriter);
            this.Controls.Add(this.txtTitle2);
            this.Controls.Add(this.txtIsbn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dvgYoyaku);
            this.Controls.Add(this.btnKensaku);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Name = "FrmYoyaku";
            this.Text = "貸出予約";
            ((System.ComponentModel.ISupportInitialize)(this.dvgYoyaku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnKensaku;
        private System.Windows.Forms.DataGridView dvgYoyaku;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtTitle2;
        private System.Windows.Forms.TextBox txtWriter;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGakuNo;
        private System.Windows.Forms.TextBox txtGakumei;
        private System.Windows.Forms.Button btnYoyaku;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnKakunin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publisher;
    }
}