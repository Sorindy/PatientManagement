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

        internal Patient Pateint;
        internal Account Account;
        private ICategory _category;
        private bool _mouseDown;
        private Point _lastLocation;
        private readonly MedicalHistory _history=new MedicalHistory();

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HistorysForm_Shown(object sender, EventArgs e)
        {
            txtNamePatient.Text = Pateint.Name;
            txtGenderPatient.Text = Pateint.Gender;
            txtNameDoctor.Text = Account.Worker.Name;
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboService.Text == @"Consultation")
            {
                _category = new ConsultationCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryForDoctor(Account.WorkerId), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
            }
            if (cboService.Text == @"Laboratory")
            {
                _category=new LaboratoryCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryForDoctor(Account.WorkerId), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
            }
            if (cboService.Text == @"Medical Imaging")
            {
                _category = new LaboratoryCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryForDoctor(Account.WorkerId), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
            }
            if (cboService.Text == @"Prescription")
            {
                _category = new LaboratoryCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryForDoctor(Account.WorkerId), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
            }
            if (cboService.Text == @"Various Document")
            {
                _category = new LaboratoryCategory();
                cboCategory.DataSource = new BindingSource(_category.ShowCategoryForDoctor(Account.WorkerId), null);
                cboCategory.DisplayMember = "Value";
                cboCategory.ValueMember = "Key";
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

        }

    }
}
