using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HamburgerOdevi;
namespace HamburgerOdevi
{
    public partial class EkstraMalzemeEkle : Form
    {
       List<EkstraMalzemeMenusu> yeniListe=new List<EkstraMalzemeMenusu> ();
        public EkstraMalzemeEkle(List<EkstraMalzemeMenusu> _list)
        {
            InitializeComponent();
            yeniListe = _list;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           EkstraMalzemeMenusu extraMalzeme=new   EkstraMalzemeMenusu();
            extraMalzeme.MalzemeIsmi= txtEkstraAdi.Text;
            extraMalzeme.Fiyat= Convert.ToDouble(txtExtraFiyat.Text);
            yeniListe.Add(extraMalzeme);
            MessageBox.Show("EkstraMalzemeniz eklendi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            txtEkstraAdi.Text = "";
            txtExtraFiyat.Text = "";
        }
    }
}
