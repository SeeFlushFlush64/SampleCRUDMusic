using SampleCRUDMusic.Data;
using SampleCRUDMusic.SubForms;
namespace SampleCRUDMusic
{
    public partial class AlbumsMainForm : Form
    {
        private readonly AppDbContext _context;
        public AlbumsMainForm(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            ShowDashboard(new Dashboard(_context));
        }

        private void panelSideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        public void ShowDashboard(object Form)
        {
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelBody.Controls.Add(f);
            this.panelBody.Tag = f;
            f.Show();
        }

        public void ShowAddAlbums(object Form)
        {
            if (this.panelBody.Controls.Count > 0)
            {
                this.panelBody.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelBody.Controls.Add(f);
            this.panelBody.Tag = f;
            f.Show();
        }

        private void picBoxAddAlbum_Click(object sender, EventArgs e)
        {
            ShowAddAlbums(new AddAlbums(_context));
        }
    }
}
