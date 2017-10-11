using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class MedicalForm : Form
    {

        private ISample _sample;
        private Dating _dating = new Dating();
        private IEstimate _estimate;
        private Patient _patient;

        public string GetPatientId 
        {
            get { return txtPatientID.Text; }
            set { txtPatientID.Text = value; }
        }

        public MedicalForm()
        {
            InitializeComponent();
        }

        private void MedicalForm_Load(object sender, EventArgs e)
        {
            tmDate.Start();
            gbActivity.Enabled = false;
            gbDating.Enabled = false;
            gbMedicalItem.Enabled = false;
            txtDescription.Enabled = false;
            btnDatinglist.Enabled = false;
            btnPatientDetail.Enabled = false;
            Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
        }

        private void btnPatientDetail_Click(object sender, EventArgs e)
        {
            var getid = txtPatientID.Text;
            var patientRegistrationForm = new PatientRegistrationForm();
            patientRegistrationForm.Show();
            patientRegistrationForm.SearchButtonEnable = false;
            patientRegistrationForm.TextId = getid;
            Refresh();
        }

        private void btnMedicalHistory_Click(object sender, EventArgs e)
        {
            Hide();
            var medicalhistoryform = new MedicalHistoryForm();
            medicalhistoryform.PatientIdTextboxChange = txtPatientID.Text;
            medicalhistoryform.Show();
            Refresh();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
           if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {
                _estimate = new ConsultationEstimate();
                _estimate.Insert(_estimate.AutoId(), cmbCategory.Text, txtStaffID.Text, DateTime.Now,txtDescription.Text);
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {
                _estimate = new PrescriptionEstimate();
                _estimate.Insert(_estimate.AutoId(), cmbCategory.Text, txtStaffID.Text, DateTime.Now, txtDescription.Text);
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {
                _estimate = new MedicalImagingEstimate();
                _estimate.Insert(_estimate.AutoId(), cmbCategory.Text, txtStaffID.Text, DateTime.Now, txtDescription.Text);

            }
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                _estimate = new LaboratoryEstimate();
                _estimate.Insert(_estimate.AutoId(), cmbCategory.Text, txtStaffID.Text, DateTime.Now, txtDescription.Text);

            }
            if (cmbMedicalRecord.SelectedIndex.Equals(4))
            {
                _estimate = new VariousDocumentEstimate();
                _estimate.Insert(_estimate.AutoId(), cmbCategory.Text, txtStaffID.Text, DateTime.Now, txtDescription.Text);
            }   
            btnSubmit.Visible = false;
            btnNew.Visible = true;
            Refresh();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {
                //_estimate = new PrescriptionEstimate();
                //txtMedicalId.Text = _estimate.AutoId();
                _sample = new PrescriptionSample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {
                //_estimate = new MedicalImagingEstimate();
                //txtMedicalId.Text = _estimate.AutoId();
                _sample = new MedicalImagingSample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                //_estimate = new LaboratoryEstimate();
                //txtMedicalId.Text = _estimate.AutoId();
                _sample = new LaboratorySample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(4))
            {
                //_estimate = new VariousDocumentEstimate();
                //txtMedicalId.Text = _estimate.AutoId();
                _sample = new VariousDocumentSample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            btnNew.Visible = false;
            btnSubmit.Visible = true;
            Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnNew.Visible = true;
            Refresh();
        }

        private void btnDatinglist_Click(object sender, EventArgs e)
        {
            var dating = new DatingListForm();
            dating.StaffId = txtStaffID.Text;
            dating.PatientId = txtPatientID.Text;
            dating.Show();
            Refresh();
        }

        private void btnAddDating_Click(object sender, EventArgs e)
        {
            _dating.Insert(_dating.AutoId(), txtPatientID.Text, txtStaffID.Text, dtpDating.Value.Date);
            Refresh();
        }

        private void tmDate_Tick(object sender, EventArgs e)
        {
            lbTodaydate.Text = Convert.ToString(DateTime.Now);
        }

        private void cmbMedicalRecord_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDescriptioinName.Text = cmbMedicalRecord.SelectedItem.ToString();
            gbActivity.Enabled = true;
            Refresh();
        }

        private void cmbSample_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
            Refresh();
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

        private void btnWaitinglist_Click(object sender, EventArgs e)
        {
            var waitinglistform = new WaitingListForm();
            waitinglistform.Show();
            Hide();
            Refresh();
        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {
            _patient = new Patient();
            txtPatientName.Text = _patient.Select(txtPatientID.Text).Name;
            Refresh();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbDating.Enabled = true;
            gbMedicalItem.Enabled = true;
            btnDatinglist.Enabled = true;
            txtDescription.Enabled = true;
            btnPatientDetail.Enabled = true;
            Refresh();
        }
    }
}


