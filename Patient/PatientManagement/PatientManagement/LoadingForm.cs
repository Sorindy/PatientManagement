using System;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class LoadingForm : Form
    {
        private string _patientstatus;
        private int _waitingid;
        internal Hospital_Entity_Framework.WaitingList WaitingList  ;
        private WaitingList _waitingList;

        public LoadingForm()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true );
            InitializeComponent();
            pictureBox1.BackColor = Color.FromArgb(0,Color.AliceBlue);
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            _waitingid = WaitingList.Id;        
            timer.Interval = (1 * 1000);
            timer.Tick += btnRefresh_Click;
            timer.Start();
            
        }


        private void btnCancle_Click(object sender, EventArgs e)
        {
            var message = "Do you want to Cancle The Process...";
            var title = "Cancle";
            var buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _waitingList = new WaitingList();
            _patientstatus=  _waitingList.GetWaitingListObject(_waitingid).Status.ToString();
        if (_patientstatus != "")
        {
            if (_patientstatus == "True")
            {
                Close();
            }
        }
        }
        


    }
}
