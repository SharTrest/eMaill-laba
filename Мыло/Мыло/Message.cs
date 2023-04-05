using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limilabs.Mail;
using Limilabs.Client.IMAP;
using Limilabs.Mail.MIME;
using Limilabs.Mail.Headers;
using Microsoft.VisualBasic.Logging;


namespace Мыло
{
    public partial class Message : Form
    {
        _email email1;
        public Message(_email email)
        {
            email1 = email;
            InitializeComponent();
            check_mail();
        }

        private void check_mail()
        {
            using (Imap imap = new Imap())
            {
                string imp = "imap." + email1.domein.ToString();
                imap.Connect(imp);
                try
                {
                    imap.Login(email1.Username, email1.Password);
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
            i = listView1.Items.Add(adress).Index;
            listView1.Items[i].SubItems.Add(subj);

        }
    }

}
