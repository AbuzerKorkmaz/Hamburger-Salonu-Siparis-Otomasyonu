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
    public partial class EktraMenu : Form
    {
        List<Menu> _yeniMenu = new List<Menu>();
        public EktraMenu(List<Menu> menus)
        {
            InitializeComponent();
            _yeniMenu = menus;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.MenuIsmi= txtMenuAdi.Text;
            menu.Fiyat = Convert.ToDouble(txtMenuFiyat.Text);
            _yeniMenu.Add(menu);
            MessageBox.Show($"Yeni menu eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
           txtMenuAdi.Text = "";
            txtMenuFiyat.Text = "";
            
        }
    }
}
