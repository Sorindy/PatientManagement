using System;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class CheckInForm : Form
    {
        public CheckInForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1_Tick(this, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString() + " \n  " + DateTime.Now.ToLongTimeString();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}