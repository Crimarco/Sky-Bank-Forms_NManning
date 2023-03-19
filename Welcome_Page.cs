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
    public partial class Welcome_Page : Form
    {
        public Welcome_Page()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_clientchoice_Click(object sender, EventArgs e)
        {
            client_signup objclientmenu = new client_signup();
            objclientmenu.Show();
            this.Hide();
        }

        private void btn_agentchoice_Click(object sender, EventArgs e)
        {
            Agent_signin objagentmenu = new Agent_signin();
            objagentmenu.Show();
            this.Hide();
        }
    }
}
