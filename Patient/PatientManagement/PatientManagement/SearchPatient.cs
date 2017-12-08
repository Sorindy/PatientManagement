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

        private void Search_Shown(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
        }

        private void dgvSearchPatient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSearchPatient.CurrentRow != null)
            {
                var patient = _patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value));
                txtSearch.Text = patient.Name;
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
        }
    }
}
