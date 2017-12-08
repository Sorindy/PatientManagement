using System;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class PatientForm : Form
    {
        public PatientForm()
        {
            InitializeComponent();
        }

        internal PatientListForm PatientListForm;
        internal Patient Patient;
        private readonly Class.Patient _patient=new Class.Patient();
        internal Account Account;

        private void PatientForm_Shown(object sender, EventArgs e)
        {
            Clear();

            txtName.Text = Patient.Name;
            cboGender.Text = Patient.Gender;
            dtpDOB.Value = Patient.DOB;
            txtAge.Text = Patient.Age.ToString();
            txtPhone1.Text = Patient.Phone1;
            txtPhone2.Text = Patient.Phone2;
            txtEmail.Text = Patient.Email;
            txtAddress.Text = Patient.Address;
            txtWeight.Text = Patient.Weight.ToString();
            txtHeight.Text = Patient.Height.ToString();

            btnEdit.Focus();

            txtName.Enabled = false;
            cboGender.Enabled = false;
            dtpDOB.Enabled = false;
            txtAge.Enabled = false;
            txtPhone1.Enabled = false;
            txtPhone2.Enabled = false;
            txtEmail.Enabled = false;
            txtAddress.Enabled = false;
            txtWeight.Enabled = false;
            txtHeight.Enabled = false;

            btnClear.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Now.Year - dtpDOB.Value.Year).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (PatientListForm != null)
            {
                PatientListForm.dgvListPatient.Columns.RemoveAt(7);
                PatientListForm.PatientListForm_Shown(PatientListForm, new EventArgs());
            }
            Close();
        }

        private void Clear()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtWeight.Text = "";
            txtHeight.Text = "";
            dtpDOB.Value = DateTime.Today;
            cboGender.Text = @"Female";
            txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Name == "btnEdit")
            {
                btnEdit.Text = @"Cancel";
                btnEdit.Name = @"btnCancel";
                btnEdit.Click += btnCancel_Click;
            }

            txtName.Enabled = true;
            cboGender.Enabled = true;
            dtpDOB.Enabled = true;
            txtAge.Enabled = true;
            txtPhone1.Enabled = true;
            txtPhone2.Enabled = true;
            txtEmail.Enabled = true;
            txtAddress.Enabled = true;
            txtWeight.Enabled = true;
            txtHeight.Enabled = true;

            txtName.Focus();
            btnUpdate.Enabled = true;
            btnClear.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnEdit.Name == "btnCancel")
            {
                btnEdit.Name = @"btnEdit";
                btnEdit.Text = @"Edit";
                btnEdit.Click -= btnCancel_Click;
            }

            PatientForm_Shown(this,new EventArgs());
        }

        private void CheckData()
        {
            if (txtName.Text.Trim() == "" || txtName.Text == null)
            {
                MessageBox.Show(@"Please fill Name.");
                txtName.Focus();
            }
            if (txtAddress.Text.Trim() == "" || txtAddress.Text == null)
            {
                MessageBox.Show(@"Please fill Address.");
                txtAddress.Focus();
            }
            if (txtPhone1.Text.Trim() == "" || txtPhone1.Text == null)
            {
                MessageBox.Show(@"Please fill Phone1.");
                txtName.Focus();
            }
            if (txtPhone2.Text.Trim() == "" || txtPhone2.Text == null)
            {
                txtPhone2.Text = @"None";
            }
            if (txtEmail.Text.Trim() == "" || txtEmail.Text == null)
            {
                txtEmail.Text = @"None";
            }
            if (dtpDOB.Value.Date == DateTime.Today)
            {
                MessageBox.Show(@"Make sure " + txtName.Text + @" date of birth correct.");
                dtpDOB.Focus();
            }
            if (txtWeight.Text.Trim() == "" || txtWeight.Text == null)
            {
                MessageBox.Show(@"Please input weight .");
                txtWeight.Focus();
            }
            if (txtHeight.Text.Trim() == "" || txtHeight.Text == null)
            {
                MessageBox.Show(@"Please input height .");
                txtHeight.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _patient.Update(Patient.Id,txtName.Text,cboGender.Text,dtpDOB.Value,Convert.ToByte(txtAge.Text),txtAddress.Text,txtPhone1.Text,
                    txtPhone2.Text,txtEmail.Text,Convert.ToInt16(txtWeight.Text),Convert.ToInt16(txtHeight.Text));
                PatientListForm.dgvListPatient.Columns.RemoveAt(7);
                PatientListForm.PatientListForm_Shown(PatientListForm,new EventArgs());
                Close();
            }
            catch
            {
                CheckData();
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (Account != null && Patient !=null)
            {
                var form = new HistorysForm() { Pateint = Patient, Account = Account };
                form.ShowDialog();
                Close();
            }
        }
    }
}
