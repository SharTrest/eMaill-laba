﻿namespace Мыло
{
    partial class Pochta
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
            menuStrip1 = new MenuStrip();
            emailToolStripMenuItem = new ToolStripMenuItem();
            написатьПисьмоToolStripMenuItem = new ToolStripMenuItem();
            получитьПисьмоToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
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
            emailToolStripMenuItem.Size = new Size(90, 20);
            emailToolStripMenuItem.Text = "Авторизация";
            emailToolStripMenuItem.Click += emailToolStripMenuItem_Click;
            // 
            // написатьПисьмоToolStripMenuItem
            // 
            написатьПисьмоToolStripMenuItem.Name = "написатьПисьмоToolStripMenuItem";
            написатьПисьмоToolStripMenuItem.Size = new Size(116, 20);
            написатьПисьмоToolStripMenuItem.Text = "Написать письмо";
            написатьПисьмоToolStripMenuItem.Click += написатьПисьмоToolStripMenuItem_Click;
            // 
            // получитьПисьмоToolStripMenuItem
            // 
            получитьПисьмоToolStripMenuItem.Name = "получитьПисьмоToolStripMenuItem";
            получитьПисьмоToolStripMenuItem.Size = new Size(118, 20);
            получитьПисьмоToolStripMenuItem.Text = "Получить письмо";
            получитьПисьмоToolStripMenuItem.Click += получитьПисьмоToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 181);
            label1.Name = "label1";
            label1.Size = new Size(738, 45);
            label1.TabIndex = 5;
            label1.Text = "Здесь должны быть данные юзера, но их украли";
            // 
            // Pochta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Pochta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Почта России";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem emailToolStripMenuItem;
        private ToolStripMenuItem получитьПисьмоToolStripMenuItem;
        private ToolStripMenuItem написатьПисьмоToolStripMenuItem;
        private Label label1;
    }
}