namespace SampleCRUDMusic.SubForms
{
    partial class AddTracks
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
            btnAddTrack = new Button();
            lblArtist = new Label();
            lblGenre = new Label();
            lblAlbumName = new Label();
            txtBoxArtist = new TextBox();
            txtBoxGenre = new TextBox();
            txtBoxTrackName = new TextBox();
            lblAddAlbum = new Label();
            lblAddTrackerHeader = new Label();
            txtBoxTrackFilePath = new TextBox();
            lblImportTrack = new Label();
            picBoxBrowseTrack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxBrowseTrack).BeginInit();
            SuspendLayout();
            // 
            // btnAddTrack
            // 
            btnAddTrack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTrack.Location = new Point(52, 324);
            btnAddTrack.Name = "btnAddTrack";
            btnAddTrack.Size = new Size(90, 30);
            btnAddTrack.TabIndex = 20;
            btnAddTrack.Text = "Add";
            btnAddTrack.UseVisualStyleBackColor = true;
            btnAddTrack.Click += btnAddTrack_Click;
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtist.Location = new Point(52, 151);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(51, 21);
            lblArtist.TabIndex = 19;
            lblArtist.Text = "Artist";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenre.Location = new Point(51, 231);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(55, 21);
            lblGenre.TabIndex = 18;
            lblGenre.Text = "Genre";
            // 
            // lblAlbumName
            // 
            lblAlbumName.AutoSize = true;
            lblAlbumName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbumName.Location = new Point(51, 72);
            lblAlbumName.Name = "lblAlbumName";
            lblAlbumName.Size = new Size(56, 21);
            lblAlbumName.TabIndex = 17;
            lblAlbumName.Text = "Name";
            // 
            // txtBoxArtist
            // 
            txtBoxArtist.Enabled = false;
            txtBoxArtist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxArtist.Location = new Point(51, 175);
            txtBoxArtist.Name = "txtBoxArtist";
            txtBoxArtist.ReadOnly = true;
            txtBoxArtist.Size = new Size(242, 29);
            txtBoxArtist.TabIndex = 16;
            txtBoxArtist.TabStop = false;
            // 
            // txtBoxGenre
            // 
            txtBoxGenre.Enabled = false;
            txtBoxGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxGenre.Location = new Point(51, 255);
            txtBoxGenre.Name = "txtBoxGenre";
            txtBoxGenre.ReadOnly = true;
            txtBoxGenre.Size = new Size(242, 29);
            txtBoxGenre.TabIndex = 15;
            txtBoxGenre.TabStop = false;
            // 
            // txtBoxTrackName
            // 
            txtBoxTrackName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTrackName.Location = new Point(51, 96);
            txtBoxTrackName.Name = "txtBoxTrackName";
            txtBoxTrackName.Size = new Size(242, 29);
            txtBoxTrackName.TabIndex = 14;
            // 
            // lblAddAlbum
            // 
            lblAddAlbum.AutoSize = true;
            lblAddAlbum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddAlbum.Location = new Point(22, 18);
            lblAddAlbum.Name = "lblAddAlbum";
            lblAddAlbum.Size = new Size(0, 32);
            lblAddAlbum.TabIndex = 13;
            // 
            // lblAddTrackerHeader
            // 
            lblAddTrackerHeader.AutoSize = true;
            lblAddTrackerHeader.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddTrackerHeader.Location = new Point(28, 18);
            lblAddTrackerHeader.Name = "lblAddTrackerHeader";
            lblAddTrackerHeader.Size = new Size(128, 32);
            lblAddTrackerHeader.TabIndex = 21;
            lblAddTrackerHeader.Text = "Add Track";
            // 
            // txtBoxTrackFilePath
            // 
            txtBoxTrackFilePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxTrackFilePath.Location = new Point(422, 96);
            txtBoxTrackFilePath.Name = "txtBoxTrackFilePath";
            txtBoxTrackFilePath.Size = new Size(242, 29);
            txtBoxTrackFilePath.TabIndex = 22;
            // 
            // lblImportTrack
            // 
            lblImportTrack.AutoSize = true;
            lblImportTrack.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblImportTrack.Location = new Point(422, 72);
            lblImportTrack.Name = "lblImportTrack";
            lblImportTrack.Size = new Size(203, 21);
            lblImportTrack.TabIndex = 23;
            lblImportTrack.Text = "Import Track (.mp3, .wav)";
            // 
            // picBoxBrowseTrack
            // 
            picBoxBrowseTrack.Image = Properties.Resources.browse_icon1;
            picBoxBrowseTrack.Location = new Point(670, 96);
            picBoxBrowseTrack.Name = "picBoxBrowseTrack";
            picBoxBrowseTrack.Size = new Size(37, 29);
            picBoxBrowseTrack.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxBrowseTrack.TabIndex = 24;
            picBoxBrowseTrack.TabStop = false;
            picBoxBrowseTrack.Click += picBoxBrowseTrack_Click;
            picBoxBrowseTrack.MouseLeave += picBoxBrowseTrack_MouseLeave;
            picBoxBrowseTrack.MouseHover += picBoxBrowseTrack_MouseHover;
            // 
            // AddTracks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 400);
            Controls.Add(picBoxBrowseTrack);
            Controls.Add(lblImportTrack);
            Controls.Add(txtBoxTrackFilePath);
            Controls.Add(lblAddTrackerHeader);
            Controls.Add(btnAddTrack);
            Controls.Add(lblArtist);
            Controls.Add(lblGenre);
            Controls.Add(lblAlbumName);
            Controls.Add(txtBoxArtist);
            Controls.Add(txtBoxGenre);
            Controls.Add(txtBoxTrackName);
            Controls.Add(lblAddAlbum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTracks";
            Text = "AddTracks";
            ((System.ComponentModel.ISupportInitialize)picBoxBrowseTrack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddTrack;
        private Label lblArtist;
        private Label lblGenre;
        private Label lblAlbumName;
        private TextBox txtBoxArtist;
        private TextBox txtBoxGenre;
        private TextBox txtBoxTrackName;
        private Label lblAddAlbum;
        private Label lblAddTrackerHeader;
        private TextBox txtBoxTrackFilePath;
        private Label lblImportTrack;
        private PictureBox picBoxBrowseTrack;
    }
}