using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class WaitingListForm : Form
    {

        public Hospital_Entity_Framework.Worker Worker = new Hospital_Entity_Framework.Worker();
        private WaitingList _waitingList ;
        private NurseRespone _nurseRespone;
        //private delegate void ObjArgReturningVoidDelegate(object obj);
        //private BindingSource _bs;
       
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
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            
            timer.Interval = (10* 1000);
            timer.Tick += btnRefresh_Click;
            timer.Start();
           // ThreadProgress();
        }

        //public void ThreadProgress()
        //{
        //    if (backgroundWorker.IsBusy)
        //    {
        //        backgroundWorker.Dispose();
        //    }
        //    else
        //    {
        //        backgroundWorker.RunWorkerAsync();
        //        backgroundWorker.Dispose();
        //    }
        //}

        //public void Setobject(object obj)
        //{
        //    if (dgvWaiting.InvokeRequired)
        //    {
        //        ObjArgReturningVoidDelegate d = new ObjArgReturningVoidDelegate(Setobject);
        //        Invoke(d, new object[] { obj });
          
        //    }
        //    else
        //    {
        //        dgvWaiting.DataSource = null;
        //        dgvWaiting.DataSource = obj;
        //    }
        //}

        //private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        //{
        //    //_waitingList = new WaitingList();
        //    //_bs = new BindingSource();
        //    //_bs.DataSource = _waitingList.ShowWaiting(GetStaffCategory);
        //    //e.Result = _bs;
        //}

        //private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        //{
        //    //Setobject(e.Result);
        //}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _waitingList = new WaitingList();
            dgvWaitingCategory.DataSource = _waitingList.ShowWaiting(GetStaffCategory);
            dgvAllWatingList.DataSource = _waitingList.SeleteAllWaiting();
        }

    }
}
