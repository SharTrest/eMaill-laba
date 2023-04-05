using System.Windows.Forms;

namespace Мыло
{
    partial class Send_Message
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            emailToolStripMenuItem = new ToolStripMenuItem();
            написатьПисьмоToolStripMenuItem = new ToolStripMenuItem();
            получитьПисьмоToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 150);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(780, 220);
            textBox1.TabIndex = 0;
            textBox1.Text = "Текст сообщения";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(780, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "Тема";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(10, 36);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(780, 23);
            textBox3.TabIndex = 2;
            textBox3.Text = "Введите почту";
            // 
            // button1
            // 
            button1.Location = new Point(12, 406);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Отправить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { emailToolStripMenuItem, написатьПисьмоToolStripMenuItem, получитьПисьмоToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // emailToolStripMenuItem
            // 
            emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            emailToolStripMenuItem.Size = new Size(53, 20);
            emailToolStripMenuItem.Text = "Авторизация";
            // 
            // написатьПисьмоToolStripMenuItem
            // 
            написатьПисьмоToolStripMenuItem.Name = "написатьПисьмоToolStripMenuItem";
            написатьПисьмоToolStripMenuItem.Size = new Size(116, 20);
            написатьПисьмоToolStripMenuItem.Text = "Написать письмо";
            // 
            // получитьПисьмоToolStripMenuItem
            // 
            получитьПисьмоToolStripMenuItem.Name = "получитьПисьмоToolStripMenuItem";
            получитьПисьмоToolStripMenuItem.Size = new Size(118, 20);
            получитьПисьмоToolStripMenuItem.Text = "Получить письмо";
            // 
            // Send_Message
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Name = "Send_Message";
            Text = "Send_Message";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem emailToolStripMenuItem;
        private ToolStripMenuItem получитьПисьмоToolStripMenuItem;
        private ToolStripMenuItem написатьПисьмоToolStripMenuItem;
    }
}