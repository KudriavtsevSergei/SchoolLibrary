using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToshoLibrary;

namespace ToshoSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKashiDashi_Click(object sender, EventArgs e)
        {
            FrmKashidashi kashidashi = new FrmKashidashi();
            kashidashi.ShowDialog();
        }

        private void btnHenkyaku_Click(object sender, EventArgs e)
        {
            FrmHenkyaku henkyaku=new FrmHenkyaku();
            henkyaku.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmYoyaku yoyaku=new FrmYoyaku();
            yoyaku.ShowDialog();
        }

        private void btnTorikesu_Click(object sender, EventArgs e)
        {
            FrmYoyakuTorikeshi torikeshi = new FrmYoyakuTorikeshi();
            torikeshi.ShowDialog();
        }

        private void btnToroku_Click(object sender, EventArgs e)
        {   
            DialogResult result = ofdGakusei.ShowDialog();
            if (result == DialogResult.OK)
            {
            
                GakuseiTable gakuseiTable = new GakuseiTable();

                using (StreamReader file = new StreamReader(ofdGakusei.FileName))
                {
                    int cnt = 0;

                    while (!file.EndOfStream)
                    {
                        Gakusei gakusei = new Gakusei();
                        string line = file.ReadLine();
                        string[] fields = line.Split(',');
                        gakusei.GakunNo=fields[0];
                        gakusei.GakuName=fields[1];
                        gakusei.MailAddress=fields[2];
                        gakusei.Zaiseki = bool.Parse(fields[3]);

                        cnt+=gakuseiTable.Insert(gakusei);

                   
                  
                    }
                    if(cnt != 0)
                    {
                        MessageBox.Show("学生を" + cnt + "件登録しました", "学生登録", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("学生登録しません", "学生登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmGakuseiHenko　hen=new FrmGakuseiHenko();
            hen.ShowDialog();
        }
    }
}
