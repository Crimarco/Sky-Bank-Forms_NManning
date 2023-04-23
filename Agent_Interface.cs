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

        private void DepositfundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposit_Funds depositfunds = new Deposit_Funds();
            depositfunds.Show();
        }

        private void updateClientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_clientinfo updateinfo = new Update_clientinfo();
            updateinfo.Show();  
        }

        private void add_remove_agentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Remove_agent addagent = new Add_Remove_agent();
            addagent.Show();
        }
    }
}
