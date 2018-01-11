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
    public partial class FrmAddUser : Form
    {
        public FrmAddUser()
        {
            InitializeComponent();
        }

        private void LblInf_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(LblInf, "Passwords do not match. Please retype!");
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            TxtName.Focus();
            LblInf.Visible = false;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtPass1.Text==TxtPass2.Text)
            {
                LblInf.Visible = false;
                database db = new database();
                db.Add_user(TxtName.Text, TxtSurname.Text, TxtUsername.Text, TxtPass2.Text);
                foreach (Control objectX in this.Controls)
                {
                    if (objectX is TextBox)
                    {
                        objectX.Text = "";
                    }
                }
            }
            else
            {
                LblInf.Visible = true;
            }
        }

        #region Text Controller and Focus on next Textbox
        private void TxtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtSurname.Focus();
            }
        }

        private void TxtSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                TxtUsername.Focus();
            }
        }

        private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                TxtPass1.Focus();
            }
        }

        private void TxtPass1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                TxtPass2.Focus();
            }
        }
#endregion 

    }
}
 