using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using PatientManagement.Interface;
using ConsultationEstimate = PatientManagement.Class.ConsultationEstimate;
using ConsultationSample = PatientManagement.Class.ConsultationSample;
using Dating = PatientManagement.Class.Dating;
using Form = System.Windows.Forms.Form;
using LaboratoryEstimate = PatientManagement.Class.LaboratoryEstimate;
using LaboratorySample = PatientManagement.Class.LaboratorySample;
using MedicalImagingEstimate = PatientManagement.Class.MedicalImagingEstimate;
using MedicalImagingSample = PatientManagement.Class.MedicalImagingSample;
using PrescriptionEstimate = PatientManagement.Class.PrescriptionEstimate;
using PrescriptionSample = PatientManagement.Class.PrescriptionSample;
using VariousDocumentEstimate = PatientManagement.Class.VariousDocumentEstimate;
using VariousDocumentSample = PatientManagement.Class.VariousDocumentSample;
using WaitingList = Hospital_Entity_Framework.WaitingList;

namespace PatientManagement
{
    public partial class MedicalForm : Form
    {

        private ISample _sample;
        private readonly Dating _dating=new Dating();
        private IEstimate _estimate;
        public Patient Patient;
        public WaitingList WaitingList;

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
           var db=new HospitalDbContext();
            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {
                _estimate = new ConsultationEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, txtDescription.Text);
                var selectVisit = db.Visits.Single(v=>v.Id==WaitingList.VisitId);
                var selectConsultEsitmate = db.ConsultationEstimates.Single(v => v.ConsultationCategory.Name ==cmbCategory.Text);
                db.Visits.FirstOrDefault(v=>v.Id==selectVisit.Id).ConsultationEstimates.Add(selectConsultEsitmate);
                db.SaveChanges();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {
                _estimate = new PrescriptionEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, txtDescription.Text);
                var selectVisit = db.Visits.Single(v => v.Id == WaitingList.VisitId);
                var selectConsultEsitmate = db.PrescriptionEstimates.Single(v => v.PrescriptionCategory.Name == cmbCategory.Text);
                db.Visits.FirstOrDefault(v => v.Id == selectVisit.Id).PrescriptionEstimates.Add(selectConsultEsitmate);
                db.SaveChanges();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {
                _estimate = new MedicalImagingEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, txtDescription.Text);
                var selectVisit = db.Visits.Single(v => v.Id == WaitingList.VisitId);
                var selectConsultEsitmate = db.MedicalImagingEstimates.Single(v => v.MedicalImagingCategory.Name == cmbCategory.Text);
                db.Visits.FirstOrDefault(v => v.Id == selectVisit.Id).MedicalImagingEstimates.Add(selectConsultEsitmate);
                db.SaveChanges();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                _estimate = new LaboratoryEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, txtDescription.Text);
                var selectVisit = db.Visits.Single(v => v.Id == WaitingList.VisitId); 
                var selectConsultEsitmate = db.LaboratoryEstimates.Single(v => v.LaboratoryCategory.Name == cmbCategory.Text);
                db.Visits.FirstOrDefault(v => v.Id == selectVisit.Id).LaboratoryEstimates.Add(selectConsultEsitmate);
                db.SaveChanges();
            }
            if (cmbMedicalRecord.SelectedIndex.Equals(4))
            {
                _estimate = new VariousDocumentEstimate();
                _estimate.Insert(Convert.ToInt32(cmbCategory.Text), Convert.ToInt32(txtStaffID.Text), DateTime.Now, txtDescription.Text);
                var selectVisit = db.Visits.Single(v => v.Id == WaitingList.VisitId); 
                var selectConsultEsitmate = db.VariousDocumentEstimates.Single(v => v.VariousDocumentCategory.Name == cmbCategory.Text);
                db.Visits.FirstOrDefault(v => v.Id == selectVisit.Id).VariousDocumentEstimates.Add(selectConsultEsitmate);
                db.SaveChanges();
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

        private void btnFort_Click(object sender, EventArgs e)
        {
            var fd = new FontDialog
            {
                ShowColor = true,
                ShowApply = true,
                ShowEffects = true,
                ShowHelp = true
            };
            if (fd.ShowDialog() == DialogResult.OK & !string.IsNullOrEmpty(txtDescription.Text))
            {
                txtDescription.SelectionFont = fd.Font;
                txtDescription.SelectionColor = fd.Color; 
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

    }
}


