using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgerOdevi
{
    public partial class TumSiparisler : Form
    {


        public TumSiparisler(List<Siparis> liste)
        {
            InitializeComponent();

            double ciro = 0;
            double ekMalzemeTutari = 0;
            int urunSayisi = 0;
            foreach (Siparis item in liste)
            {

                listBox1.Items.Add(item);
                ekMalzemeTutari = item.EkMalzemeGeliri;
                ciro += item.Tutar;
                urunSayisi += item.MalzemeSayisi;
            }
            lblCiro.Text = ciro.ToString();
            lblEkstraGelir.Text = ekMalzemeTutari.ToString();
            lblToplamSiparis.Text = liste.Count.ToString();
            lblUrunAdedi.Text=urunSayisi.ToString();
        }
    }
}
