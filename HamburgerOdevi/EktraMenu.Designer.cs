﻿namespace HamburgerOdevi
{
    partial class EktraMenu
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
            groupBox1 = new GroupBox();
            lblAd = new Label();
            lblFiyat = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(lblFiyat);
            groupBox1.Controls.Add(lblAd);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(57, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(249, 193);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Menü Ekle";
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(23, 29);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(29, 21);
            lblAd.TabIndex = 0;
            lblAd.Text = "Ad";
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Location = new Point(23, 69);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(43, 21);
            lblFiyat.TabIndex = 1;
            lblFiyat.Text = "Fiyat";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 29);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 29);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(96, 114);
            button1.Name = "button1";
            button1.Size = new Size(121, 42);
            button1.TabIndex = 4;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // EktraMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 330);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EktraMenu";
            Text = "EktraMenu";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblFiyat;
        private Label lblAd;
    }
}