namespace HamburgerOdevi
{
    partial class frmSiparis
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
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            rbKucuk = new RadioButton();
            rbOrta = new RadioButton();
            rbBuyuk = new RadioButton();
            label1 = new Label();
            btnSiparisEkle = new Button();
            listBox1 = new ListBox();
            numericUpDown1 = new NumericUpDown();
            label2 = new Label();
            lblToplamFiyat = new Label();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            cbKetcap = new CheckBox();
            cbMayonez = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.triple_whopper_menu;
            pictureBox1.Location = new Point(31, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Big Mac Menu", "Regular Chichen Menu" });
            comboBox1.Location = new Point(29, 162);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // rbKucuk
            // 
            rbKucuk.AutoSize = true;
            rbKucuk.Location = new Point(29, 303);
            rbKucuk.Name = "rbKucuk";
            rbKucuk.Size = new Size(58, 19);
            rbKucuk.TabIndex = 2;
            rbKucuk.TabStop = true;
            rbKucuk.Text = "Küçük";
            rbKucuk.UseVisualStyleBackColor = true;
            // 
            // rbOrta
            // 
            rbOrta.AutoSize = true;
            rbOrta.Location = new Point(98, 303);
            rbOrta.Name = "rbOrta";
            rbOrta.Size = new Size(48, 19);
            rbOrta.TabIndex = 3;
            rbOrta.TabStop = true;
            rbOrta.Text = "Orta";
            rbOrta.UseVisualStyleBackColor = true;
            // 
            // rbBuyuk
            // 
            rbBuyuk.AutoSize = true;
            rbBuyuk.Location = new Point(152, 303);
            rbBuyuk.Name = "rbBuyuk";
            rbBuyuk.Size = new Size(58, 19);
            rbBuyuk.TabIndex = 4;
            rbBuyuk.TabStop = true;
            rbBuyuk.Text = "Büyük";
            rbBuyuk.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 337);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Adet";
            // 
            // btnSiparisEkle
            // 
            btnSiparisEkle.Location = new Point(80, 366);
            btnSiparisEkle.Name = "btnSiparisEkle";
            btnSiparisEkle.Size = new Size(149, 45);
            btnSiparisEkle.TabIndex = 6;
            btnSiparisEkle.Text = "Ekle";
            btnSiparisEkle.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(283, 33);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(456, 289);
            listBox1.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(98, 330);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(131, 23);
            numericUpDown1.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(457, 366);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 9;
            label2.Text = "Toplam";
            // 
            // lblToplamFiyat
            // 
            lblToplamFiyat.AutoSize = true;
            lblToplamFiyat.ForeColor = Color.Red;
            lblToplamFiyat.Location = new Point(529, 366);
            lblToplamFiyat.Name = "lblToplamFiyat";
            lblToplamFiyat.Size = new Size(27, 15);
            lblToplamFiyat.TabIndex = 10;
            lblToplamFiyat.Text = "****";
            // 
            // button1
            // 
            button1.Location = new Point(607, 337);
            button1.Name = "button1";
            button1.Size = new Size(132, 74);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(cbKetcap);
            flowLayoutPanel1.Controls.Add(cbMayonez);
            flowLayoutPanel1.Location = new Point(31, 191);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // cbKetcap
            // 
            cbKetcap.AutoSize = true;
            cbKetcap.Location = new Point(10, 7);
            cbKetcap.Name = "cbKetcap";
            cbKetcap.Size = new Size(83, 19);
            cbKetcap.TabIndex = 0;
            cbKetcap.Text = "Ketcap";
            cbKetcap.UseVisualStyleBackColor = true;
            // 
            // cbMayonez
            // 
            cbMayonez.AutoSize = true;
            cbMayonez.Location = new Point(6, 31);
            cbMayonez.Name = "cbMayonez";
            cbMayonez.Size = new Size(83, 19);
            cbMayonez.TabIndex = 1;
            cbMayonez.Text = "Mayonez";
            cbMayonez.UseVisualStyleBackColor = true;
            // 
            // frmSiparis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(button1);
            Controls.Add(lblToplamFiyat);
            Controls.Add(label2);
            Controls.Add(numericUpDown1);
            Controls.Add(listBox1);
            Controls.Add(btnSiparisEkle);
            Controls.Add(label1);
            Controls.Add(rbBuyuk);
            Controls.Add(rbOrta);
            Controls.Add(rbKucuk);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSiparis";
            Text = "form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private RadioButton rbKucuk;
        private RadioButton rbOrta;
        private RadioButton rbBuyuk;
        private Label label1;
        private Button btnSiparisEkle;
        private ListBox listBox1;
        private NumericUpDown numericUpDown1;
        private Label label2;
        private Label lblToplamFiyat;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private CheckBox cbKetcap;
        private CheckBox cbMayonez;
    }
}