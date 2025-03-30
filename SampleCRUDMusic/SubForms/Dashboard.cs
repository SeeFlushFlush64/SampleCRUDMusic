using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SampleCRUDMusic.Data;
using SampleCRUDMusic.Models.Entities;

namespace SampleCRUDMusic.SubForms
{
    public partial class Dashboard : Form
    {
        private readonly AppDbContext _context;
        private int albumWidth = 180; // Album box width + margin
        private int visibleAlbums = 3; // Only 3 visible at a time
        private int currentIndex = 0; // Current scroll index

        public Dashboard(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadAlbums();
        }

        private void LoadAlbums()
        {
            panelRecentlyAdded.Controls.Clear(); // Clear previous items
            var albums = _context.Albums.ToList();

            for (int i = 0; i < albums.Count; i++)
            {
                Panel albumPanel = new Panel
                {
                    Size = new Size(170, 220), // Increased height for text
                    BorderStyle = BorderStyle.FixedSingle,
                    Padding = new Padding(5),
                    Left = i * albumWidth // Arrange albums horizontally
                };

                // Album Cover
                PictureBox picAlbum = new PictureBox
                {
                    Size = new Size(160, 160),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    ImageLocation = albums[i].AlbumPicture,
                    Top = 5,
                    Left = 5
                };

                // **Album Name**
                Label lblAlbumName = new Label
                {
                    Text = albums[i].AlbumName,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(albumPanel.Width - 10, 20), // Set fixed size
                    Top = picAlbum.Bottom + 5, // Position below image
                    Left = 5
                };

                // **Artist Name**
                Label lblArtist = new Label
                {
                    Text = "By: " + albums[i].Artist,
                    Font = new Font("Arial", 8),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Size = new Size(albumPanel.Width - 10, 15), // Set fixed size
                    Top = lblAlbumName.Bottom + 2, // Position below album name
                    Left = 5
                };

                // **Add components to album panel**
                albumPanel.Controls.Add(picAlbum);
                albumPanel.Controls.Add(lblAlbumName);
                albumPanel.Controls.Add(lblArtist);

                // **Add albumPanel to the main panel**
                panelRecentlyAdded.Controls.Add(albumPanel);
            }

            UpdateButtons(); // Show/hide buttons
        }



        private void btnRight_Click(object sender, EventArgs e)
        {
            int totalAlbums = panelRecentlyAdded.Controls.Count;
            if (currentIndex + visibleAlbums < totalAlbums)
            {
                currentIndex++;
                panelRecentlyAdded.Left -= albumWidth; // Move left
                UpdateButtons();
            }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                panelRecentlyAdded.Left += albumWidth; // Move right
                UpdateButtons();
            }
        }

        private void UpdateButtons()
        {
            picBoxRALeft.Visible = (currentIndex > 0);
            picBoxRARight.Visible = (currentIndex + visibleAlbums < panelRecentlyAdded.Controls.Count);
        }
    }
}
