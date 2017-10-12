using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class WaitingListForm : Form
    {

        private WaitingList _waitingList = new WaitingList();

        public string GetStaffCategory;

        public WaitingListForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var medicalform = new MedicalForm();
            medicalform.GetPatientId = txtPatientId.Text;
            medicalform.Show();
            Hide();
            Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
        }

        private void WaitingListForm_Load(object sender, EventArgs e)
        {
            dtgConsultationWaiting.DataSource = _waitingList.ShowWaiting(GetStaffCategory);
            btnSubmit.Enabled = false;
            Refresh();
        }

        private void dtgConsultationWaiting_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtPatientId.Text = dtgConsultationWaiting.CurrentRow.Cells[1].Value.ToString();
            Refresh();
        }

        private void txtPatientId_TextChanged(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
        }
    }
}
