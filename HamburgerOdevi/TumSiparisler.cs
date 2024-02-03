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
        List<Siparis> _frmdenGelen = new List<Siparis>();
      
        public TumSiparisler(List<Siparis> liste,List<Siparis> onay)
        {
            InitializeComponent();
            _frmdenGelen = liste;
            double ciro = 0;
            foreach (Siparis item in liste)
            {
                
                listBox1.Items.Add(item);
                ciro += item.Tutar;
            }
           lblCiro.Text=ciro.ToString();
            lblToplamSiparis.Text=liste.Count.ToString();
        }
        public List<Siparis> frmdenGelen { get; set; }

    }
}
