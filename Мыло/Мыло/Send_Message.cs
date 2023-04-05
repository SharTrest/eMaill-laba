using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Мыло
{
    public partial class Send_Message : Form
    {
        _email email;
        public Send_Message(_email email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                email.Email = textBox3.Text;
                email.text_message = textBox1.Text;
                email.text_subjest = textBox2.Text;
                email.Send();
        }
    }
}
