using System;
using System.Windows.Forms;
using PatientManagement.Class;
using WaitingList = Hospital_Entity_Framework.WaitingList;

namespace PatientManagement
{
    public partial class CheckInForm : Form
    {
        
        public CheckInForm()
        {
            InitializeComponent();
        }
        
        private readonly CheckIn _chkIn=new CheckIn();
        public WaitingList WaitingList;

        public void CheckInForm_Load(object sender, EventArgs e)
        {
            
            timer1.Enabled = true;
            timer1_Tick(this,e);
            gboService.Controls.Clear();
            gboCategory.Controls.Clear();
          //  gboService.Controls.Add(_chkIn.ShowService());
            ClearControl();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongDateString() + @" \n  " + DateTime.Now.ToLongTimeString();
        }

        internal void ClearControl()
        {
            txtSearch4Patient.Text = "";
            txtSearchDating.Text = "";
            gboCategory.Enabled = false;
            gboService.Enabled = false;
            dgvShowPatient.ReadOnly = true;
            dgvShowDatingPatient.ReadOnly = true;
            dgvShowPatient.DataSource = null;
            dgvShowDatingPatient.DataSource = null;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void txtSearch4Patient_TextChanged(object sender, EventArgs e)
        {
            dgvShowPatient.DataSource = _chkIn.SearchPatient(txtSearch4Patient.Text);
        }

        private void btnNewPatient_Click(object sender, EventArgs e)
        {
            var patientForm=new PatientRegistrationForm();

            patientForm.Show();
            Hide();
            patientForm.Checkinkform = this;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvShowPatient.CurrentRow != null)
            {
                var getid = Convert.ToInt32(dgvShowPatient.CurrentRow.Cells[0].Value);
                var now = DateTime.Now.TimeOfDay;
               // _chkIn.SubmitService(getid,now);
            }
            var print=new PrintWaitingForm();
            if (WaitingList != null) print.WaitingList = WaitingList;
            print.Show();

            CheckInForm_Load(this,e);
        }

        private void dgvShowPatient_SelectionChanged(object sender, EventArgs e)
        {
            gboService.Enabled = true;
            gboCategory.Enabled = true;
        }
    }
}
