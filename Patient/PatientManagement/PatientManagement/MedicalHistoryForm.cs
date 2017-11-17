using System;
using System.Linq;
using System.Windows.Forms;
using PatientManagement.Class;
using Patient = Hospital_Entity_Framework.Patient;

namespace PatientManagement
{
    public partial class MedicalHistoryForm : Form
    {

        private readonly MedicalHistory _medicalHistory = new MedicalHistory();
        public Patient Patient;
        private readonly Visit _visit=new Visit();

        public MedicalHistoryForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            var mediccalform = new MedicalForm();
            mediccalform.Show();
            Refresh();
        }

        private void MedicalHistoryForm_Load(object sender, EventArgs e)
        {
            tmTime.Start();
            dtgInformation.Visible = false;
            txtDescription.Text = _medicalHistory.Show_medicalhistory(Patient.Id).Description;
            btnSubmit.Visible = false;
            btnUpdate.Visible = true;
            txtPatientID.Text =Patient.Id.ToString("0000");
            txtPatientName.Text = Patient.Name;
            Refresh();
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lbTodaydate.Text = DateTime.Now.ToLongDateString();
        }

        private void btnPatientDetail_Click(object sender, EventArgs e)
        {
            var getid = txtPatientID.Text;
            var patientRegistrationForm  = new PatientRegistrationForm();
            patientRegistrationForm.Show();
            patientRegistrationForm.SearchButtonEnable = false;
            patientRegistrationForm.TextId = getid;
            Refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _medicalHistory.Insert(Patient.Id, txtDescription.Text);

            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _medicalHistory.Update(Convert.ToInt32(txtMedicalId.Text), txtDescription.Text);
            Refresh();
        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {

            _medicalHistory.Update(Patient.MedicalHistories.Select(v=>v.Id).First(),txtDescription.Text);

            Refresh();
        }

        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMedicalRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {

                dtgInformation.DataSource = _visit.ShowConsultationVisitEstimate(Patient.Id);
                dtgInformation.Visible = true;
                txtDescription.Visible = false;
            }
           
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {

                dtgInformation.DataSource = _visit.ShowPrescriptionVisitEstimate(Patient.Id);
                dtgInformation.Visible = true;
                txtDescription.Visible = false;
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {

                dtgInformation.DataSource = _visit.ShowMedicalImagingVisitEstimate(Patient.Id);

                dtgInformation.Visible = true;
                txtDescription.Visible = false;
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {

                dtgInformation.DataSource = _visit.ShowLaboratoryVisitEstimate(Patient.Id);

                dtgInformation.Visible = true;
                txtDescription.Visible = false;
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(4))
            {

                dtgInformation.DataSource = _visit.ShowVariousDocumentVisitEstimate(Patient.Id);
                dtgInformation.Visible = true;
                txtDescription.Visible = false;
            }
        }

        private void dtgInformation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgInformation.CurrentRow != null)
            {
                //txtId.Text = dtgInformation.CurrentRow.Cells[0].Value.ToString();
                //txtTitle.Text = dtgInformation.CurrentRow.Cells[1].Value.ToString();
                //txtDescription.Text = dtgInformation.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

       
        
    }
}
