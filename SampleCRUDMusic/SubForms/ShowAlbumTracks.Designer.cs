namespace SampleCRUDMusic.SubForms
{
    partial class ShowAlbumTracks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblAlbumInformation = new Label();
            lblCurrentAlbumName = new Label();
            picBoxCurrentAlbumPicture = new PictureBox();
            panel2 = new Panel();
            dataGridViewTracks = new DataGridView();
            txtBoxSearchTrack = new TextBox();
            pictureBox1 = new PictureBox();
            picBoxPlayTracks = new PictureBox();
            picBoxAddTrack = new PictureBox();
            picBoxShuffleTracks = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCurrentAlbumPicture).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTracks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayTracks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAddTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShuffleTracks).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(lblAlbumInformation);
            panel1.Controls.Add(lblCurrentAlbumName);
            panel1.Controls.Add(picBoxCurrentAlbumPicture);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 188);
            panel1.TabIndex = 0;
            // 
            // lblAlbumInformation
            // 
            lblAlbumInformation.AutoSize = true;
            lblAlbumInformation.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbumInformation.ForeColor = SystemColors.Control;
            lblAlbumInformation.Location = new Point(198, 120);
            lblAlbumInformation.Name = "lblAlbumInformation";
            lblAlbumInformation.Size = new Size(118, 25);
            lblAlbumInformation.TabIndex = 2;
            lblAlbumInformation.Text = "Artist Name";
            // 
            // lblCurrentAlbumName
            // 
            lblCurrentAlbumName.AutoSize = true;
            lblCurrentAlbumName.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentAlbumName.ForeColor = SystemColors.Control;
            lblCurrentAlbumName.Location = new Point(185, 55);
            lblCurrentAlbumName.Name = "lblCurrentAlbumName";
            lblCurrentAlbumName.Size = new Size(326, 65);
            lblCurrentAlbumName.TabIndex = 1;
            lblCurrentAlbumName.Text = "Album Name";
            // 
            // picBoxCurrentAlbumPicture
            // 
            picBoxCurrentAlbumPicture.Location = new Point(36, 26);
            picBoxCurrentAlbumPicture.Name = "picBoxCurrentAlbumPicture";
            picBoxCurrentAlbumPicture.Size = new Size(143, 137);
            picBoxCurrentAlbumPicture.TabIndex = 0;
            picBoxCurrentAlbumPicture.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(dataGridViewTracks);
            panel2.Controls.Add(txtBoxSearchTrack);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(picBoxPlayTracks);
            panel2.Controls.Add(picBoxAddTrack);
            panel2.Controls.Add(picBoxShuffleTracks);
            panel2.Location = new Point(-1, 169);
            panel2.Name = "panel2";
            panel2.Size = new Size(858, 389);
            panel2.TabIndex = 1;
            // 
            // dataGridViewTracks
            // 
            dataGridViewTracks.AllowUserToAddRows = false;
            dataGridViewTracks.AllowUserToDeleteRows = false;
            dataGridViewTracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTracks.Location = new Point(31, 133);
            dataGridViewTracks.Name = "dataGridViewTracks";
            dataGridViewTracks.ReadOnly = true;
            dataGridViewTracks.Size = new Size(784, 454);
            dataGridViewTracks.TabIndex = 6;
            // 
            // txtBoxSearchTrack
            // 
            txtBoxSearchTrack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSearchTrack.Location = new Point(410, 25);
            txtBoxSearchTrack.Name = "txtBoxSearchTrack";
            txtBoxSearchTrack.PlaceholderText = "  Search track";
            txtBoxSearchTrack.Size = new Size(253, 29);
            txtBoxSearchTrack.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.search_track;
            pictureBox1.Location = new Point(681, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // picBoxPlayTracks
            // 
            picBoxPlayTracks.Image = Properties.Resources.play_tracks_medium;
            picBoxPlayTracks.Location = new Point(32, 12);
            picBoxPlayTracks.Name = "picBoxPlayTracks";
            picBoxPlayTracks.Size = new Size(71, 74);
            picBoxPlayTracks.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPlayTracks.TabIndex = 3;
            picBoxPlayTracks.TabStop = false;
            picBoxPlayTracks.MouseLeave += picBoxPlayTracks_MouseLeave;
            picBoxPlayTracks.MouseHover += picBoxPlayTracks_MouseHover;
            // 
            // picBoxAddTrack
            // 
            picBoxAddTrack.Image = Properties.Resources.add_tracks;
            picBoxAddTrack.Location = new Point(185, 25);
            picBoxAddTrack.Name = "picBoxAddTrack";
            picBoxAddTrack.Size = new Size(50, 50);
            picBoxAddTrack.SizeMode = PictureBoxSizeMode.AutoSize;
            picBoxAddTrack.TabIndex = 1;
            picBoxAddTrack.TabStop = false;
            picBoxAddTrack.MouseClick += picBoxAddTrack_MouseClick;
            picBoxAddTrack.MouseLeave += picBoxAddTrack_MouseLeave;
            picBoxAddTrack.MouseHover += picBoxAddTrack_MouseHover;
            // 
            // picBoxShuffleTracks
            // 
            picBoxShuffleTracks.Image = Properties.Resources.shuffle_tracks;
            picBoxShuffleTracks.Location = new Point(120, 25);
            picBoxShuffleTracks.Name = "picBoxShuffleTracks";
            picBoxShuffleTracks.Size = new Size(50, 50);
            picBoxShuffleTracks.SizeMode = PictureBoxSizeMode.AutoSize;
            picBoxShuffleTracks.TabIndex = 0;
            picBoxShuffleTracks.TabStop = false;
            picBoxShuffleTracks.MouseClick += picBoxShuffleTracks_MouseClick;
            picBoxShuffleTracks.MouseLeave += picBoxShuffleTracks_MouseLeave;
            picBoxShuffleTracks.MouseHover += picBoxShuffleTracks_MouseHover;
            // 
            // ShowAlbumTracks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 400);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ShowAlbumTracks";
            Text = "ShowAlbumTracks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxCurrentAlbumPicture).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTracks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPlayTracks).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxAddTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxShuffleTracks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox picBoxCurrentAlbumPicture;
        private Label lblCurrentAlbumName;
        private Label lblAlbumInformation;
        private PictureBox picBoxShuffleTracks;
        private PictureBox picBoxAddTrack;
        private PictureBox picBoxPlayTracks;
        private PictureBox pictureBox1;
        private TextBox txtBoxSearchTrack;
        private DataGridView dataGridViewTracks;
    }
}