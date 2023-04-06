using Limilabs.Client.IMAP;
using Limilabs.Mail.Headers;
using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Мыло
{
    public partial class Mylo : Form
    {
        _email email = new _email();
        public Mylo()
        {
            InitializeComponent();
        }

        private void Auth_button1_Click(object sender, EventArgs e)
        {
            email.Username = Auth_textBox1.Text;
            email.Password = Auth_textBox2.Text;
            string smtp = null;
            int k = 0;
            foreach (char s in email.Username)
            {
                if (k == 1)
                    smtp += s.ToString();
                if (s == '@')
                    k = 1;
            }
            if (smtp == null)
            {
                MessageBox.Show("Введите настоящий почтовый адрес", "Внимание!");
            }
            else
            {
                using (Imap imap = new Imap())
                {

                    string imp = "imap." + smtp.ToString();

                    try
                    {
                        imap.Connect(imp);
                        email.domein = smtp;
                    }
                    catch { MessageBox.Show("Несуществующий хост", "Внимание!"); }

                    try
                    {
                        imap.Login(email.Username, email.Password);
                        email.verified = true;
                        MessageBox.Show("Все ок!");
                    }
                    catch
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка!");
                    }
                    imap.Close();
                }
            }
        }

        private void Auth_button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы не сохранили данные", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Send_mail_button1_Click(object sender, EventArgs e)
        {
            email.Email = Send_mail_textBox3.Text;
            email.text_message = Send_mail_textBox1.Text;
            email.text_subjest = Send_mail_textBox2.Text;
            email.Send();
        }

        private void check_mail()
        {
            using (Imap imap = new Imap())
            {
                string imp = "imap." + email.domein.ToString();
                imap.Connect(imp);
                try
                {
                    imap.Login(email.Username, email.Password);
                    imap.SelectInbox();
                    List<long> uids = imap.Search(Flag.All);

                    foreach (long uid in uids)
                    {
                        var eml = imap.GetMessageByUID(uid);
                        IMail email = new MailBuilder()
                            .CreateFromEml(eml);

                        // From
                        int i = 0;
                        foreach (MailBox m in email.From)
                        {
                            addrow(m.Address, m.Name);
                        }

                    }

                }
                catch
                {
                    MessageBox.Show("Неверный логин или пароль", "Ошибка!");
                }

                imap.Close();

            }

        }

        private void addrow(string adress, string subj)
        {
            int i = 0;
            i = Messages_listView1.Items.Add(adress).Index;
            Messages_listView1.Items[i].SubItems.Add(subj);

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (!email.verified)
            { 
                MessageBox.Show("Пройдите авторизацию", "Внимание");
                tabControl1.SelectedTab = tabControl1.TabPages["TabPage1"];
            }
            if (tabControl1.SelectedTab == tabControl1.TabPages["TabPage3"])
            {
                check_mail();
            }
        }
    }
}
