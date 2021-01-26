using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinFormApp
{
    public partial class ApplicationForm : Form
    {
        private string _pathDB;
        private PlayListForm playListForm;
        public ApplicationForm()
        {
            InitializeComponent();
        }


        public ToolStripMenuItem PlaylistToolStrip
        {
            get
            {
                return playlistToolStripMenuItem;
            }
        }
        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel_DB_Name.ForeColor = Color.Red;
            this.toolStripStatusLabel_DB_Name.Text = "БД не выбрана";

            foreach (var item in toolStrip_book_controls.Items)
            {
                if (item is ToolStripButton)
                {
                    toolStripButtonChangeImageSize((ToolStripButton)item);
                }
            }
            toolStrip_book_controls.ImageScalingSize = new Size(40, 40);
            //string moviePath = "C:\\Users\\student\\Videos\\SABATON - The Attack of the Dead Men (Official Lyric Video).webm";
            //axWindowsMediaPlayer.playlistCollection.newPlaylist("");
            //axWindowsMediaPlayer.URL = moviePath;
        }
        private void toolStripButtonChangeImageSize(ToolStripButton toolStripButton)
        {
            int sourceWidth = toolStripButton.Image.Width;
            int sourceHeight = toolStripButton.Image.Height;
            Bitmap b = new Bitmap(40, 40);
            using (Graphics g = Graphics.FromImage((Image)b))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(toolStripButton.Image, 0, 0, 40, 40);
            }
            Image myResizedImg = (Image)b;
            toolStripButton.Image = myResizedImg;
        }


        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionsForm optionsForm = new OptionsForm(this);
            optionsForm.ShowDialog();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*string localePath = Application.StartupPath + "\\db";
            if (Directory.Exists(localePath))
            {
                openFileDialog_selectDB.InitialDirectory = localePath;
            }
            openFileDialog_selectDB.FileName = "";
            openFileDialog_selectDB.Filter = "Database Files| *.sqlite";
            
            if (openFileDialog_selectDB.ShowDialog() == DialogResult.OK)
            {
                _pathDB = openFileDialog_selectDB.FileName;
                toolStripStatusLabel_DB_Name.ForeColor = Color.Green;
                toolStripStatusLabel_DB_Name.Text = Path.GetFileName(_pathDB);
            }*/

            WMPLib.IWMPPlaylist playlist = axWindowsMediaPlayer.playlistCollection.newPlaylist("myplaylist");
            WMPLib.IWMPMedia media;
            if (openFileDialog_selectDB.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog_selectDB.FileNames)
                {
                    media = axWindowsMediaPlayer.newMedia(file);
                    playlist.appendItem(media);
                }
            }
            axWindowsMediaPlayer.currentPlaylist = playlist;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        public AxWMPLib.AxWindowsMediaPlayer MediaPlayer {
            get
            {
                return axWindowsMediaPlayer;
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string newFileDBPath;
            saveFileDialog_saveDB.FileName = "";
            saveFileDialog_saveDB.Filter = "Database Files| *.sqlite";
            if (saveFileDialog_saveDB.ShowDialog() == DialogResult.OK)
            {
                newFileDBPath = saveFileDialog_saveDB.FileName;
                DatabaseContext databaseContext = new DatabaseContext(newFileDBPath, SQLiteMode.NEW);
            }
        }

        private void playlistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(playListForm == null)
            {
                playListForm = new PlayListForm(this);

                playListForm.Show();
            }
            else
            {
                playListForm.Show();
            }
            playlistToolStripMenuItem.Checked = true;
        }
    }
}
