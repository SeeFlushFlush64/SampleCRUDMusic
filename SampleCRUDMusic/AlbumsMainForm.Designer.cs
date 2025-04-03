namespace SampleCRUDMusic
{
    partial class AlbumsMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSideBar = new Panel();
            panelBottomBar = new Panel();
            panelBody = new Panel();
            picBoxAddAlbum = new PictureBox();
            panelTopBar = new Panel();
            picBoxSearch = new PictureBox();
            txtBoxSearchBar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picBoxAddAlbum).BeginInit();
            panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxSearch).BeginInit();
            SuspendLayout();
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = SystemColors.WindowFrame;
            panelSideBar.Location = new Point(0, 63);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(60, 495);
            panelSideBar.TabIndex = 0;
            panelSideBar.Paint += panelSideBar_Paint;
            // 
            // panelBottomBar
            // 
            panelBottomBar.BackColor = SystemColors.ControlText;
            panelBottomBar.Dock = DockStyle.Bottom;
            panelBottomBar.Location = new Point(0, 554);
            panelBottomBar.Name = "panelBottomBar";
            panelBottomBar.Size = new Size(896, 101);
            panelBottomBar.TabIndex = 1;
            // 
            // panelBody
            // 
            panelBody.Location = new Point(57, 63);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(839, 492);
            panelBody.TabIndex = 3;
            // 
            // picBoxAddAlbum
            // 
            picBoxAddAlbum.Image = Properties.Resources.add_icon;
            picBoxAddAlbum.Location = new Point(0, 63);
            picBoxAddAlbum.Name = "picBoxAddAlbum";
            picBoxAddAlbum.Size = new Size(60, 60);
            picBoxAddAlbum.SizeMode = PictureBoxSizeMode.AutoSize;
            picBoxAddAlbum.TabIndex = 0;
            picBoxAddAlbum.TabStop = false;
            picBoxAddAlbum.Click += picBoxAddAlbum_Click;
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = SystemColors.WindowFrame;
            panelTopBar.Controls.Add(picBoxSearch);
            panelTopBar.Controls.Add(txtBoxSearchBar);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(896, 67);
            panelTopBar.TabIndex = 4;
            // 
            // picBoxSearch
            // 
            picBoxSearch.Image = Properties.Resources.search_icon;
            picBoxSearch.Location = new Point(487, 22);
            picBoxSearch.Name = "picBoxSearch";
            picBoxSearch.Size = new Size(38, 35);
            picBoxSearch.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxSearch.TabIndex = 1;
            picBoxSearch.TabStop = false;
            // 
            // txtBoxSearchBar
            // 
            txtBoxSearchBar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxSearchBar.Location = new Point(155, 22);
            txtBoxSearchBar.Name = "txtBoxSearchBar";
            txtBoxSearchBar.PlaceholderText = "  What do you want to play?";
            txtBoxSearchBar.Size = new Size(326, 35);
            txtBoxSearchBar.TabIndex = 0;
            // 
            // AlbumsMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(896, 655);
            Controls.Add(panelTopBar);
            Controls.Add(picBoxAddAlbum);
            Controls.Add(panelBody);
            Controls.Add(panelBottomBar);
            Controls.Add(panelSideBar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AlbumsMainForm";
            Text = "Albums";
            ((System.ComponentModel.ISupportInitialize)picBoxAddAlbum).EndInit();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxSearch).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSideBar;
        private Panel panelBottomBar;
        public Panel panelBody;
        private PictureBox picBoxAddAlbum;
        private Panel panelTopBar;
        private TextBox txtBoxSearchBar;
        private PictureBox picBoxSearch;
    }
}
