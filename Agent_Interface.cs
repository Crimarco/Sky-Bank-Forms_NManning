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
    public partial class Agent_Interface : Form
    {
        public Agent_Interface()
        {
            InitializeComponent();
        }

        private void agentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agent_Profile agentProfile = new Agent_Profile();
            agentProfile.Show();
            
        }
    }
}
