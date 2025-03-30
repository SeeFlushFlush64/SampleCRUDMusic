﻿namespace SampleCRUDMusic.SubForms
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
            btnAddAlbum = new Button();
            lblArtist = new Label();
            lblGenre = new Label();
            lblAlbumName = new Label();
            txtBoxArtist = new TextBox();
            txtBoxGenre = new TextBox();
            txtBoxAlbumName = new TextBox();
            lblAddAlbum = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAddAlbum
            // 
            btnAddAlbum.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddAlbum.Location = new Point(52, 324);
            btnAddAlbum.Name = "btnAddAlbum";
            btnAddAlbum.Size = new Size(90, 30);
            btnAddAlbum.TabIndex = 20;
            btnAddAlbum.Text = "Add";
            btnAddAlbum.UseVisualStyleBackColor = true;
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
            txtBoxArtist.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxArtist.Location = new Point(51, 175);
            txtBoxArtist.Name = "txtBoxArtist";
            txtBoxArtist.Size = new Size(242, 29);
            txtBoxArtist.TabIndex = 16;
            // 
            // txtBoxGenre
            // 
            txtBoxGenre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxGenre.Location = new Point(51, 255);
            txtBoxGenre.Name = "txtBoxGenre";
            txtBoxGenre.Size = new Size(242, 29);
            txtBoxGenre.TabIndex = 15;
            // 
            // txtBoxAlbumName
            // 
            txtBoxAlbumName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBoxAlbumName.Location = new Point(51, 96);
            txtBoxAlbumName.Name = "txtBoxAlbumName";
            txtBoxAlbumName.Size = new Size(242, 29);
            txtBoxAlbumName.TabIndex = 14;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 21;
            label1.Text = "Add Track";
            // 
            // AddTracks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 400);
            Controls.Add(label1);
            Controls.Add(btnAddAlbum);
            Controls.Add(lblArtist);
            Controls.Add(lblGenre);
            Controls.Add(lblAlbumName);
            Controls.Add(txtBoxArtist);
            Controls.Add(txtBoxGenre);
            Controls.Add(txtBoxAlbumName);
            Controls.Add(lblAddAlbum);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddTracks";
            Text = "AddTracks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddAlbum;
        private Label lblArtist;
        private Label lblGenre;
        private Label lblAlbumName;
        private TextBox txtBoxArtist;
        private TextBox txtBoxGenre;
        private TextBox txtBoxAlbumName;
        private Label lblAddAlbum;
        private Label label1;
    }
}