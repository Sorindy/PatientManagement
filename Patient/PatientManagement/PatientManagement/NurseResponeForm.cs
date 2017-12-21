using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class NurseResponeForm : Form
    {
       
        private NurseRespone _nurseRespone;
        private WaitingList _waitingList;

        public NurseResponeForm()
        {
            InitializeComponent();
        }

        private void NurseResponeForm_Load(object sender, EventArgs e)
        {
            timer.Interval = (1 * 1000);
            timer.Tick += btnRefresh_Click;
            timer.Start();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            var message = "Do you want to Choose this Patient";
            var title = "Selete Patient For Doctor";
            var buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (dtgInformation.CurrentRow != null)
                {
                    _waitingList = new WaitingList();
                    _nurseRespone = new NurseRespone();
                    _waitingList.UpdatePatientStatus(Convert.ToInt16(dtgInformation.CurrentRow.Cells[1].Value), true);
                    _nurseRespone.DeleteTempWaitingList(Convert.ToInt16(dtgInformation.CurrentRow.Cells[0].Value));
                }
            }
            else
            {
                if (dtgInformation.CurrentRow != null)
                {
                    _waitingList = new WaitingList();
                    _waitingList.UpdatePatientStatus(Convert.ToInt16(dtgInformation.CurrentRow.Cells[1].Value), false);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _nurseRespone = new NurseRespone();
            _waitingList = new WaitingList();
            dtgInformation.DataSource = _nurseRespone.SelectTempWaiting();
            dtgWaitingList.DataSource = _waitingList.SeleteAllWaiting();
        }


    }
}
