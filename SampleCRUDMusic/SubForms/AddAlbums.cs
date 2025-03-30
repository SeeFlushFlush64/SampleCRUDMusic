using SampleCRUDMusic.Data;
using SampleCRUDMusic.Models.Entities;

namespace SampleCRUDMusic.SubForms
{
    public partial class AddAlbums : Form
    {
        private readonly AppDbContext _context;
        public AddAlbums(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private void AddAlbums_Load(object sender, EventArgs e)
        {

        }


        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            Album newAlbum = new Album 
            {
                AlbumName = txtBoxAlbumName.Text,
                Artist = txtBoxArtist.Text,
                Genre = txtBoxGenre.Text,
                AlbumPicture = txtBoxAlbumPicture.Text
            };
            _context.Albums.Add(newAlbum);
            _context.SaveChanges();
            ClearAlbumFields();
            ShowAddAlbumMessage();
        }

        private void ClearAlbumFields()
        {
            txtBoxAlbumName.Text = "";
            txtBoxArtist.Text = "";
            txtBoxGenre.Text = "";
            txtBoxAlbumPicture.Text = "";
        }

        private void ShowAddAlbumMessage()
        {
            MessageBox.Show("Album Added Successfully", "Add Album", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
