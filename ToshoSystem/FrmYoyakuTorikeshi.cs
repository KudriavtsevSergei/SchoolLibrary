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

namespace ToshoSystem
{
    public partial class FrmYoyakuTorikeshi : Form
    {
        public FrmYoyakuTorikeshi()
        {
            InitializeComponent();
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
                        txtGakuMei.Text = gakusei.GakuName;
                        YoyakuTable yoyakuTable = new YoyakuTable();
                        DataTable dt = yoyakuTable.GetYoyakuByGakuno(txtGakuNo.Text);
                        dgvShow.AutoGenerateColumns = false;
                        dgvShow.DataSource = dt;

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

        private void dgvShow_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtIsbn.Text = dgvShow.CurrentRow.Cells["Isbn"].Value.ToString();
                txtTitle.Text = dgvShow.CurrentRow.Cells["Title"].Value.ToString();
            }
        }

        private void btnTorikeshi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("消していいですか？", "予約の削除", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                YoyakuTable yoyakuTable = new YoyakuTable();
                int ret = yoyakuTable.Delete(txtIsbn.Text,txtGakuNo.Text );
                if (ret == 1)
                {
                    MessageBox.Show("予約が消された", "予約の取り消し", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
