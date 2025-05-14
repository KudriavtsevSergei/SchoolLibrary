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
    public partial class FrmHenkyaku : Form
    {
        public FrmHenkyaku()
        {
            InitializeComponent();
        }

        private void btnKakunin_Click(object sender, EventArgs e)
        {
            if (txtISBN.Text != "")
            {
                BookTable bookTable = new BookTable();
                Book book = bookTable.GetBookByIsbn(txtISBN.Text);
                if (book != null)
                {
                    txtTitle.Text = book.Title;
                    KashidashiTable kashidashiTable = new KashidashiTable();
                    if (kashidashiTable.IsKashiDashi(txtISBN.Text))
                    {
                        MessageBox.Show("図書が貸出中", "貸し出しエラー", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnHenkyaku.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("図書が貸出可能", "貸し出しエラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHenkyaku_Click(object sender, EventArgs e)
        {
            KashidashiTable kashidashiTable = new KashidashiTable();
            int ret=kashidashiTable.Henkyaky(txtISBN.Text);
            if(ret == 1)
            {
                MessageBox.Show("返却を変更しました", "変更完了", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnHenkyaku.Enabled = false;
                SendMessage();
            }
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnKakunin.PerformClick();
            }
        }

        private void SendMessage()
        {
            YoyakuTable yoyakuTable= new YoyakuTable();
            Yoyaku yoyaku = yoyakuTable.GetYoyakuByIsbn(txtISBN.Text);
            
           
            var message = new MimeKit.MimeMessage();
            message.From.Add(new MimeKit.MailboxAddress("日本電子専門学校　図書室", "24jn0113@jec.ac.jp"));
            message.To.Add(new MimeKit.MailboxAddress(yoyaku.GakuName, "24jn0113@jec.ac.jp"));
            message.Subject = "予約図書の貸出が可能になりました";
            var textPart = new MimeKit.TextPart(MimeKit.Text.TextFormat.Plain);

            string mail;

            mail=
                yoyaku.GakuNo + " " + yoyaku.GakuName + " " + "さん\n\n" +
                 "日本電子専門学校の図書室です\n\n" +
                 yoyaku.GakuName + "さんの予約している以下の図書が貸出可能になりました\n" +
                     "図書タイトル : " + yoyaku.Title + "\n\n" +
                 "図書は図書室の受付に取り置いていますので、受付担当にお声がけ下さい\n" +
                     "本日より１週間経過すると次の予約者へ貸し出しますので、ご注意下さい\n\n" +
                 "--------------------------------------------------------------------------\n" +
                 "　　日本電子専門学校　図書室(３号館１階)\n" +
                 "　　問い合わせ : 03-xxxx-xxxx\n" +
                  "--------------------------------------------------------------------------";
            textPart.Text = mail;
            message.Body = textPart;
            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 465);
                client.Authenticate("24jn0113@jec.ac.jp", "DmFWsV8ek7uK");
                client.Send(message);
            }

        }
      
    }
}
