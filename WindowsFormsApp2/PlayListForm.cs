using MyWinFormApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinFormApp
{
    public partial class PlayListForm : Form
    {
        private PlayListBox playListBox;
        private ApplicationForm parentForm;
        private string currentPlaylist = "Пустой плейлист";
        private string pathDB;
        private PlaylistsModel playlistsModel; //models
        private MediaTrackModel mediaTrackModel; //models
        public String PlayListName
        {
            get
            {
                return currentPlaylist;
            }
        }
        public PlayListForm(ApplicationForm applicationForm)
        {
            InitializeComponent();
            playListBox = new PlayListBox();
            this.parentForm = applicationForm;
            //MessageBox.Show($"{Environment.CurrentDirectory}\\Playlists.db");
            //MessageBox.Show($"{System.IO.Directory.GetParent(System.IO.Directory.GetParent(Environment.CurrentDirectory).FullName)}\\");
           

            this.pathDB = $"{Environment.CurrentDirectory}\\Playlists.db";
            this.playlistsModel = new PlaylistsModel(pathDB);
            this.mediaTrackModel = new MediaTrackModel(pathDB);
        }

        private void PlayListForm_Load(object sender, EventArgs e)
        {
            PlaylistsModel playlistsModel = new PlaylistsModel("C:\\Users\\tortl\\source\\repos\\WindowsFormsApp2\\WindowsFormsApp2\\bin\\Debug\\Playlists.db");
            this.panelBox.Controls.Add(playListBox);
            playListBox.Dock = DockStyle.Fill;
            playListBox.BackColor = Color.Red;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(
                parentForm.Left + parentForm.Size.Width,
                parentForm.Top
            );


            foreach (var item in playlistsModel.PlayLists.Values)
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                toolStripMenuItem.Text = item.ToString();
                playlistsToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
                toolStripMenuItem.Click += ToolStripMenuItem_Click;
            }
            if (playlistsToolStripMenuItem.DropDownItems.Count > 0)
            {
                ((ToolStripMenuItem)playlistsToolStripMenuItem.DropDownItems[0]).Checked = true;
                int id_default = playlistsModel.PlayLists.Keys[0];
                //


                /* int index = 1;
                 foreach (MediaTrackRecord item in mediaTrackModel.getRecordsFromPlayList(id_default))
                 {
                     //playListBox.Items.Add($"{index}. {item.trackName}");
                     playListBox.Items.Add(item);
                     index++;
                 }   */
                addRowToPlayList(id_default);

            }
            playListBox.MouseDoubleClick += PlayListBox_MouseDoubleClick;
        }

        private void PlayListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (((PlayListBox)sender).SelectedItem != null)
            {
                MediaTrackRecord record = (MediaTrackRecord)((PlayListBox)sender).SelectedItem;
                this.parentForm.MediaPlayer.URL = record.trackPath;
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem curItem = ((ToolStripMenuItem)sender);
            foreach (ToolStripMenuItem item in playlistsToolStripMenuItem.DropDownItems)
            {
                item.Checked = false;
            }
            curItem.Checked = true;

            int id_curItem = -1;
            for (int i = 0; i < playlistsToolStripMenuItem.DropDownItems.Count; i++)
            {
                if (curItem == playlistsToolStripMenuItem.DropDownItems[i])
                {
                    id_curItem = i;
                    break;
                }
            }
            playListBox.Items.Clear();
            /*   int index = 1;
               foreach (MediaTrackRecord item in mediaTrackModel.getRecordsFromPlayList(id_curItem + 1))
               {
                   //playListBox.Items.Add($"{index}. {item.trackName}");
                   playListBox.Items.Add(item);
                   index++;
               }   */
            addRowToPlayList(id_curItem + 1);
            currentPlaylist = curItem.Text; // замена имени текущего плейлиста
        }
        public void addRowToPlayList(int id)
        {
            int index = 1;
            foreach (MediaTrackRecord item in mediaTrackModel.getRecordsFromPlayList(id))
            {
                //playListBox.Items.Add($"{index}. {item.trackName}");
                playListBox.Items.Add(item);
                index++;
            }
        }

        private void PlayListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            parentForm.PlaylistToolStrip.Checked = false;
        }

        private void newPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePlayListForm managePlayListForm = new ManagePlayListForm();
            
            if (managePlayListForm.ShowDialog() == DialogResult.OK)
            {
                string newPlName = managePlayListForm.newPlaylistName;
                if (playlistsModel.addNewPlaylist(newPlName))
                {
                    foreach (ToolStripMenuItem item in playlistsToolStripMenuItem.DropDownItems)    //уборка текущего плейлиста
                    {
                        if (item.Checked == true)
                        {
                            item.Checked = false;
                        }
                    }

                    ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
                    toolStripMenuItem.Text = newPlName;
                    playlistsToolStripMenuItem.DropDownItems.Add(toolStripMenuItem); //добавить плейлист в менюайтем
                    toolStripMenuItem.Checked = true;   //сделать его текущим
                    currentPlaylist = newPlName;    //смена текущего плейлиста
                    toolStripMenuItem.Click += ToolStripMenuItem_Click;
                    playListBox.Items.Clear(); //очистить список дорожек

                }
                else
                {
                    throw new SQLiteException("Не смог создать плейлист, прости хозяин");
                }
            }
        }

        private void renameCurrentPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePlayListForm managePlayListForm = new ManagePlayListForm(this);
            if (managePlayListForm.ShowDialog() == DialogResult.OK)
            {
                string newPlName = managePlayListForm.newPlaylistName;
                if (playlistsModel.renameOldPlaylist(currentPlaylist, newPlName))
                {
                    /*  
                      foreach (ToolStripMenuItem item in playlistsToolStripMenuItem.DropDownItems)    //уборка текущего плейлиста
                      {
                          if (item.Name == currentPlaylist)
                          {
                              playlistsToolStripMenuItem.DropDownItems.Remove(item);
                              break;
                          }
                      }   //*/
                    ToolStripMenuItem buffer = new ToolStripMenuItem();
                    buffer.Checked = true;
                    buffer.Text = newPlName;
                   
                    playlistsToolStripMenuItem.DropDownItems.Find(newPlName, true)[0] = buffer;

                }
            }
        }

        private void toolStripButton_playlist_add_Click(object sender, EventArgs e)
        {

        }

    }

}