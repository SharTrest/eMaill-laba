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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Auth_label2 = new System.Windows.Forms.Label();
            this.Auth_label1 = new System.Windows.Forms.Label();
            this.Auth_button2 = new System.Windows.Forms.Button();
            this.Auth_button1 = new System.Windows.Forms.Button();
            this.Auth_textBox2 = new System.Windows.Forms.TextBox();
            this.Auth_textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Send_mail_label1 = new System.Windows.Forms.Label();
            this.Send_mail_label2 = new System.Windows.Forms.Label();
            this.Send_mail_label3 = new System.Windows.Forms.Label();
            this.Send_mail_button1 = new System.Windows.Forms.Button();
            this.Send_mail_textBox1 = new System.Windows.Forms.TextBox();
            this.Send_mail_textBox2 = new System.Windows.Forms.TextBox();
            this.Send_mail_textBox3 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Messages_listView1 = new System.Windows.Forms.ListView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 600);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Auth_label2);
            this.tabPage1.Controls.Add(this.Auth_label1);
            this.tabPage1.Controls.Add(this.Auth_button2);
            this.tabPage1.Controls.Add(this.Auth_button1);
            this.tabPage1.Controls.Add(this.Auth_textBox2);
            this.tabPage1.Controls.Add(this.Auth_textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(918, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Авторизация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Auth_label2
            // 
            this.Auth_label2.AutoSize = true;
            this.Auth_label2.Location = new System.Drawing.Point(293, 112);
            this.Auth_label2.Name = "Auth_label2";
            this.Auth_label2.Size = new System.Drawing.Size(52, 20);
            this.Auth_label2.TabIndex = 5;
            this.Auth_label2.Text = "Логин";
            // 
            // Auth_label1
            // 
            this.Auth_label1.AutoSize = true;
            this.Auth_label1.Location = new System.Drawing.Point(293, 204);
            this.Auth_label1.Name = "Auth_label1";
            this.Auth_label1.Size = new System.Drawing.Size(62, 20);
            this.Auth_label1.TabIndex = 4;
            this.Auth_label1.Text = "Пароль";
            // 
            // Auth_button2
            // 
            this.Auth_button2.Location = new System.Drawing.Point(515, 291);
            this.Auth_button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Auth_button2.Name = "Auth_button2";
            this.Auth_button2.Size = new System.Drawing.Size(86, 31);
            this.Auth_button2.TabIndex = 3;
            this.Auth_button2.Text = "Отмена";
            this.Auth_button2.UseVisualStyleBackColor = true;
            this.Auth_button2.Click += new System.EventHandler(this.Auth_button2_Click);
            // 
            // Auth_button1
            // 
            this.Auth_button1.Location = new System.Drawing.Point(413, 291);
            this.Auth_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Auth_button1.Name = "Auth_button1";
            this.Auth_button1.Size = new System.Drawing.Size(96, 31);
            this.Auth_button1.TabIndex = 2;
            this.Auth_button1.Text = "Сохранить";
            this.Auth_button1.UseVisualStyleBackColor = true;
            this.Auth_button1.Click += new System.EventHandler(this.Auth_button1_Click);
            // 
            // Auth_textBox2
            // 
            this.Auth_textBox2.Location = new System.Drawing.Point(293, 240);
            this.Auth_textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Auth_textBox2.Name = "Auth_textBox2";
            this.Auth_textBox2.PasswordChar = '*';
            this.Auth_textBox2.Size = new System.Drawing.Size(308, 27);
            this.Auth_textBox2.TabIndex = 1;
            // 
            // Auth_textBox1
            // 
            this.Auth_textBox1.Location = new System.Drawing.Point(293, 155);
            this.Auth_textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Auth_textBox1.MaximumSize = new System.Drawing.Size(308, 23);
            this.Auth_textBox1.MinimumSize = new System.Drawing.Size(308, 23);
            this.Auth_textBox1.Name = "Auth_textBox1";
            this.Auth_textBox1.Size = new System.Drawing.Size(308, 23);
            this.Auth_textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Send_mail_label1);
            this.tabPage2.Controls.Add(this.Send_mail_label2);
            this.tabPage2.Controls.Add(this.Send_mail_label3);
            this.tabPage2.Controls.Add(this.Send_mail_button1);
            this.tabPage2.Controls.Add(this.Send_mail_textBox1);
            this.tabPage2.Controls.Add(this.Send_mail_textBox2);
            this.tabPage2.Controls.Add(this.Send_mail_textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(918, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Написать письмо";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Send_mail_label1
            // 
            this.Send_mail_label1.AutoSize = true;
            this.Send_mail_label1.Location = new System.Drawing.Point(11, 16);
            this.Send_mail_label1.Name = "Send_mail_label1";
            this.Send_mail_label1.Size = new System.Drawing.Size(52, 20);
            this.Send_mail_label1.TabIndex = 0;
            this.Send_mail_label1.Text = "E-mail";
            // 
            // Send_mail_label2
            // 
            this.Send_mail_label2.AutoSize = true;
            this.Send_mail_label2.Location = new System.Drawing.Point(11, 93);
            this.Send_mail_label2.Name = "Send_mail_label2";
            this.Send_mail_label2.Size = new System.Drawing.Size(44, 20);
            this.Send_mail_label2.TabIndex = 1;
            this.Send_mail_label2.Text = "Тема";
            // 
            // Send_mail_label3
            // 
            this.Send_mail_label3.AutoSize = true;
            this.Send_mail_label3.Location = new System.Drawing.Point(11, 169);
            this.Send_mail_label3.Name = "Send_mail_label3";
            this.Send_mail_label3.Size = new System.Drawing.Size(129, 20);
            this.Send_mail_label3.TabIndex = 2;
            this.Send_mail_label3.Text = "Текст сообщения";
            // 
            // Send_mail_button1
            // 
            this.Send_mail_button1.Location = new System.Drawing.Point(11, 525);
            this.Send_mail_button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Send_mail_button1.Name = "Send_mail_button1";
            this.Send_mail_button1.Size = new System.Drawing.Size(98, 31);
            this.Send_mail_button1.TabIndex = 3;
            this.Send_mail_button1.Text = "Отправить";
            this.Send_mail_button1.UseVisualStyleBackColor = true;
            this.Send_mail_button1.Click += new System.EventHandler(this.Send_mail_button1_Click);
            // 
            // Send_mail_textBox1
            // 
            this.Send_mail_textBox1.Location = new System.Drawing.Point(11, 200);
            this.Send_mail_textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Send_mail_textBox1.Multiline = true;
            this.Send_mail_textBox1.Name = "Send_mail_textBox1";
            this.Send_mail_textBox1.Size = new System.Drawing.Size(891, 292);
            this.Send_mail_textBox1.TabIndex = 0;
            // 
            // Send_mail_textBox2
            // 
            this.Send_mail_textBox2.Location = new System.Drawing.Point(11, 128);
            this.Send_mail_textBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Send_mail_textBox2.Name = "Send_mail_textBox2";
            this.Send_mail_textBox2.Size = new System.Drawing.Size(891, 27);
            this.Send_mail_textBox2.TabIndex = 1;
            // 
            // Send_mail_textBox3
            // 
            this.Send_mail_textBox3.Location = new System.Drawing.Point(11, 48);
            this.Send_mail_textBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Send_mail_textBox3.Name = "Send_mail_textBox3";
            this.Send_mail_textBox3.Size = new System.Drawing.Size(891, 27);
            this.Send_mail_textBox3.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Messages_listView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(918, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Полученные письма";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Messages_listView1
            // 
            this.Messages_listView1.Location = new System.Drawing.Point(0, 1);
            this.Messages_listView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Messages_listView1.Name = "Messages_listView1";
            this.Messages_listView1.Size = new System.Drawing.Size(783, 597);
            this.Messages_listView1.TabIndex = 0;
            this.Messages_listView1.UseCompatibleStateImageBehavior = false;
            this.Messages_listView1.View = System.Windows.Forms.View.Details;
            this.Messages_listView1.View = View.Details;
            this.Messages_listView1.Columns.Add("Email", 200, HorizontalAlignment.Center);
            this.Messages_listView1.Columns.Add("Тема", 200, HorizontalAlignment.Center);
            this.Messages_listView1.Columns.Add("Текст", 200, HorizontalAlignment.Center);
            // 
            // Mylo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Mylo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почта России";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

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