using System;
using System.Windows.Forms;
using PatientManagement.Class;
using TXTextControl;
using patient = Hospital_Entity_Framework.Patient ;

namespace PatientManagement
{
    public partial class MedicalHistoryForm : Form
    {

        private readonly MedicalHistory _medicalHistory = new MedicalHistory();
        public patient Patient;
        private readonly Visit _visit=new Visit();
        public MedicalForm MedicalForm ;

        public MedicalHistoryForm()
        {
            InitializeComponent();
        }

        public string  PatientId;
        public string  PatientName;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Hide();
            MedicalForm.Show();
            Refresh();
        }

        private void MedicalHistoryForm_Load(object sender, EventArgs e)
        {
            tmTime.Start();
            dtgInformation.Visible = false;
            txtPatientID.Text = PatientId;
            txtPatientName.Text = PatientName;
            try
            {
                txtDescription.Load("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalHistory/" + txtPatientID.Text + txtPatientName.Text, StreamType.RichTextFormat);
                btnSubmit.Visible = false;
                btnUpdate.Visible = true;
            }
            catch
            {
                btnSubmit.Visible = true;
                btnUpdate.Visible = false;
            }
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
            _medicalHistory.Insert(Convert.ToInt32(txtPatientID.Text) ,"D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalHistory/"+txtPatientID.Text +txtPatientName.Text );
            txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalHistory/" + txtPatientID.Text + txtPatientName.Text, StreamType.RichTextFormat);
            btnSubmit.Visible = false;
            btnUpdate.Visible = true;
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _medicalHistory.Update(Convert.ToInt32(txtMedicalId.Text), "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalHistory/" + txtPatientID.Text + txtPatientName.Text);
            txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalHistory/" + txtPatientID.Text + txtPatientName.Text, StreamType.RichTextFormat);               
            Refresh();
        }

        private void cmbMedicalRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {

                dtgInformation.DataSource = _visit.ShowConsultationVisitEstimate(Convert.ToInt32(txtPatientID.Text ));
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
