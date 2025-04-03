namespace SampleCRUDMusic.SubForms
{
    partial class Dashboard
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
            btnShowAllAlbums = new Button();
            btnShowAllTracks = new Button();
            lblRecentlyAdded = new Label();
            lblAlbumByGenre = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panelRecentlyAdded = new Panel();
            picBoxRALeft = new PictureBox();
            picBoxRARight = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBoxRALeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRARight).BeginInit();
            SuspendLayout();
            // 
            // btnShowAllAlbums
            // 
            btnShowAllAlbums.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllAlbums.Location = new Point(12, 12);
            btnShowAllAlbums.Name = "btnShowAllAlbums";
            btnShowAllAlbums.Size = new Size(78, 35);
            btnShowAllAlbums.TabIndex = 0;
            btnShowAllAlbums.Text = "Albums";
            btnShowAllAlbums.UseVisualStyleBackColor = true;
            // 
            // btnShowAllTracks
            // 
            btnShowAllTracks.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllTracks.Location = new Point(96, 12);
            btnShowAllTracks.Name = "btnShowAllTracks";
            btnShowAllTracks.Size = new Size(88, 35);
            btnShowAllTracks.TabIndex = 1;
            btnShowAllTracks.Text = "Tracks";
            btnShowAllTracks.UseVisualStyleBackColor = true;
            // 
            // lblRecentlyAdded
            // 
            lblRecentlyAdded.AutoSize = true;
            lblRecentlyAdded.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecentlyAdded.Location = new Point(12, 76);
            lblRecentlyAdded.Name = "lblRecentlyAdded";
            lblRecentlyAdded.Size = new Size(151, 25);
            lblRecentlyAdded.TabIndex = 4;
            lblRecentlyAdded.Text = "Recently Added";
            // 
            // lblAlbumByGenre
            // 
            lblAlbumByGenre.AutoSize = true;
            lblAlbumByGenre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlbumByGenre.Location = new Point(12, 360);
            lblAlbumByGenre.Name = "lblAlbumByGenre";
            lblAlbumByGenre.Size = new Size(150, 25);
            lblAlbumByGenre.TabIndex = 6;
            lblAlbumByGenre.Text = "Listen by Genre";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Location = new Point(20, 394);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(693, 139);
            flowLayoutPanel2.TabIndex = 5;
            // 
            // panelRecentlyAdded
            // 
            panelRecentlyAdded.Location = new Point(53, 116);
            panelRecentlyAdded.Name = "panelRecentlyAdded";
            panelRecentlyAdded.Size = new Size(732, 228);
            panelRecentlyAdded.TabIndex = 7;
            // 
            // picBoxRALeft
            // 
            picBoxRALeft.Image = Properties.Resources.left_icon;
            picBoxRALeft.Location = new Point(12, 199);
            picBoxRALeft.Name = "picBoxRALeft";
            picBoxRALeft.Size = new Size(35, 50);
            picBoxRALeft.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxRALeft.TabIndex = 8;
            picBoxRALeft.TabStop = false;
            picBoxRALeft.MouseClick += picBoxRALeft_MouseClick;
            // 
            // picBoxRARight
            // 
            picBoxRARight.Image = Properties.Resources.right_icon;
            picBoxRARight.Location = new Point(791, 199);
            picBoxRARight.Name = "picBoxRARight";
            picBoxRARight.Size = new Size(35, 50);
            picBoxRARight.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxRARight.TabIndex = 9;
            picBoxRARight.TabStop = false;
            picBoxRARight.MouseClick += picBoxRARight_MouseClick;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(855, 400);
            Controls.Add(picBoxRARight);
            Controls.Add(picBoxRALeft);
            Controls.Add(lblAlbumByGenre);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(lblRecentlyAdded);
            Controls.Add(btnShowAllTracks);
            Controls.Add(btnShowAllAlbums);
            Controls.Add(panelRecentlyAdded);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "`";
            ((System.ComponentModel.ISupportInitialize)picBoxRALeft).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxRARight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnShowAllAlbums;
        private Button btnShowAllTracks;
        private Label lblRecentlyAdded;
        private Label lblAlbumByGenre;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panelRecentlyAdded;
        private PictureBox picBoxRALeft;
        private PictureBox picBoxRARight;
    }
}