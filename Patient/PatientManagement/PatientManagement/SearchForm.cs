using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class SearchForm : Form
    {

        public bool SubmitButton
        {
            get { return btnSumit.Visible ; }
            set { btnSumit.Visible = value; }
        }

        public bool AddDatingButton 
        {
            get { return btnAddDating.Visible; }
            set { btnAddDating.Visible = value; }
        }

        public SearchForm()
        {
            InitializeComponent();
        }

        private Patient _patient;
        public string Staffid;
        protected Hospital_Entity_Framework.Patient Patient;
        public PatientRegistrationForm PatientRegistrationForm;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _patient = new Patient();
            dtgInformation.DataSource = _patient.Search(txtSearch.Text);
            Refresh();    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Refresh();
            if (btnSumit.Visible.Equals( true ))
            {
                var patientregisterform = new PatientRegistrationForm();
                patientregisterform.Show();
            }
            else if (btnAddDating.Visible.Equals( true))
            {
                var datinglistform = new DatingListForm();
                datinglistform.Show();
            }
            Refresh();
            Hide();
        }

        private void btnSumit_Click(object sender, EventArgs e)
        {
            if (dtgInformation.CurrentRow != null)
            {
                var getid = dtgInformation.CurrentRow.Cells[0].Value.ToString();
                Patient = _patient.Select(Convert.ToInt32(getid));
            }
            var form = (PatientRegistrationForm) Application.OpenForms["PatientRegistrationForm"];

            if (form != null)
            {
                form.txtID.Text = Patient.Id.ToString( );
                form.txtName.Text = Patient.Name;
                form.cmbGender.Text = Patient.Gender;
                form.dtpDOB.Value = Patient.DOB;
                form.txtAge.Text = Patient.Age.ToString();
                form.txtAddress.Text = Patient.Address;
                form.txtPhone1.Text = Patient.Phone1;
                form.txtPhone2.Text = Patient.Phone2;
                form.txtEmail.Text = Patient.Email;
                form.txtHeight.Text = Patient.Height.ToString();
                form.txtWeight.Text = Patient.Weight.ToString();
            }

            PatientRegistrationForm.Show();
            Refresh();
            Close();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddDating_Click(object sender, EventArgs e)
        {
            if (dtgInformation.CurrentRow != null)
            {
                var getid = dtgInformation.CurrentRow.Cells[0].Value.ToString();
                Hide();
                var datingForm = new DatingListForm();
                datingForm.Show();
                //datingForm.StaffId = Staffid;
                //datingForm.PatientId = getid;
            } 
            Refresh();
        }

    }
}
