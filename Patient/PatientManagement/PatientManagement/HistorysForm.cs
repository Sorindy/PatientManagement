using System;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using PatientManagement.Interface;
using TXTextControl;
using Account = Hospital_Entity_Framework.Account;
using Form = System.Windows.Forms.Form;
using Patient = Hospital_Entity_Framework.Patient;

namespace PatientManagement
{
    public partial class HistorysForm : Form
    {
        public HistorysForm()
        {
            InitializeComponent();
        }

        internal Patient Patient;
        internal Account Account;
        private ICategory _category;
        private bool _mouseDown;
        private Point _lastLocation;
        private readonly MedicalHistory _medicalHistory=new MedicalHistory();
        private IHistory _history;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckOrderDgv()
        {
            for (int i = 0; i <= dgvHistory.RowCount - 1; i++)
            {
                if (i % 2 == 0)
                {
                    dgvHistory.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                }
                else
                {
                    dgvHistory.Rows[i].DefaultCellStyle.BackColor = Color.MintCream;
                }
            }
        }
        private void HistorysForm_Shown(object sender, EventArgs e)
        {
            txtNamePatient.Text = Patient.LastName;
            txtGenderPatient.Text = Patient.Gender;
            txtNameDoctor.Text = Account.Worker.LastName;
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboService.Text == @"Consultation")
            {
                _category = new ConsultationCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";   
                }
            }
            if (cboService.Text == @"Laboratory")
            {
                _category=new LaboratoryCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Medical Imaging")
            {
                _category = new LaboratoryCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Prescription")
            {
                _category = new LaboratoryCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
            if (cboService.Text == @"Various Document")
            {
                _category = new LaboratoryCategory();
                var dic = _category.ShowCategoryForDoctor(Account.WorkerId);
                if (dic.Count != 0)
                {
                    cboCategory.DataSource = new BindingSource(dic, null);
                    cboCategory.DisplayMember = "Value";
                    cboCategory.ValueMember = "Key";
                }
            }
        }

        private void HistorysForm_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void HistorysForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void HistorysForm_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tableLayoutPanel1_MouseUp(object sender,MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            var form = new PatientForm {Patient = Patient};
            form.ShowDialog();
            Close();
        }

        private void cboSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSelection.Text == @"Consultation")
            {
                _history=new ConsultationHistory();
                dgvHistory.DataSource = _history.Show(Patient.Id);
            }
            if (cboSelection.Text == @"Laboratory")
            {
                _history = new LaboratoryHistory();
                dgvHistory.DataSource = _history.Show(Patient.Id);
            }
            if (cboSelection.Text == @"MedicalImaging")
            {
                _history = new MedicalImagingHistory();
                dgvHistory.DataSource = _history.Show(Patient.Id);
            }
            if (cboSelection.Text == @"Prescription")
            {
                _history = new PrescriptionHistory();
                dgvHistory.DataSource = _history.Show(Patient.Id);
            }
            if (cboSelection.Text == @"VariousDocument")
            {
                _history = new VariousDocumentHistory();
                dgvHistory.DataSource = _history.Show(Patient.Id);
            }
            if (cboSelection.Text == @"Patient's History")
            {
                dgvHistory.DataSource = null;
                var getPath = _medicalHistory.Show_medicalhistory(Patient.Id);
                if(getPath!=null)txtDescription.Load(getPath.Description, StreamType.RichTextFormat);
            }
            if (dgvHistory.DataSource != null) { dgvHistory.Columns[0].Visible = false; CheckOrderDgv();}
        }

    }
}
