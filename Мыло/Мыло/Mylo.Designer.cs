namespace Мыло
{
    partial class Mylo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Auth_label2 = new Label();
            Auth_label1 = new Label();
            Auth_button2 = new Button();
            Auth_button1 = new Button();
            Auth_textBox2 = new TextBox();
            Auth_textBox1 = new TextBox();
            tabPage2 = new TabPage();
            Send_mail_label1 = new Label();
            Send_mail_label2 = new Label();
            Send_mail_label3 = new Label();
            Send_mail_button1 = new Button();
            Send_mail_textBox1 = new TextBox();
            Send_mail_textBox2 = new TextBox();
            Send_mail_textBox3 = new TextBox();
            tabPage3 = new TabPage();
            Messages_listView1 = new ListView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 448);
            tabControl1.TabIndex = 0;
            tabControl1.Click += tabControl1_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Auth_label2);
            tabPage1.Controls.Add(Auth_label1);
            tabPage1.Controls.Add(Auth_button2);
            tabPage1.Controls.Add(Auth_button1);
            tabPage1.Controls.Add(Auth_textBox2);
            tabPage1.Controls.Add(Auth_textBox1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(791, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Аутентификация";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Auth_label2
            // 
            Auth_label2.AutoSize = true;
            Auth_label2.Location = new Point(256, 84);
            Auth_label2.Name = "Auth_label2";
            Auth_label2.Size = new Size(41, 15);
            Auth_label2.TabIndex = 5;
            Auth_label2.Text = "Логин";
            // 
            // Auth_label1
            // 
            Auth_label1.AutoSize = true;
            Auth_label1.Location = new Point(256, 153);
            Auth_label1.Name = "Auth_label1";
            Auth_label1.Size = new Size(49, 15);
            Auth_label1.TabIndex = 4;
            Auth_label1.Text = "Пароль";
            // 
            // Auth_button2
            // 
            Auth_button2.Location = new Point(451, 218);
            Auth_button2.Name = "Auth_button2";
            Auth_button2.Size = new Size(75, 23);
            Auth_button2.TabIndex = 3;
            Auth_button2.Text = "Отмена";
            Auth_button2.UseVisualStyleBackColor = true;
            Auth_button2.Click += Auth_button2_Click;
            // 
            // Auth_button1
            // 
            Auth_button1.Location = new Point(370, 218);
            Auth_button1.Name = "Auth_button1";
            Auth_button1.Size = new Size(75, 23);
            Auth_button1.TabIndex = 2;
            Auth_button1.Text = "Сохранить";
            Auth_button1.UseVisualStyleBackColor = true;
            Auth_button1.Click += Auth_button1_Click;
            // 
            // Auth_textBox2
            // 
            Auth_textBox2.Location = new Point(256, 180);
            Auth_textBox2.Name = "Auth_textBox2";
            Auth_textBox2.PasswordChar = '*';
            Auth_textBox2.Size = new Size(270, 23);
            Auth_textBox2.TabIndex = 1;
            // 
            // Auth_textBox1
            // 
            Auth_textBox1.Location = new Point(256, 116);
            Auth_textBox1.MaximumSize = new Size(270, 23);
            Auth_textBox1.MinimumSize = new Size(270, 23);
            Auth_textBox1.Name = "Auth_textBox1";
            Auth_textBox1.Size = new Size(270, 23);
            Auth_textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(Send_mail_label1);
            tabPage2.Controls.Add(Send_mail_label2);
            tabPage2.Controls.Add(Send_mail_label3);
            tabPage2.Controls.Add(Send_mail_button1);
            tabPage2.Controls.Add(Send_mail_textBox1);
            tabPage2.Controls.Add(Send_mail_textBox2);
            tabPage2.Controls.Add(Send_mail_textBox3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(791, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Написать письмо";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Send_mail_label1
            // 
            Send_mail_label1.AutoSize = true;
            Send_mail_label1.Location = new Point(10, 12);
            Send_mail_label1.Name = "Send_mail_label1";
            Send_mail_label1.Size = new Size(41, 15);
            Send_mail_label1.TabIndex = 0;
            Send_mail_label1.Text = "E-mail";
            // 
            // Send_mail_label2
            // 
            Send_mail_label2.AutoSize = true;
            Send_mail_label2.Location = new Point(10, 70);
            Send_mail_label2.Name = "Send_mail_label2";
            Send_mail_label2.Size = new Size(34, 15);
            Send_mail_label2.TabIndex = 1;
            Send_mail_label2.Text = "Тема";
            // 
            // Send_mail_label3
            // 
            Send_mail_label3.AutoSize = true;
            Send_mail_label3.Location = new Point(10, 127);
            Send_mail_label3.Name = "Send_mail_label3";
            Send_mail_label3.Size = new Size(103, 15);
            Send_mail_label3.TabIndex = 2;
            Send_mail_label3.Text = "Текст сообщения";
            // 
            // Send_mail_button1
            // 
            Send_mail_button1.Location = new Point(10, 394);
            Send_mail_button1.Name = "Send_mail_button1";
            Send_mail_button1.Size = new Size(75, 23);
            Send_mail_button1.TabIndex = 3;
            Send_mail_button1.Text = "Отправить";
            Send_mail_button1.UseVisualStyleBackColor = true;
            Send_mail_button1.Click += Send_mail_button1_Click;
            // 
            // Send_mail_textBox1
            // 
            Send_mail_textBox1.Location = new Point(10, 150);
            Send_mail_textBox1.Multiline = true;
            Send_mail_textBox1.Name = "Send_mail_textBox1";
            Send_mail_textBox1.Size = new Size(780, 220);
            Send_mail_textBox1.TabIndex = 0;
            // 
            // Send_mail_textBox2
            // 
            Send_mail_textBox2.Location = new Point(10, 96);
            Send_mail_textBox2.Name = "Send_mail_textBox2";
            Send_mail_textBox2.Size = new Size(780, 23);
            Send_mail_textBox2.TabIndex = 1;
            // 
            // Send_mail_textBox3
            // 
            Send_mail_textBox3.Location = new Point(10, 36);
            Send_mail_textBox3.Name = "Send_mail_textBox3";
            Send_mail_textBox3.Size = new Size(780, 23);
            Send_mail_textBox3.TabIndex = 2;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(Messages_listView1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(791, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Полученные письма";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Messages_listView1
            // 
            Messages_listView1.Location = new Point(0, 1);
            Messages_listView1.Name = "Messages_listView1";
            Messages_listView1.Size = new Size(686, 449);
            Messages_listView1.TabIndex = 0;
            Messages_listView1.UseCompatibleStateImageBehavior = false;
            Messages_listView1.View = View.Details;
            Messages_listView1.Columns.Add("Email", 200, HorizontalAlignment.Center);
            
            // 
            // Mylo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Mylo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;

        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;


        private TextBox Auth_textBox1;
        private TextBox Auth_textBox2;
        private Button Auth_button1;
        private Button Auth_button2;
        private Label Auth_label2;
        private Label Auth_label1;

        private TextBox Send_mail_textBox1;
        private TextBox Send_mail_textBox2;
        private TextBox Send_mail_textBox3;
        private Button Send_mail_button1;
        private Label Send_mail_label1;
        private Label Send_mail_label2;
        private Label Send_mail_label3;

        private ListView Messages_listView1;
    }
}