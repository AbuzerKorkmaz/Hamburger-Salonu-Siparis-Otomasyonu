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
        public TumSiparisler(List<Siparis> liste)
        {
            InitializeComponent();
            _frmdenGelen = liste;
            foreach (Siparis item in liste)
            {
                listBox1.Items.Add(item);
            }
           
        }

    }
}
