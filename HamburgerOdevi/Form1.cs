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
            frmSiparis frmSiparis = new frmSiparis();
            frmSiparis.MdiParent = this;
            frmSiparis.Dock = DockStyle.Fill;
            frmSiparis.Show();
        }

        private void sipari�leriG�r�nt�leToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TumSiparisler tumSiparisler = new TumSiparisler();
            tumSiparisler.MdiParent = this;
            tumSiparisler.Dock = DockStyle.Fill;
            tumSiparisler.Show();
        }

        private void sipari�Olu�turToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSiparis frmSiparis = new frmSiparis();
            frmSiparis.MdiParent = this;
            frmSiparis.Dock = DockStyle.Fill;
            frmSiparis.Show();

        }

        private void men�EkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EktraMenu ektraMenu = new EktraMenu();
            ektraMenu.MdiParent = this;
            ektraMenu.Dock = DockStyle.Fill;
            ektraMenu.Show();
        }

        private void ekstraMalzemeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EkstraMalzemeEkle ekstraMalzeme= new EkstraMalzemeEkle();
            ekstraMalzeme.MdiParent = this;
            ekstraMalzeme.Dock = DockStyle.Fill;
            ekstraMalzeme.Show();
        }
    }
}
