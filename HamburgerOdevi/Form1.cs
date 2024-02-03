namespace HamburgerOdevi
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
       List<Siparis> siparisler = new List<Siparis>();
        List<Menu> AnaMenu = new List<Menu>();
        List<EkstraMalzemeMenusu> ekstraMalzeme=new List<EkstraMalzemeMenusu>();
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            FormlariTemizle();
            frmSiparis frmSiparis = new frmSiparis(siparisler,AnaMenu,ekstraMalzeme);
            frmSiparis.MdiParent = this;
            frmSiparis.Dock = DockStyle.Fill;
            frmSiparis.Show();
        }
        
        private void sipariþleriGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariTemizle();
            TumSiparisler tumSiparisler = new TumSiparisler(siparisler);
            tumSiparisler.MdiParent = this;
            tumSiparisler.Dock = DockStyle.Fill;
            tumSiparisler.Show();
            
            
        }
        
        private void sipariþOluþturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariTemizle();
            frmSiparis frmSiparis = new frmSiparis(siparisler,AnaMenu,ekstraMalzeme);
            frmSiparis.MdiParent = this;
            frmSiparis.Dock = DockStyle.Fill;
            frmSiparis.Show();

        }
        
        private void menüEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariTemizle();
            EktraMenu ektraMenu = new EktraMenu(AnaMenu);
            ektraMenu.MdiParent = this;
            ektraMenu.Dock = DockStyle.Fill;
            ektraMenu.Show();
        }
      
        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariTemizle();
            EkstraMalzemeEkle Malzeme = new EkstraMalzemeEkle(ekstraMalzeme); 
            Malzeme.MdiParent = this;
            Malzeme.Dock = DockStyle.Fill;
            Malzeme.Show();
        }
        private void FormlariTemizle()
        {
            Form[] formlar = this.MdiChildren;
            foreach (Form item in formlar)
            {
                item.Close();
            }
        }
    }
}
