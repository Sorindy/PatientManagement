using System;
using System.Globalization;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;
using Patient = Hospital_Entity_Framework.Patient;

namespace PatientManagement
{
    public partial class MedicalForm : Form
    {

        private ISample _sample;
        private readonly Dating _dating=new Dating();
        private IEstimate _estimate;
        public Patient Patient;
        private  WaitingList _waitingList;

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
            btnWaitinglist.Enabled = false;
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
           var medicalhistoryform = new MedicalHistoryForm {Patient = Patient};
            medicalhistoryform.Show();
            Refresh();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {


            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {
                _estimate = new ConsultationEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/ConsultationEstimate/" + txtPatientID.Text + txtPatientName.Text + DateTime.Now);
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/ConsultationEstimate/" +txtPatientID.Text + txtPatientName.Text + DateTime.Now,StreamType.RichTextFormat);
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {
                _estimate = new PrescriptionEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/PrescriptionEstimate/" + txtPatientID.Text + txtPatientName.Text + DateTime.Now);
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/PrescriptionEstimate/" + txtPatientID.Text + txtPatientName.Text + DateTime.Now, StreamType.RichTextFormat);
              
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {
                _estimate = new MedicalImagingEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalImagingEstimate/" + txtPatientID.Text + txtPatientName.Text + DateTime.Now);
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/MedicalImagingEstimate/" + txtPatientID.Text + txtPatientName.Text + DateTime.Now, StreamType.RichTextFormat);
             
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                _estimate = new LaboratoryEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/LaboratoryEstimate/" + txtPatientID.Text + txtPatientName.Text + DateTime.Now);
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/LaboratoryEstimate/" + txtPatientID.Text + txtPatientName.Text + DateTime.Now, StreamType.RichTextFormat);
               
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(4))
            {
                _estimate = new VariousDocumentEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, "D:/PatientManagement/Patient/Hospital Entity Framework/RTF/VariousDocumentEstimate/" + txtPatientID.Text + txtPatientName.Text + DateTime.Now);
                txtDescription.Save("D:/PatientManagement/Patient/Hospital Entity Framework/RTF/VariousDocumentEstimate/" + txtPatientID.Text + txtPatientName.Text + DateTime.Now, StreamType.RichTextFormat);               
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
                _sample = new PrescriptionSample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(4))
            {
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
            var dating = new DatingListForm
            {
                StaffId = txtStaffID.Text,
                PatientId = txtPatientID.Text
            };
            dating.Show();
            Refresh();
        }

        private void btnAddDating_Click(object sender, EventArgs e)
        {
            _dating.Insert(Convert.ToInt32(txtPatientID.Text), Convert.ToInt32(txtStaffID.Text), dtpDating.Value);
            Refresh();
        }

        private void tmDate_Tick(object sender, EventArgs e)
        {
            lbTodaydate.Text = Convert.ToString(DateTime.Now, CultureInfo.InvariantCulture);
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

        
        private void btnWaitinglist_Click(object sender, EventArgs e)
        {
            var waitinglistform = new WaitingListForm {GetStaffCategory = cmbCategory.Text};
            waitinglistform.Show();
            waitinglistform.MedicalForm = this;
            gbDating.Enabled = true;
            gbMedicalItem.Enabled = true;
            btnDatinglist.Enabled = true;
            txtDescription.Enabled = true;
            btnPatientDetail.Enabled = true;
            Hide();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnWaitinglist.Enabled = true;
            Refresh();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FontDialog();
        }

        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.TextBackColorDialog();
        }

        private void selectForeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.ForeColorDialog();
        }

        private void frameFillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FrameFillColorDialog();
        }

        private void tableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.Tables.Add();
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.Images.Add();
        }

        private void tabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.TabDialog();
        }

        private void pageColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.PageColorDialog();
        }

        private void formatStyleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDescription.FormattingStylesDialog();
        }

        private void cmbRefferCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}


