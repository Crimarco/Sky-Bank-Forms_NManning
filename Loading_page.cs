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
    public partial class Loading_page : Form
    {
        public Loading_page()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            pBar_loading.Value = startpoint;
            if (pBar_loading.Value == 100)
            {
                pBar_loading.Value = 0;
                timer1.Stop();
                Welcome_Page log = new Welcome_Page();
                this.Hide();
                log.Show();
            }
        }

        private void Loading_page_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
