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
    public partial class AuthForm : Form
    {
        private string U_login = "admin";
        private string U_password = "qwerty";

        public AuthForm()
        {
            InitializeComponent();
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            string c_login = textBox_login.Text;
            string c_password = textBox_password.Text;

            if(c_login.Length >= 3 && c_password.Length >= 6)
            {
                if (c_login == U_login && c_password == U_password)
                {
                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
            {
                toolStripStatusLabel_error.Text = "Данные не валидны";
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
