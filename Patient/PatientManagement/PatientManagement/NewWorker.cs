using System;
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class NewWorker : Form
    {
        public NewWorker()
        {
            InitializeComponent();
        }

        private readonly Worker _worker=new Worker();
        internal WorkerListForm WorkerListForm;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
            if (txtPosition.Text.Trim() == "" || txtPosition.Text == null)
            {
                MessageBox.Show(@"Please fill Position.");
                txtPosition.Focus();
            }
            if (txtSalary.Text.Trim() == "" || txtSalary.Text == null)
            {
                MessageBox.Show(@"Please fill Salary");
                txtSalary.Focus();
            }
            if (dtpSWD.Value.Date == DateTime.Now.AddDays(1))
            {
                MessageBox.Show(@"You can't hire " + txtName.Text + @" over today.");
            }
            if (dtpDOB.Value.Date == DateTime.Today)
            {
                MessageBox.Show(@"Make sure " + txtName.Text + @" date of birth correct.");
            }
        }

        private void Clear()
        {
            txtName.Text = "";
            txtAge.Text = "";
            cboGender.Text = "";
            dtpDOB.Value = DateTime.Today;
            txtAddress.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtPosition.Text = "";
            txtSalary.Text = "";
            dtpSWD.Value = DateTime.Today;
            txtEmail.Text = "";
        }

        private void NewWorker_Shown(object sender, EventArgs e)
        {
            Clear();
            txtName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            txtName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _worker.Insert(txtName.Text,cboGender.Text,dtpDOB.Value,Convert.ToByte(txtAge.Text),txtAddress.Text,txtPhone1.Text,txtPhone2.Text,
                                txtEmail.Text,txtPosition.Text,Convert.ToInt32(txtSalary.Text),dtpSWD.Value);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(7);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(7);
                WorkerListForm.WorkerListForm_Shown(WorkerListForm, new EventArgs());
                Close();
            }
            catch
            {
               CheckData();
            }
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Today.Year - dtpDOB.Value.Year).ToString();
            txtAddress.Focus();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            cboGender.Focus();
        }

        private void cboGender_Leave(object sender, EventArgs e)
        {
            dtpDOB.Focus();
        }

        private void txtPhone1_Leave(object sender, EventArgs e)
        {
            txtPhone2.Focus();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            dtpSWD.Focus();
        }

        private void dtpSWD_Leave(object sender, EventArgs e)
        {
            txtPosition.Focus();
        }

        private void txtPosition_Leave(object sender, EventArgs e)
        {
            txtSalary.Focus();
        }

        private void txtSalary_Leave(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            txtPhone1.Focus();
        }

        private void txtPhone2_Leave(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }
    }
}
