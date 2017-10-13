using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class WaitingListForm : Form
    {

        private readonly WaitingList _waitingList = new WaitingList();
        public MedicalForm MedicalForm;
        public string GetStaffCategory;

        public WaitingListForm()
        {
            InitializeComponent();
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dtgConsultationWaiting.CurrentRow != null)
            MedicalForm.WaitingList=_waitingList.GetWaitingListObject(dtgConsultationWaiting.CurrentRow.Cells[0].Value.ToString());
            MedicalForm.Show();
            Close();
            MedicalForm.txtPatientID.Text = MedicalForm.WaitingList.PatientId;
            MedicalForm.txtPatientName.Text = MedicalForm.WaitingList.Patient.Name;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MedicalForm.Show();
            Close();
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            dtgConsultationWaiting.DataSource = _waitingList.ShowWaiting(GetStaffCategory);
        }

    }
}
