namespace HamburgerOdevi
{
    partial class EkstraMalzemeEkle
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
            label1 = new Label();
            label2 = new Label();
            txtEkstraAdi = new TextBox();
            txtExtraFiyat = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtExtraFiyat);
            groupBox1.Controls.Add(txtEkstraAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(52, 37);
            groupBox1.Margin = new Padding(4, 4, 4, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 4, 4, 4);
            groupBox1.Size = new Size(307, 201);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ekstra Malzeme Ekleme Ekranı";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 56);
            label1.Name = "label1";
            label1.Size = new Size(33, 21);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 98);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 1;
            label2.Text = "Fiyat";
            // 
            // txtEkstraAdi
            // 
            txtEkstraAdi.Location = new Point(107, 53);
            txtEkstraAdi.Name = "txtEkstraAdi";
            txtEkstraAdi.Size = new Size(148, 29);
            txtEkstraAdi.TabIndex = 2;
            // 
            // txtExtraFiyat
            // 
            txtExtraFiyat.Location = new Point(107, 95);
            txtExtraFiyat.Name = "txtExtraFiyat";
            txtExtraFiyat.Size = new Size(148, 29);
            txtExtraFiyat.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(147, 130);
            button1.Name = "button1";
            button1.Size = new Size(108, 48);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // EkstraMalzemeEkle
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 297);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "EkstraMalzemeEkle";
            Text = "EkstraMalzemeEkle";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private TextBox txtExtraFiyat;
        private TextBox txtEkstraAdi;
        private Label label2;
        private Label label1;
    }
}