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
    public partial class FrmGakuseiHenko : Form
    {
        public FrmGakuseiHenko()
        {
            InitializeComponent();
        }

        private void btnKakunin_Click(object sender, EventArgs e)
        {
            if (txtGakuno.Text != "")
            {
                GakuseiTable gakuseiTable = new GakuseiTable();
                Gakusei gakusei = gakuseiTable.GetGakuseiByGakuNo(txtGakuno.Text);
                if (gakusei != null)
                {

                   
                        txtGakuMei.Text = gakusei.GakuName;
                        txtMail.Text=gakusei.MailAddress;
                    if (gakusei.Zaiseki)
                    {
                        cbZaiseki.Checked = true;
                    }
                    txtGakuMei.ReadOnly = false;
                    txtMail.ReadOnly = false;
                    cbZaiseki.Enabled = true;
                        

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

        private void btnHen_Click(object sender, EventArgs e)
        {   
            Gakusei gakusei=new Gakusei();
            GakuseiTable gakuseiTable=new GakuseiTable();
            gakusei.GakuName = txtGakuMei.Text;
            gakusei.MailAddress = txtMail.Text;
            gakusei.Zaiseki = cbZaiseki.Checked;

            int ret = gakuseiTable.Update(gakusei);
            if (ret==1)
            {
                MessageBox.Show("Seikou", "uraa", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
