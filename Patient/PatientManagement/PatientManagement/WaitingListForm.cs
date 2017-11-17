using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class WaitingListForm : Form
    {

        private readonly  WaitingList _waitingList = new WaitingList() ;
        public  MedicalForm MedicalForm;
       
        public string GetStaffCategory;

        public WaitingListForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvWaiting.CurrentRow != null)
            {
                MedicalForm.txtPatientID.Text  = dgvWaiting.CurrentRow.Cells[1].Value.ToString();
                MedicalForm.txtPatientName.Text = dgvWaiting.CurrentRow.Cells[2].Value.ToString();
                MedicalForm.Show();
            }
            Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MedicalForm.Show();
            Close();
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            dgvWaiting.DataSource = _waitingList.ShowWaiting(GetStaffCategory);
            Refresh();
        }

    }
}
