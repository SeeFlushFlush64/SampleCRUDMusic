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
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnShowAllAlbums
            // 
            btnShowAllAlbums.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllAlbums.Location = new Point(21, 22);
            btnShowAllAlbums.Name = "btnShowAllAlbums";
            btnShowAllAlbums.Size = new Size(78, 35);
            btnShowAllAlbums.TabIndex = 0;
            btnShowAllAlbums.Text = "Albums";
            btnShowAllAlbums.UseVisualStyleBackColor = true;
            // 
            // btnShowAllTracks
            // 
            btnShowAllTracks.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllTracks.Location = new Point(105, 22);
            btnShowAllTracks.Name = "btnShowAllTracks";
            btnShowAllTracks.Size = new Size(88, 35);
            btnShowAllTracks.TabIndex = 1;
            btnShowAllTracks.Text = "Tracks";
            btnShowAllTracks.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(21, 85);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(701, 100);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 400);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnShowAllTracks);
            Controls.Add(btnShowAllAlbums);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnShowAllAlbums;
        private Button btnShowAllTracks;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}