using Limilabs.Client.IMAP;
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

namespace Мыло
{
    public partial class Auth : Form
    {
        _email email1 = new _email();
        public Auth(_email email)
        {
            this.email1 = email;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            email1.Username = textBox1.Text;
            email1.Password = textBox2.Text;
            string smtp = null;
            int k = 0;
            foreach (char s in email1.Username)
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
                        email1.domein += smtp;
                    }
                    catch { MessageBox.Show("Несуществующий хост", "Внимание!"); }

                    try
                    {
                        imap.Login(email1.Username, email1.Password);
                        email1.verified = true;
                        MessageBox.Show("Все ок!");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Неверный логин или пароль", "Ошибка!");
                    }
                    imap.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы не сохранили данные", "Внимание", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}


    }
}

