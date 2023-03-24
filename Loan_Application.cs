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
    public partial class Loan_Application : Form
    {
        public Loan_Application()
        {
            InitializeComponent();
        }

        private void BtnCompletedForm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your loan is saved and will be processed shorty!");
        }
    }
}
