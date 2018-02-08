using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class NewPatient : Form
    {
        public NewPatient()
        {
            InitializeComponent();
        }

        internal PatientListForm PatientListForm;
        internal MedicalsForm MedicalForm;
        private readonly Patient _patient=new Patient();

        private void NewPatient_Shown(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PatientListForm.dgvListPatient.DataSource = null;
            PatientListForm.dgvListPatient.Columns.Clear();
            PatientListForm.CatelogForm.pnlFill.Controls.Clear();
            PatientListForm.CatelogForm.pnlFill.Controls.Add(PatientListForm);
            PatientListForm.PatientListForm_Shown(PatientListForm, new EventArgs());
            Close();
        }

        private void CheckData()
        {
            if (txtfName.Text.Trim() == "" || txtfName.Text == null)
            {
                MessageBox.Show(@"Please fill First Name.");
                txtfName.Focus();
            }
            if (txtlName.Text.Trim() == "" || txtlName.Text == null)
            {
                MessageBox.Show(@"Please fill Last Name.");
                txtlName.Focus();
            }
            if (txtkhName.Text.Trim() == "" || txtkhName.Text == null)
            {
                txtkhName.Text = @"None";
            }
            if (txtAddress.Text.Trim() == "" || txtAddress.Text == null)
            {
                MessageBox.Show(@"Please fill Address.");
                txtAddress.Focus();
            }
            if (txtPhone1.Text.Trim() == "" || txtPhone1.Text == null)
            {
                MessageBox.Show(@"Please fill Phone1.");
                txtfName.Focus();
            }
            if (txtPhone1.Text.Trim() == "" || txtPhone1.Text == null)
            {
                txtPhone1.Text = @"None";
            }
            if (txtEmail.Text.Trim() == "" || txtEmail.Text == null)
            {
                txtEmail.Text = @"None";
            }
            if (dtpDOB.Value.Date == DateTime.Today)
            {
                MessageBox.Show(@"Make sure " + txtfName.Text + @" date of birth correct.");
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

        private void Clear()
        {
            txtfName.Text = "";
            txtlName.Text = "";
            txtkhName.Text = "";
            txtAge.Text = "";
            txtAddress.Text = "";
            txtEmail.Text = "";
            txtPhone1.Text = "";
            txtPhone1.Text = "";
            txtWeight.Text = "";
            txtHeight.Text = "";
            dtpDOB.Value = DateTime.Today;
            cboGender.Text = @"Female";
            txtfName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PatientListForm != null)
            {
                try
                {
                    _patient.Insert(txtfName.Text, txtlName.Text, txtkhName.Text, cboGender.Text, dtpDOB.Value, Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone1.Text,
                        txtPhone1.Text, txtEmail.Text, Convert.ToInt16(txtWeight.Text), Convert.ToInt16(txtHeight.Text));
                    PatientListForm.dgvListPatient.DataSource = null;
                    PatientListForm.dgvListPatient.Columns.Clear();
                    PatientListForm.CatelogForm.pnlFill.Controls.Clear();
                    PatientListForm.CatelogForm.pnlFill.Controls.Add(PatientListForm);
                    PatientListForm.PatientListForm_Shown(PatientListForm, new EventArgs());
                    Close();
                }
                catch
                {
                    CheckData();
                    MessageBox.Show(@"Please Checking again !", @"Error");
                }
            }
            else
            {
                try
                {
                    _patient.Insert(txtfName.Text, txtlName.Text, txtkhName.Text, cboGender.Text, dtpDOB.Value, Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone1.Text,
                        txtPhone1.Text, txtEmail.Text, Convert.ToInt16(txtWeight.Text), Convert.ToInt16(txtHeight.Text));
                    MedicalForm.CatelogForm.pnlFill.Controls.Clear();
                    MedicalForm.CatelogForm.pnlFill.Controls.Add(MedicalForm);
                    MedicalForm.Show();
                    Close();
                }
                catch
                {
                    CheckData();
                    MessageBox.Show(@"Please Checking again !", @"Error");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Now.Year - dtpDOB.Value.Year).ToString();
        }
        
    }
}
