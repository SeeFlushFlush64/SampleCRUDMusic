namespace SampleCRUDMusic.SubForms
{
    partial class AddAlbums
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
            lblAddAlbum = new Label();
            txtBoxAlbumName = new TextBox();
            txtBoxGenre = new TextBox();
            txtBoxArtist = new TextBox();
            lblAlbumName = new Label();
            lblGenre = new Label();
            lblArtist = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblAlbumPicture = new Label();
            txtBoxAlbumPicture = new TextBox();
            btnAddAlbum = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblAddAlbum
            // 
            lblAddAlbum.AutoSize = true;
            lblAddAlbum.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddAlbum.Location = new Point(24, 20);
            lblAddAlbum.Name = "lblAddAlbum";
            lblAddAlbum.Size = new Size(144, 32);
            lblAddAlbum.TabIndex = 1;
            lblAddAlbum.Text = "Add Album";
            // 
            // txtBoxAlbumName
            // 
            txtBoxAlbumName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAlbumName.Location = new Point(49, 96);
            txtBoxAlbumName.Name = "txtBoxAlbumName";
            txtBoxAlbumName.Size = new Size(242, 29);
            txtBoxAlbumName.TabIndex = 2;
            // 
            // txtBoxGenre
            // 
            txtBoxGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxGenre.Location = new Point(49, 255);
            txtBoxGenre.Name = "txtBoxGenre";
            txtBoxGenre.Size = new Size(242, 29);
            txtBoxGenre.TabIndex = 3;
            // 
            // txtBoxArtist
            // 
            txtBoxArtist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxArtist.Location = new Point(49, 175);
            txtBoxArtist.Name = "txtBoxArtist";
            txtBoxArtist.Size = new Size(242, 29);
            txtBoxArtist.TabIndex = 4;
            // 
            // lblAlbumName
            // 
            lblAlbumName.AutoSize = true;
            lblAlbumName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbumName.Location = new Point(49, 72);
            lblAlbumName.Name = "lblAlbumName";
            lblAlbumName.Size = new Size(56, 21);
            lblAlbumName.TabIndex = 5;
            lblAlbumName.Text = "Name";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGenre.Location = new Point(49, 231);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(55, 21);
            lblGenre.TabIndex = 6;
            lblGenre.Text = "Genre";
            // 
            // lblArtist
            // 
            lblArtist.AutoSize = true;
            lblArtist.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblArtist.Location = new Point(50, 151);
            lblArtist.Name = "lblArtist";
            lblArtist.Size = new Size(51, 21);
            lblArtist.TabIndex = 7;
            lblArtist.Text = "Artist";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.album_icon1;
            pictureBox1.Location = new Point(425, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(0, 0);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.album_icon2;
            pictureBox2.Location = new Point(480, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(237, 226);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // lblAlbumPicture
            // 
            lblAlbumPicture.AutoSize = true;
            lblAlbumPicture.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbumPicture.Location = new Point(371, 72);
            lblAlbumPicture.Name = "lblAlbumPicture";
            lblAlbumPicture.Size = new Size(200, 21);
            lblAlbumPicture.TabIndex = 11;
            lblAlbumPicture.Text = "Album Picture (optional)";
            // 
            // txtBoxAlbumPicture
            // 
            txtBoxAlbumPicture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAlbumPicture.Location = new Point(371, 96);
            txtBoxAlbumPicture.Name = "txtBoxAlbumPicture";
            txtBoxAlbumPicture.Size = new Size(242, 29);
            txtBoxAlbumPicture.TabIndex = 10;
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAlbum.Location = new Point(50, 324);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(90, 30);
            btnAddAlbum.TabIndex = 12;
            btnAddAlbum.Text = "Add";
            btnAddAlbum.UseVisualStyleBackColor = true;
            btnAddAlbum.Click += btnAddAlbum_Click;
            // 
            // AddAlbums
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 400);
            Controls.Add(btnAddAlbum);
            Controls.Add(lblAlbumPicture);
            Controls.Add(txtBoxAlbumPicture);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(lblArtist);
            Controls.Add(lblGenre);
            Controls.Add(lblAlbumName);
            Controls.Add(txtBoxArtist);
            Controls.Add(txtBoxGenre);
            Controls.Add(txtBoxAlbumName);
            Controls.Add(lblAddAlbum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddAlbums";
            Text = "AddAlbums";
            Load += AddAlbums_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAddAlbum;
        private TextBox txtBoxAlbumName;
        private TextBox txtBoxGenre;
        private TextBox txtBoxArtist;
        private Label lblAlbumName;
        private Label lblGenre;
        private Label lblArtist;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblAlbumPicture;
        private TextBox txtBoxAlbumPicture;
        private Button btnAddAlbum;
    }
}