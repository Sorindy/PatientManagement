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
            if (txtPhone2.Text.Trim() == "" || txtPhone2.Text == null)
            {
                txtPhone2.Text = @"None";
            }
            if (txtEmail.Text.Trim() == "" || txtEmail.Text == null)
            {
                txtEmail.Text = @"None";
            }
            if (cboPosition.Text.Trim() == "" || cboPosition.Text == null)
            {
                MessageBox.Show(@"Please fill Position.");
                cboPosition.Focus();
            }
            if (txtSalary.Text.Trim() == "" || txtSalary.Text == null)
            {
                MessageBox.Show(@"Please fill Salary");
                txtSalary.Focus();
            }
            if (dtpSWD.Value.Date == DateTime.Now.AddDays(1))
            {
                MessageBox.Show(@"You can't hire " + txtfName.Text + @" over today.");
            }
            if (dtpDOB.Value.Date == DateTime.Today)
            {
                MessageBox.Show(@"Make sure " + txtfName.Text + @" date of birth correct.");
            }
        }

        private void Clear()
        {
            txtfName.Text = "";
            txtlName.Text = "";
            txtAge.Text = "";
            cboGender.Text = "";
            dtpDOB.Value = DateTime.Today;
            txtAddress.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            cboPosition.Text = "";
            txtSalary.Text = "";
            dtpSWD.Value = DateTime.Today;
            txtEmail.Text = "";
        }

        private void NewWorker_Shown(object sender, EventArgs e)
        {
            Clear();
            txtfName.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
            txtfName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _worker.Insert(txtfName.Text,txtlName.Text,cboGender.Text,dtpDOB.Value,Convert.ToByte(txtAge.Text),txtAddress.Text,txtPhone1.Text,txtPhone2.Text,
                                txtEmail.Text,cboPosition.Text,Convert.ToInt32(txtSalary.Text),dtpSWD.Value);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(8);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(8);
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
    }
}
