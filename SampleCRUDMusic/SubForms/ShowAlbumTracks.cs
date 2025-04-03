using Microsoft.EntityFrameworkCore;
using SampleCRUDMusic.Data;
using SampleCRUDMusic.Models.Entities;
using System.Linq;

namespace SampleCRUDMusic.SubForms
{
    public partial class ShowAlbumTracks : Form
    {
        private AppDbContext _context;
        private Album _album;
        private bool _isShuffleActive = false;
        private AlbumsMainForm _mainForm;
        public ShowAlbumTracks(AppDbContext context, Album album, AlbumsMainForm mainForm)
        {
            _context = context;
            _album = _context.Albums.Include(a => a.Tracks).FirstOrDefault(a => a.AlbumId == album.AlbumId);
            _mainForm = mainForm;
            InitializeComponent();
            LoadAlbumTracks();
        }
        private void LoadAlbumTracks()
        {
            picBoxCurrentAlbumPicture.ImageLocation = _album.AlbumPicture;
            picBoxCurrentAlbumPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            lblCurrentAlbumName.Text = _album.AlbumName;
            lblAlbumInformation.Text = $"{_album.Artist} • {_album.Genre} • {_album.Tracks.Count} Tracks";
            // Load tracks into DataGridView
            var tracks = _context.Tracks
                .Where(t => t.AlbumId == _album.AlbumId)
                .Select(t => new { t.TrackId, t.TrackName, t.Duration })
                .ToList();

            dataGridViewTracks.DataSource = tracks;
        }

        private void picBoxPlayTracks_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxPlayTracks_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxShuffleTracks_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxShuffleTracks_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxShuffleTracks_MouseClick(object sender, MouseEventArgs e)
        {

            if (_isShuffleActive)
            {
                _isShuffleActive = false;
                picBoxShuffleTracks.Image = Properties.Resources.shuffle_tracks;
                return;
            }
            picBoxShuffleTracks.Image = Properties.Resources.shuffle_tracks_active;
            _isShuffleActive = true;
        }

        private void picBoxAddTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxAddTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxAddTrack_MouseClick(object sender, MouseEventArgs e)
        {
            
             _mainForm.ShowAddAlbums(new AddTracks(_context, _album));
           
        }
    }
}
