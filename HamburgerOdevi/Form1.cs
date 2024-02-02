namespace HamburgerOdevi
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }
       
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            FormlariTemizle();
            frmSiparis frmSiparis = new frmSiparis();
            frmSiparis.MdiParent = this;
            frmSiparis.Dock = DockStyle.Fill;
            frmSiparis.Show();
        }
        
        private void sipari�leriG�r�nt�leToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariTemizle();
            TumSiparisler tumSiparisler = new TumSiparisler();
            tumSiparisler.MdiParent = this;
            tumSiparisler.Dock = DockStyle.Fill;
            tumSiparisler.Show();
        }
        
        private void sipari�Olu�turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariTemizle();
            frmSiparis frmSiparis = new frmSiparis();
            frmSiparis.MdiParent = this;
            frmSiparis.Dock = DockStyle.Fill;
            frmSiparis.Show();

        }
        
        private void men�EkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariTemizle();
            EktraMenu ektraMenu = new EktraMenu();
            ektraMenu.MdiParent = this;
            ektraMenu.Dock = DockStyle.Fill;
            ektraMenu.Show();
        }
      
        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormlariTemizle();
            EkstraMalzemeEkle ekstraMalzeme = new EkstraMalzemeEkle();
            ekstraMalzeme.MdiParent = this;
            ekstraMalzeme.Dock = DockStyle.Fill;
            ekstraMalzeme.Show();
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
