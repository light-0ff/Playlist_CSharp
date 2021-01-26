namespace MyWinFormApp
{
    partial class PlayListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayListForm));
            this.toolStrip_playlist = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_playlist_add = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_playlist_delete = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renameCurrentPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBox = new System.Windows.Forms.Panel();
            this.toolStrip_playlist.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip_playlist
            // 
            this.toolStrip_playlist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_playlist_add,
            this.toolStripButton_playlist_delete});
            this.toolStrip_playlist.Location = new System.Drawing.Point(0, 24);
            this.toolStrip_playlist.Name = "toolStrip_playlist";
            this.toolStrip_playlist.Size = new System.Drawing.Size(402, 58);
            this.toolStrip_playlist.TabIndex = 0;
            this.toolStrip_playlist.Text = "toolStrip1";
            // 
            // toolStripButton_playlist_add
            // 
            this.toolStripButton_playlist_add.AutoSize = false;
            this.toolStripButton_playlist_add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_playlist_add.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_playlist_add.Image")));
            this.toolStripButton_playlist_add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_playlist_add.Name = "toolStripButton_playlist_add";
            this.toolStripButton_playlist_add.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton_playlist_add.Text = "toolStripButton1";
            this.toolStripButton_playlist_add.Click += new System.EventHandler(this.newPlaylistToolStripMenuItem_Click);
            // 
            // toolStripButton_playlist_delete
            // 
            this.toolStripButton_playlist_delete.AutoSize = false;
            this.toolStripButton_playlist_delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_playlist_delete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_playlist_delete.Image")));
            this.toolStripButton_playlist_delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_playlist_delete.Name = "toolStripButton_playlist_delete";
            this.toolStripButton_playlist_delete.Size = new System.Drawing.Size(55, 55);
            this.toolStripButton_playlist_delete.Text = "toolStripButton2";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.playlistsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPlaylistToolStripMenuItem,
            this.renameCurrentPlaylistToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newPlaylistToolStripMenuItem
            // 
            this.newPlaylistToolStripMenuItem.Name = "newPlaylistToolStripMenuItem";
            this.newPlaylistToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.newPlaylistToolStripMenuItem.Text = "New playlist";
            this.newPlaylistToolStripMenuItem.Click += new System.EventHandler(this.newPlaylistToolStripMenuItem_Click);
            // 
            // renameCurrentPlaylistToolStripMenuItem
            // 
            this.renameCurrentPlaylistToolStripMenuItem.Name = "renameCurrentPlaylistToolStripMenuItem";
            this.renameCurrentPlaylistToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.renameCurrentPlaylistToolStripMenuItem.Text = "Rename Current Playlist";
            this.renameCurrentPlaylistToolStripMenuItem.Click += new System.EventHandler(this.renameCurrentPlaylistToolStripMenuItem_Click);
            // 
            // playlistsToolStripMenuItem
            // 
            this.playlistsToolStripMenuItem.Name = "playlistsToolStripMenuItem";
            this.playlistsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.playlistsToolStripMenuItem.Text = "Playlists";
            // 
            // panelBox
            // 
            this.panelBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBox.Location = new System.Drawing.Point(0, 82);
            this.panelBox.Name = "panelBox";
            this.panelBox.Size = new System.Drawing.Size(402, 448);
            this.panelBox.TabIndex = 2;
            // 
            // PlayListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 530);
            this.Controls.Add(this.panelBox);
            this.Controls.Add(this.toolStrip_playlist);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PlayListForm";
            this.Text = "PlayListForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayListForm_FormClosing);
            this.Load += new System.EventHandler(this.PlayListForm_Load);
            this.toolStrip_playlist.ResumeLayout(false);
            this.toolStrip_playlist.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip_playlist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton_playlist_add;
        private System.Windows.Forms.ToolStripButton toolStripButton_playlist_delete;
        private System.Windows.Forms.ToolStripMenuItem renameCurrentPlaylistToolStripMenuItem;
        private System.Windows.Forms.Panel panelBox;
    }
}