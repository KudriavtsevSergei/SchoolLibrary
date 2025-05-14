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
    public partial class FrmKashidashi : Form
    {
        public FrmKashidashi()
        {
            InitializeComponent();
        }

        private void btnGakuseiKakuninn_Click(object sender, EventArgs e)
        {
            if (txtGakuno.Text!= "")
            {
                GakuseiTable gakuseiTable = new GakuseiTable();
                Gakusei gakusei = gakuseiTable.GetGakuseiByGakuNo(txtGakuno.Text);
                if (gakusei != null)
                {
                   
                    if (gakusei.Zaiseki)
                    {
                        txtGakuMei.Text = gakusei.GakuName;
                        DisplayKashidashi();

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

        private void btnToshoKakunin_Click(object sender, EventArgs e)
        {
            DisplayTosho();
        }

        private void btnKashidashi_Click(object sender, EventArgs e)
        {

            if (txtGakuno.Text != "" && txtISBN.Text != "")
            {
                KashidashiTable kashidashiTable = new KashidashiTable();
                Kashidashi kashidashi = new Kashidashi();


                kashidashi.GakuNo = txtGakuno.Text;
                kashidashi.Isbn = txtISBN.Text;
                kashidashi.KashiDate = DateTime.Today;
                kashidashi.YoteiDate = DateTime.Today.AddDays(14);

                int ret = kashidashiTable.Insert(kashidashi);

                if (ret > 0)
                {
                    DisplayKashidashi();
                }
                YoyakuTable yoyakuTable = new YoyakuTable();
                if (yoyakuTable.IsYoyaku(txtISBN.Text, txtGakuno.Text))
                {
                    yoyakuTable.Delete(txtISBN.Text, txtGakuno.Text);
                }

            }
            else
            {
                MessageBox.Show("学生番合,Isbnを入力してください", "未入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisplayKashidashi()
        {
            KashidashiTable kashidashiTable = new KashidashiTable();
            DataTable dt = kashidashiTable.GetKashidashiTableByGakuNo(txtGakuno.Text);
            dgvInfo.AutoGenerateColumns = false;
            dgvInfo.DataSource = dt;
        }
        private void DisplayTosho()
        {
            if (txtISBN.Text != "")
            {
                BookTable bookTable = new BookTable();
                Book book = bookTable.GetBookByIsbn(txtISBN.Text);
                if (book != null)
                {
                    txtTittle.Text = book.Title;
                    MessageBox.Show("図書確認しました", "図書の確認", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    KashidashiTable kashidashiTable = new KashidashiTable();
                    if (kashidashiTable.IsKashiDashi(txtISBN.Text))
                    {
                        MessageBox.Show("図書が貸出中", "貸し出しエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTittle.Text = "";
                        txtISBN.Text = "";

                    }
                }
                else
                {
                    MessageBox.Show("図書が存在しない", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ISBNを入力してください", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnToshoKakunin.PerformClick();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
