namespace HamburgerOdevi
{
    partial class TumSiparisler
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
            label1 = new Label();
            listBox1 = new ListBox();
            gbCiro = new GroupBox();
            label2 = new Label();
            gbToplamSiparis = new GroupBox();
            lblToplamSiparis = new Label();
            dbEkstraMalzemeGeliri = new GroupBox();
            lblEkstraGelir = new Label();
            gbSatilanUrunAdedi = new GroupBox();
            lblUrunAdedi = new Label();
            gbCiro.SuspendLayout();
            gbToplamSiparis.SuspendLayout();
            dbEkstraMalzemeGeliri.SuspendLayout();
            gbSatilanUrunAdedi.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(32, 27);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 0;
            label1.Text = "TÜM SİPARİŞLER";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(23, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(235, 364);
            listBox1.TabIndex = 1;
            // 
            // gbCiro
            // 
            gbCiro.Controls.Add(label2);
            gbCiro.Location = new Point(307, 71);
            gbCiro.Name = "gbCiro";
            gbCiro.Size = new Size(131, 85);
            gbCiro.TabIndex = 2;
            gbCiro.TabStop = false;
            gbCiro.Text = "Ciro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(22, 39);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // gbToplamSiparis
            // 
            gbToplamSiparis.Controls.Add(lblToplamSiparis);
            gbToplamSiparis.Location = new Point(307, 162);
            gbToplamSiparis.Name = "gbToplamSiparis";
            gbToplamSiparis.Size = new Size(131, 75);
            gbToplamSiparis.TabIndex = 3;
            gbToplamSiparis.TabStop = false;
            gbToplamSiparis.Text = "Toplam Sipariş";
            // 
            // lblToplamSiparis
            // 
            lblToplamSiparis.AutoSize = true;
            lblToplamSiparis.ForeColor = Color.Red;
            lblToplamSiparis.Location = new Point(19, 37);
            lblToplamSiparis.Name = "lblToplamSiparis";
            lblToplamSiparis.Size = new Size(38, 15);
            lblToplamSiparis.TabIndex = 0;
            lblToplamSiparis.Text = "label3";
            // 
            // dbEkstraMalzemeGeliri
            // 
            dbEkstraMalzemeGeliri.Controls.Add(lblEkstraGelir);
            dbEkstraMalzemeGeliri.Location = new Point(307, 262);
            dbEkstraMalzemeGeliri.Name = "dbEkstraMalzemeGeliri";
            dbEkstraMalzemeGeliri.Size = new Size(131, 86);
            dbEkstraMalzemeGeliri.TabIndex = 4;
            dbEkstraMalzemeGeliri.TabStop = false;
            dbEkstraMalzemeGeliri.Text = "Ekstra Malzeme Geliri";
            // 
            // lblEkstraGelir
            // 
            lblEkstraGelir.AutoSize = true;
            lblEkstraGelir.ForeColor = Color.Red;
            lblEkstraGelir.Location = new Point(11, 40);
            lblEkstraGelir.Name = "lblEkstraGelir";
            lblEkstraGelir.Size = new Size(38, 15);
            lblEkstraGelir.TabIndex = 0;
            lblEkstraGelir.Text = "label4";
            // 
            // gbSatilanUrunAdedi
            // 
            gbSatilanUrunAdedi.Controls.Add(lblUrunAdedi);
            gbSatilanUrunAdedi.Location = new Point(307, 359);
            gbSatilanUrunAdedi.Name = "gbSatilanUrunAdedi";
            gbSatilanUrunAdedi.Size = new Size(131, 79);
            gbSatilanUrunAdedi.TabIndex = 5;
            gbSatilanUrunAdedi.TabStop = false;
            gbSatilanUrunAdedi.Text = "Satılan Ürün Adedi";
            // 
            // lblUrunAdedi
            // 
            lblUrunAdedi.AutoSize = true;
            lblUrunAdedi.ForeColor = Color.Red;
            lblUrunAdedi.Location = new Point(22, 34);
            lblUrunAdedi.Name = "lblUrunAdedi";
            lblUrunAdedi.Size = new Size(38, 15);
            lblUrunAdedi.TabIndex = 0;
            lblUrunAdedi.Text = "label5";
            // 
            // TumSiparisler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 450);
            Controls.Add(gbSatilanUrunAdedi);
            Controls.Add(dbEkstraMalzemeGeliri);
            Controls.Add(gbToplamSiparis);
            Controls.Add(gbCiro);
            Controls.Add(listBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TumSiparisler";
            Text = "TumSiparisler";
            gbCiro.ResumeLayout(false);
            gbCiro.PerformLayout();
            gbToplamSiparis.ResumeLayout(false);
            gbToplamSiparis.PerformLayout();
            dbEkstraMalzemeGeliri.ResumeLayout(false);
            dbEkstraMalzemeGeliri.PerformLayout();
            gbSatilanUrunAdedi.ResumeLayout(false);
            gbSatilanUrunAdedi.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private GroupBox gbCiro;
        private GroupBox gbToplamSiparis;
        private GroupBox dbEkstraMalzemeGeliri;
        private GroupBox gbSatilanUrunAdedi;
        private Label label2;
        private Label lblToplamSiparis;
        private Label lblEkstraGelir;
        private Label lblUrunAdedi;
    }
}