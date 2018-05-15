using System;
using System.Drawing;
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

        private static void CheckOrderDgv(DataGridView dgv)
        {
            dgv.Columns[0].Visible = false;
            for (var i = 0; i <= dgv.RowCount - 1; i++)
            {
                dgv.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Color.LightGray : Color.MintCream;
            }
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font(@"Arial", 14, FontStyle.Bold);
        }
        private void Search_Shown(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            txtSearch.Focus();
            dgvSearchPatient.ColumnHeadersDefaultCellStyle.Alignment=DataGridViewContentAlignment.MiddleCenter;
            dgvSearchPatient.DataSource = _patient.ShowAll();
            if (dgvSearchPatient.DataSource == null) return;
            CheckOrderDgv(dgvSearchPatient);
            dgvSearchPatient.Columns[0].Visible = false;
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
                if (dgvSearchPatient.SelectedRows.Count>=0)
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
                        Datinglistform.Patient = _patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value));
                        Datinglistform.lbPatientName.Text = _patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value)).FirstName + @" " + _patient.Select(Convert.ToInt32(dgvSearchPatient.CurrentRow.Cells[0].Value)).LastName;
                    }
                }
            }
            else
            {
                if (Datinglistform != null)
                {
                    Close();
                    return;
                }
                var form=new NewPatient{MedicalForm = MedicalsForm,CheckInFrom = CheckInsForm};
                Close();
                form.ShowDialog();
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
            CheckOrderDgv(dgvSearchPatient);
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
