using System;
using System.Drawing;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class LoadingForm : Form
    {
        internal Hospital_Entity_Framework.WaitingList WaitingList;

        public LoadingForm()
        {
           SetStyle(ControlStyles.SupportsTransparentBackColor, true );
            InitializeComponent();
            pictureBox1.BackColor = Color.FromArgb(0,Color.AliceBlue );
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            
            timer.Interval = (1 * 1000);
           // timer.Tick += btnRefresh_Click  ;
            timer.Start();
            
        }


        private void btnCancle_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
