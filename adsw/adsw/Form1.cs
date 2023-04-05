using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace adsw
{
   
        public partial class Pochta : Form
        {
            public Pochta()
            {
                InitializeComponent();
            }
            private void button1_Click(object sender, EventArgs e)
            {
                _email email = new _email(textBox3.Text, textBox2.Text, textBox1.Text);
                email.Send();
            }

            private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
            {

            }
        }



        class _email
        {
            public string Email;
            public string Password = "Pfqxbr5!";
            public string Username = "laba-2@rambler.ru";
            public string text_message;
            public string text_subjest;
            SmtpClient smtpClient = new SmtpClient("smtp." + "rambler.ru");

            public _email(string email, string text_subjest, string text_message)
            {
                Email = email;
                this.text_message = text_message;
                this.text_subjest = text_subjest;
            }

            public void Send()
            {
                try
                {
                    smtpClient.UseDefaultCredentials = false;
                    System.Net.NetworkCredential Authentificator = new System.Net.NetworkCredential(Username, Password);
                    smtpClient.Credentials = Authentificator;

                    MailAddress from = new MailAddress(Username, Username);
                    MailAddress to = new MailAddress(Email, Email);
                    MailMessage message = new MailMessage(from, to);

                    message.Subject = text_subjest;
                    message.Body = text_message;

                }
                catch
                {
                    MessageBox.Show("Ошибка отправления");
                }

            }
        }
    }
