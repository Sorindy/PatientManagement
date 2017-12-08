using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class NurseResponeForm : Form
    {
        private delegate void ObjArgReturningVoidDelegate(object  obj);
        private BindingSource _bs;
        private NurseRespone _nurseRespone;
        private static Thread _th1;

        public NurseResponeForm()
        {
            InitializeComponent();
        }

        private void NurseResponeForm_Load(object sender, EventArgs e)
        {
            timer.Interval = (5 * 1000);
            timer.Tick += new EventHandler(NurseResponeForm_Load );
            timer.Start();
            _th1 = new Thread(ThreadProgress);
            Task.Factory.StartNew( _th1.Start);
        }

        public void ThreadProgress()
        {
            if (backgroundWorker.IsBusy)
            {
                backgroundWorker.Dispose();
            }
            else
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        public  void Setobject(object  obj)
        {
            if (dtgInformation.InvokeRequired)
            {
               ObjArgReturningVoidDelegate d = new ObjArgReturningVoidDelegate(Setobject);
                Invoke(d, new object[] { obj });
            }
            else
            {
                dtgInformation.DataSource = obj;
            }
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            _nurseRespone = new NurseRespone();
            _bs = new BindingSource();
            _bs.DataSource = _nurseRespone.SelectTempWaiting();
            if (backgroundWorker.CancellationPending)
            {
                e.Cancel = true;
                backgroundWorker.CancelAsync();
            }
            else
            {
                e.Result = _bs;
                Thread.Sleep(1500);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Setobject(e.Result);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            var message = "Do you want to Choose this Patient";
            var title = "Selete Patient For Doctor";
            var buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, title, buttons,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
            }
            else
            {
               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
