using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinFormApp
{
    public partial class OptionsForm : Form
    {
        private ApplicationForm _parentForm;

        public OptionsForm()
        {
            InitializeComponent();
        }

        public OptionsForm(ApplicationForm parentForm)
        {
            this._parentForm = parentForm;
            InitializeComponent();
        }
        private void trackBar_ValueChanged(object sender, EventArgs e) {
            _parentForm.BackColor = Color.FromArgb(trackBar_RED.Value, trackBar_GREEN.Value, trackBar_BLUE.Value);
        }
    }
}
