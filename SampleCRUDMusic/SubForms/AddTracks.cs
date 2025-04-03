using Microsoft.EntityFrameworkCore;
using NAudio.Wave;
using SampleCRUDMusic.Data;
using SampleCRUDMusic.Models.Entities;

namespace SampleCRUDMusic.SubForms
{
    public partial class AddTracks : Form
    {
        private AppDbContext _context;
        private Album _album;
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        public AddTracks(AppDbContext context, Album album)
        {
            _context = context;
            _album = _context.Albums.Include(a => a.Tracks).FirstOrDefault(a => a.AlbumId == album.AlbumId);
            InitializeComponent();
            LoadAddTracks();
        }

        private void LoadAddTracks()
        {
            txtBoxArtist.Text = _album.Artist;
            txtBoxGenre.Text = _album.Genre;
        }

        private void picBoxBrowseTrack_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void picBoxBrowseTrack_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Arrow;
        }

        private void picBoxBrowseTrack_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\"; // optional
                openFileDialog.Filter = "Music Files (*.mp3;*.wav)|*.mp3;*.wav|All files (*.*)|*.*";
                openFileDialog.Multiselect = false; // change to true if you want to allow multiple files

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = openFileDialog.FileName;
                    txtBoxTrackFilePath.Text = selectedFile; // Example: Display in a TextBox



                    outputDevice = new WaveOutEvent();
                    audioFile = new AudioFileReader(openFileDialog.FileName);
                    outputDevice.Init(audioFile);
                }
            }
        }

        private void ClearTrackFields()
        {
            txtBoxTrackName.Text = "";
            txtBoxTrackFilePath.Text = "";
        }

        private void ShowAddTrackMessage()
        {
            MessageBox.Show("Track Added Successfully", "Add Track", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            Track newTrack = new Track
            {
                TrackName = txtBoxTrackName.Text,
                AlbumId = _album.AlbumId,
                Duration = audioFile.TotalTime,
                FilePath = txtBoxTrackFilePath.Text
            };
            _context.Tracks.Add(newTrack);
            _context.SaveChanges();
            ClearTrackFields();
            ShowAddTrackMessage();
        }
    }
}
