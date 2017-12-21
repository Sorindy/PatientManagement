using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class WaitingListForm : Form
    {

        internal Hospital_Entity_Framework.Worker Worker;
        private WaitingList _waitingList ;
        private NurseRespone _nurseRespone;

        public Hospital_Entity_Framework.WaitingList WaitingList;
       
       
        public string GetStaffCategory;

        public WaitingListForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvWaitingCategory.CurrentRow != null)
            {

                _nurseRespone = new NurseRespone();
                _nurseRespone.Insert(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value.ToString()), Worker.Id); 
                var loadingform = new LoadingForm();
                loadingform.WaitingList = _waitingList.GetWaitingListObject(Convert.ToInt32(dgvWaitingCategory.CurrentRow.Cells[0].Value));
                loadingform.ShowDialog( );
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            
            timer.Interval = (5* 1000);
            timer.Tick += btnRefresh_Click;
            timer.Start();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _waitingList = new WaitingList();
            dgvWaitingCategory.DataSource = _waitingList.ShowWaiting(GetStaffCategory);
            dgvAllWatingList.DataSource = _waitingList.SeleteAllWaiting();
        }

    }
}
