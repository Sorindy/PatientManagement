using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class WaitingListForm : Form
    {

        internal Hospital_Entity_Framework.Worker Worker;
        private WaitingList _waitingList ;
        private NurseRespone _nurseRespone;
        private delegate void ObjArgReturningVoidDelegate(object obj);
        private BindingSource _bs;
        private Thread _th1;
       
        public string GetStaffCategory;

        public WaitingListForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvWaiting.CurrentRow != null)
            {
                _nurseRespone = new NurseRespone();
                _nurseRespone.Insert(Convert.ToInt32( dgvWaiting.CurrentRow.Cells[0].Value.ToString()), Worker.Id); 
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            timer.Interval = (5 * 1000);
            timer.Tick += new EventHandler(WaitingListForm_Load);
            timer.Start();
            _th1 = new Thread(ThreadProgress);
            Task.Factory.StartNew(_th1.Start);
            
        }

        public void ThreadProgress()
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.Dispose();
                _th1.Abort();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
                _th1.Abort();
            }
        }

        public void Setobject(object obj)
        {
            if (dgvWaiting.InvokeRequired)
            {
                ObjArgReturningVoidDelegate d = new ObjArgReturningVoidDelegate(Setobject);
                Invoke(d, new object[] { obj });
            }
            else
            {
                dgvWaiting.DataSource = obj;
            }
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _waitingList = new WaitingList();
            _bs = new BindingSource();
            _bs.DataSource = _waitingList.ShowWaiting(GetStaffCategory);
            e.Result = _bs;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Setobject(e.Result);
        }

    }
}
