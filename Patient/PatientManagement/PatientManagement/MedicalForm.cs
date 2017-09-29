using System;
using System.Collections.Generic;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class MedicalForm : Form
    {

        private ISample _sample;
        private Dating _dating = new Dating();
        private IEstimate _estimate;
        
        public MedicalForm()
        {
            InitializeComponent();
        }

        private void MedicalForm_Load(object sender, EventArgs e)
        {
            tmDate.Start();
            gbActivity.Enabled = false;
            gbDating.Enabled = false;
            txtDescription.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            Close();
        }

        private void btnPatientDetail_Click(object sender, EventArgs e)
        {
            var getid = txtPatientID.Text;
            var ptrf = new PatientRegistrationForm();
            ptrf.Show();
            ptrf.TextId = getid;
        }

        private void btnMedicalHistory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //if (cmbType.Text == "Consultation")
            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {
                _estimate = new ConsultationEstimate();
                _estimate.Insert(_estimate.AutoId(), cmbCategory.Text, txtStaffID.Text, DateTime.Now,txtDescription.Text);
            }
            //if (cmbType.Text == "Prescription")
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {
                _estimate = new PrescriptionEstimate();
                _estimate.Insert(_estimate.AutoId(), cmbCategory.Text, txtStaffID.Text, DateTime.Now, txtDescription.Text);
            }
            //if (cmbType.Text == "MedicalImaging")
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {
                _estimate = new MedicalImagingEstimate();
                _estimate.Insert(_estimate.AutoId(), cmbCategory.Text, txtStaffID.Text, DateTime.Now, txtDescription.Text);

            }
            //if (cmbType.Text == "Laboratory")
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                _estimate = new LaboratoryEstimate();
                _estimate.Insert(_estimate.AutoId(), cmbCategory.Text, txtStaffID.Text, DateTime.Now, txtDescription.Text);

            }
            //if (cmbType.Text == "VariousDocument")
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
            //if (cmbType.Text == "Consultation")
            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {
               // _estimate = new ConsultationEstimate();
               // txtMedicalId.Text = _estimate.AutoId();
                _sample = new ConsultationSample();
                cmbSample.DataSource = _sample.Show_Sample_Title();

            }
            //if (cmbType.Text == "Prescription")
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {
                //_estimate = new PrescriptionEstimate();
                //txtMedicalId.Text = _estimate.AutoId();
                _sample = new PrescriptionSample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            //if (cmbType.Text == "MedicalImaging")
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {
                //_estimate = new MedicalImagingEstimate();
                //txtMedicalId.Text = _estimate.AutoId();
                _sample = new MedicalImagingSample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            //if (cmbType.Text == "Laboratory")
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                //_estimate = new LaboratoryEstimate();
                //txtMedicalId.Text = _estimate.AutoId();
                _sample = new LaboratorySample();
                cmbSample.DataSource = _sample.Show_Sample_Title();
            }
            //if (cmbType.Text == "VariousDocument")
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
            gbDating.Enabled = true;
            txtDescription.Enabled = true;
        }

        private void cmbSample_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbType.Text == "Consultation")
            if (cmbMedicalRecord.SelectedIndex.Equals(0))
            {
                _sample = new ConsultationSample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
            //if (cmbType.Text == "Prescription")
            if (cmbMedicalRecord.SelectedIndex.Equals(1))
            {
                _sample = new PrescriptionSample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
            //if (cmbType.Text == "MedicalImaging")
            if (cmbMedicalRecord.SelectedIndex.Equals(2))
            {
                _sample = new MedicalImagingSample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
            //if (cmbType.Text == "Laboratory")
            if (cmbMedicalRecord.SelectedIndex.Equals(3))
            {
                _sample = new LaboratorySample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
            //if (cmbType.Text == "VariousDocument")
            if (cmbMedicalRecord.SelectedIndex.Equals(4))
            {
                _sample = new VariousDocumentSample();
                txtDescription.Text = _sample.Search_Title(cmbSample.Text);
            }
        }
    }
}


