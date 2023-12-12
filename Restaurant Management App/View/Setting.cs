using Restaurant_Management_App.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_App.View
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            btlogout.OnHoverBaseColor = btlogout.BaseColor;
            DialogResult res = MessageBox.Show("Bạn có chắc muốn đăng xuất ?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Application.OpenForms["frmMain"].Close();
                frmLogin frmLogin = new frmLogin();
                frmLogin.ShowDialog();
            }
        }

        private void btAllCategory_Click(object sender, EventArgs e)
        {
            btchangepw.OnHoverBaseColor = btchangepw.BaseColor;
            frmChangePW frm = new frmChangePW();
            frm.ShowDialog();
            
        }

        private void btchangeusername_Click(object sender, EventArgs e)
        {
            btchangeusername.OnHoverBaseColor=btchangeusername.BaseColor;
            frmChangeUsername frm = new frmChangeUsername();
            frm.ShowDialog();
            
        }

        private void btchangepw_MouseHover(object sender, EventArgs e)
        {
            btchangepw.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
        }

        private void btchangeusername_MouseHover(object sender, EventArgs e)
        {
            btchangeusername.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
        }

        private void btlogout_MouseHover(object sender, EventArgs e)
        {
            btlogout.OnHoverBaseColor = Color.FromArgb(115, 144, 114);
        }
    }
}
