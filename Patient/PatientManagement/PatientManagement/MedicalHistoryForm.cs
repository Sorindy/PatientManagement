using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class MedicalHistoryForm : Form
    {

        private MedicalHistory _medicalHistory = new MedicalHistory();
        private Patient _patient = new Patient();
        private Visit _visit = new Visit();

        public string PatientIdTextboxChange 
        {
            get { return txtPatientID.Text; }
            set { txtPatientID.Text = value; }
        }


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
            txtMedicalId.Text = _medicalHistory.Show_medicalhistory(txtPatientID.Text).Id;
            txtDescription.Text = _medicalHistory.Show_medicalhistory(txtPatientID.Text).Description;
            btnSubmit.Visible = false;
            btnUpdate.Visible = true;
            if (txtMedicalId.Text == "")
            {
               txtMedicalId.Text = _medicalHistory.AutoId();
                btnSubmit.Visible = true;
                btnUpdate.Visible = false;
            }
            Refresh();
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lbTodaydate.Text = Convert.ToString(DateTime.Now);
        }

        private void cmbVisit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFort_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd = new FontDialog();
            fd.ShowColor = true;
            fd.ShowApply = true;
            fd.ShowEffects = true;
            fd.ShowHelp = true;
            if (fd.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(txtDescription.Text))
            {
                txtDescription.SelectionFont = fd.Font;
                txtDescription.SelectionColor = fd.Color;
                }
            Refresh();
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
            _medicalHistory.Insert(txtMedicalId.Text, txtPatientID.Text, txtDescription.Text);
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _medicalHistory.Update(txtMedicalId.Text, txtDescription.Text);
            Refresh();
        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {
            txtPatientName.Text =_patient.Select(txtPatientID.Text).Name;
            Refresh();
        }

        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMedicalRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {
                dtgInformation.DataSource = _visit.ShowVisitEstimate(txtPatientID.Text);
                dtgInformation.Visible = true;
                txtDescription.Visible = false;
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {
                
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {

            }
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(4))
            {
                
            }
        }
        
    }
}
