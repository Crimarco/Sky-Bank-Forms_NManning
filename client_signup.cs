using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sky_Bank_Forms
{
    public partial class client_signup : Form
    {
        public client_signup()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            pnl_clsignup.BringToFront();
        }

        private void btn_clsignup_Click(object sender, EventArgs e)
        {
            pnl_clsignin.Hide();
            pnl_clsignup.Show();
            pnl_clsignup.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //pnl_clsignup.Hide();
            pnl_clsignin.Show();
            pnl_clsignin.BringToFront();
        }

        private void btn_clsignin_Click(object sender, EventArgs e)
        {
            //pnl_clsignup.Hide();
            pnl_clsignin.Show();
            pnl_clsignin.BringToFront();
        }

        private void lbl_lastname_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Welcome_Page objwelcome = new Welcome_Page();
            objwelcome.Show();
            this.Close();
        }
    }
}
