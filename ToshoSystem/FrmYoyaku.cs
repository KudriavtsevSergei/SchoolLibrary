using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToshoLibrary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ToshoSystem
{
    public partial class FrmYoyaku : Form
    {
        public FrmYoyaku()
        {
            InitializeComponent();
        }

        private void btnKensaku_Click(object sender, EventArgs e)
        {
            BookTable bookTable = new BookTable();
            DataTable dt = bookTable.GetBookByTitle(txtTitle.Text);
            dvgYoyaku.AutoGenerateColumns = false;
            dvgYoyaku.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("該当する図書なし", "検索結果0件", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dvgYoyaku_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                txtIsbn.Text = dvgYoyaku.CurrentRow.Cells["Isbn"].Value.ToString();
                txtTitle2.Text = dvgYoyaku.CurrentRow.Cells["Title"].Value.ToString();
                txtWriter.Text = dvgYoyaku.CurrentRow.Cells["Writer"].Value.ToString();
                txtPublisher.Text = dvgYoyaku.CurrentRow.Cells["Publisher"].Value.ToString();

                KashidashiTable kashidashiTable = new KashidashiTable();
                if (kashidashiTable.IsKashiDashi(txtIsbn.Text))
                {
                    txtStatus.Text = "貸出中のため予約可能です";
                }
                else
                {
                    txtStatus.Text = "この本は貸出していないので予約できません";
                }
            }
        }

        private void btnKakunin_Click(object sender, EventArgs e)
        {
            if (txtGakuNo.Text != "")
            {
                GakuseiTable gakuseiTable = new GakuseiTable();
                Gakusei gakusei = gakuseiTable.GetGakuseiByGakuNo(txtGakuNo.Text);
                if (gakusei != null)
                {

                    if (gakusei.Zaiseki)
                    {
                        txtGakumei.Text = gakusei.GakuName;
                        if(txtGakumei.Text!=""&& txtIsbn.Text != "")
                        {
                            btnYoyaku.Enabled = true;
                        }

                    }
                    else
                    {
                        MessageBox.Show("在籍していない", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("学籍番号が存在しない", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("学籍番号を入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnYoyaku_Click(object sender, EventArgs e)
        {
            if (txtGakuNo.Text != "" && txtIsbn.Text != "")
            {
                YoyakuTable yoyakuTable = new YoyakuTable();
                Yoyaku yoyaku = new Yoyaku();
                if (!yoyakuTable.IsYoyaku(txtIsbn.Text, txtGakuNo.Text))
                {


                    yoyaku.GakuNo = txtGakuNo.Text;
                    yoyaku.Isbn = txtIsbn.Text;
                    yoyaku.YoyakuDate = DateTime.Today;


                    int ret = yoyakuTable.Insert(yoyaku);
                    if (ret == 1)
                    {
                        MessageBox.Show("図書が予約されました", "予約完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnYoyaku.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("図書が予約中","予約エラー",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}