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
        private NurseRespone _nurseRespone;
        internal MedicalsForm MedicalsForm;
        internal WaitingListForm Waitinglistform;

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
            var message = "Do you want to Cancle The Proccess...";
            var title = "Cancle";
            var buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _nurseRespone = new NurseRespone();
                _nurseRespone.DeleteTempWaitingListByWaitingId(_waitingid);
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
                    MedicalsForm.txtNamePatient.Text = _waitingList.GetWaitingListObject(_waitingid).Patient.FirstName + @"  " + _waitingList.GetWaitingListObject(_waitingid).Patient.LastName;
                    MedicalsForm.txtGenderPatient.Text = _waitingList.GetWaitingListObject(_waitingid).Patient.Gender;
                    MedicalsForm.WaitingList = WaitingList;
                    MedicalsForm.Patient= _waitingList.GetWaitingListObject(_waitingid).Patient;
                    Waitinglistform.Close();
                    Close();
                   
                }
                else
                {
                    timer.Stop();
                    MessageBox.Show(@"This Patient is Not Available...!");
                    Close();
                }
            }
        }
        


    }
}
