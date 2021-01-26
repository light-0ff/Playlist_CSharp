using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinFormApp
{
    public partial class ManagePlayListForm : Form
    {
        private PlayListForm _ParentForm;
        public ManagePlayListForm()
        {
            InitializeComponent();
        }

        public ManagePlayListForm(PlayListForm playListForm)
        {
            _ParentForm = playListForm;
            InitializeComponent();
        }
        private void ManagePlayListForm_Load(object sender, EventArgs e)
        {
            if(_ParentForm != null)
            {
                textBox_MananePlayList.Text = _ParentForm.PlayListName;
            }
            textBox_MananePlayList.Focus();
            textBox_MananePlayList.Select(textBox_MananePlayList.Text.Length, 0);
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if(textBox_MananePlayList.Text.Length >= 3)
            {

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                toolStripStatusErrorLabel.Text = "Дайте имя плейлисту";
            }
        }
        public string newPlaylistName
        {
            get
            {
                return textBox_MananePlayList.Text;
            }
        }
        
    }
}
