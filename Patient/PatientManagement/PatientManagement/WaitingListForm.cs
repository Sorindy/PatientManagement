using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class WaitingListForm : Form
    {
        public WaitingListForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Today.ToLongDateString() + "   " + DateTime.Now.ToLongTimeString();
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            this.timer1_Tick(this, e);
        }
    }
}
