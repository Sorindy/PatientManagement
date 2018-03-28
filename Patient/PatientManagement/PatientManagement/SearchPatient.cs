using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class SearchPatient : Form
    {
        public SearchPatient()
        {
            InitializeComponent();
        }

        private readonly Patient _patient=new Patient();
        internal CheckInsForm CheckInsForm;
        internal MedicalsForm MedicalsForm;
        internal DatingListForm Datinglistform;

        private void Search_Shown(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
            dgvSearchPatient.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvSearchPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearchPatient.CurrentRow != null)
            {
                var patient = _patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value));
                txtSearch.Text = patient.LastName;
                btnAdd.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvSearchPatient.CurrentRow != null)
            {
                if (CheckInsForm != null)
                {
                    CheckInsForm.Patient = _patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value));
                }
                if (MedicalsForm != null)
                {
                    MedicalsForm.Patient = _patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value));
                }
                if (Datinglistform != null)
                {
                    Datinglistform.Patient =_patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value));
                    Datinglistform.lbPatientName.Text = _patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value)).FirstName +@" "+ _patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value)).LastName;
                }
            }
            else
            {
                var form=new NewPatient();
                form.ShowDialog();
                Close();
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            dgvSearchPatient.DataSource = _patient.Search(txtSearch.Text);
            dgvSearchPatient.Columns[0].Visible = false;
        }
    }
}
