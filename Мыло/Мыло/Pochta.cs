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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Мыло
{
    public partial class Pochta : Form
    {
        _email email = new _email();
        public Pochta()
        {
            InitializeComponent();
        }


        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Auth auth = new Auth(email);
            auth.Show();
        }

        private void получитьПисьмоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (email.verified)
            {
                Message message1 = new Message(email);
                message1.Show();
            }
            else { MessageBox.Show("Пройдите авторизацию", "Внимание"); }
        }

        private void написатьПисьмоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (email.verified)
            {
                Send_Message message = new Send_Message(email);
                message.Show();
            }
            else { MessageBox.Show("Пройдите авторизацию", "Внимание"); }
        }


    }




}

