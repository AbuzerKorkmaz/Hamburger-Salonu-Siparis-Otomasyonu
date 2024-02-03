using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerOdevi
{
    public partial class frmSiparis : Form
    {
        public frmSiparis(List<Siparis> list,List<Menu> _menu,List<EkstraMalzemeMenusu> ekstraMalzemes)
        {
            InitializeComponent();
            this.list = list;
            this.menu = _menu;
            this.Malzemeler= ekstraMalzemes;
            
            
            foreach (Menu item in _menu)
            {
                comboBox1.Items.Add(item);
            }
            foreach (EkstraMalzemeMenusu item in ekstraMalzemes)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = item.MalzemeIsmi;
                flowLayoutPanel1.Controls.Add(checkBox);
            }

        }
        
        List<Siparis> list;
        List<Menu> menu;
        List<EkstraMalzemeMenusu> Malzemeler;
       
        double menuFiyati = 0;
        double siparisBoyutCarpani;
        int adet;
        double siparisinToplamTutari = 0;
        double ekMalzemeAddedi = 0;
        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            
            double ekMalzemeFiyati = 0;
            Siparis siparis = new Siparis();
            
            siparis.MenuTipi = comboBox1.SelectedItem.ToString();
            foreach (Menu item in menu)
            {
                if (siparis.MenuTipi == item.MenuIsmi) { menuFiyati = item.Fiyat; }
            }
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                    if (item.Checked)
                    {
                     siparis.EkMalzeme += item.Text + " ";
                        ekMalzemeAddedi++;
                            foreach (EkstraMalzemeMenusu item1 in Malzemeler)
                            {
                                
                                ekMalzemeFiyati = item1.Fiyat*ekMalzemeAddedi;
                            }
                                         
                    }
                
            }
            siparis.MenuBoyutu = rbKucuk.Checked ?  rbKucuk.Text : rbOrta.Checked ? rbOrta.Text : rbBuyuk.Text;
            siparisBoyutCarpani= rbKucuk.Checked ? menuFiyati : rbOrta.Checked ? menuFiyati*0.1 : menuFiyati*0.2;
            adet=siparis.MenuAdeti = (int)numericUpDown1.Value;
            siparis.EkMalzemeGeliri += adet*ekMalzemeFiyati;
            siparis.Tutar = TotalTutarHesapla(menuFiyati, ekMalzemeFiyati, siparisBoyutCarpani, adet);
            siparisinToplamTutari += siparis.Tutar;
            siparis.MalzemeSayisi = adet*(1+(int)ekMalzemeAddedi);
            list.Add(siparis);
           

            lblToplamFiyat.Text = siparisinToplamTutari.ToString();
            listBox1.Items.Add(siparis);

        }
       
        private void btnSiparisOnayla_Click(object sender, EventArgs e)
        {
            


            MessageBox.Show("Siparişi Onaylıyor musunuz? ", "Onay Mesajı", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
        
        private double TotalTutarHesapla(double menuP,double extraMP, double cons, int quantity) {
           
            
            return ((menuP+cons)+extraMP)*quantity;
        }
    }
}
