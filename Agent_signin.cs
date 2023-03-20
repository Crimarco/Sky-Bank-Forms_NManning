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
    public partial class Agent_signin : Form
    {
        public Agent_signin()
        {
            InitializeComponent();
        }

        private void btn_fagsignin_Click(object sender, EventArgs e)
        {

        }

        private void btn_agsignin_Click(object sender, EventArgs e)
        {

        }

        private void txtBx_agusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBx_agpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_agentback_Click(object sender, EventArgs e)
        {
            Welcome_Page objwelcome = new Welcome_Page();
            objwelcome.Show();
            this.Hide();
        }

        private void btn_agentsignup_Click(object sender, EventArgs e)
        {
            pnl_agentsignup.BringToFront();
            pnl_agentsignin.Hide();
        }

        private void btn_agentsignin_Click(object sender, EventArgs e)
        {
            pnl_agentsignup.SendToBack();
            pnl_agentsignin.Show();
            pnl_agentsignin.BringToFront();
        }
    }
}
