using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLQuery_example
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        void login()
        {
            database db = new database();
            db.Login(TxtUsername.Text, TxtPassword.Text);
            foreach (Control objectX in this.Controls)
            {
                if (objectX is TextBox)
                {
                    objectX.Text = "";
                }
            }
            TxtUsername.Focus();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            login();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddUser add = new FrmAddUser();
            add.ShowDialog();
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            TxtUsername.Focus();
        }
    }
}
