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
            DtgHeaderText();
        }

        public void DtgHeaderText()
        {
            dgvSearchPatient.Columns[0].HeaderText = @"លេខកូដ";
            dgvSearchPatient.Columns[1].HeaderText = @"លេខសំគាល់";
            dgvSearchPatient.Columns[2].HeaderText = @"ត្រកូល";
            dgvSearchPatient.Columns[3].HeaderText = @"ឈ្មោះ";
            dgvSearchPatient.Columns[4].HeaderText = @"ឈ្មោះខ្មែរ";
            dgvSearchPatient.Columns[5].HeaderText = @"ភេទ";
            dgvSearchPatient.Columns[6].HeaderText = @"អាយុ";
            dgvSearchPatient.Columns[7].HeaderText = @"អាស័យដ្ធាន";
            dgvSearchPatient.Columns[8].HeaderText = @"ទូរស័ព្ទ";
        }
    }
}
