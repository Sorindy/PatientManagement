using System;
using System.Windows.Forms;
using Hospital_Entity_Framework;
using Account = PatientManagement.Class.Account;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        internal Worker Worker;
        private readonly Class.Worker _worker=new Class.Worker();
        private readonly Account _account=new Account();
        internal WorkerListForm WorkerListForm;

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

        internal void WorkerForm_Shown(object sender, EventArgs e)
        {
            txtName.Text = Worker.Name;
            txtAge.Text = Worker.Age.ToString();
            txtAddress.Text = Worker.Address;
            txtPhone1.Text = Worker.Phone1;
            txtPhone2.Text = Worker.Phone2;
            txtEmail.Text = Worker.Email;
            txtSalary.Text = Worker.Salary.ToString();
            cboGender.Text = Worker.Gender;
            dtpDOB.Value = Worker.DOB;
            txtPosition.Text = Worker.Position;
            if (Worker.StartWorkDate != null) dtpSWD.Value = (DateTime) Worker.StartWorkDate;

            txtName.Enabled = false;
            txtAge.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone1.Enabled = false;
            txtPhone2.Enabled = false;
            txtPosition.Enabled = false;
            txtSalary.Enabled = false;
            txtEmail.Enabled = false;
            cboGender.Enabled = false;
            dtpDOB.Enabled = false;
            dtpSWD.Enabled = false;

            btnUpdate.Enabled = false;
            CheckAccount();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            WorkerListForm.dgvListWorker.Columns.RemoveAt(7);
            WorkerListForm.dgvListWorker.Columns.RemoveAt(7);
            WorkerListForm.WorkerListForm_Shown(WorkerListForm, new EventArgs());
            Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == @"Edit")
            {
                btnEdit.Text = @"Cancel";
                btnEdit.Name = @"btnCancel";
                btnUpdate.Enabled = true;
                txtName.Enabled = true;
                txtAge.Enabled = true;
                txtAddress.Enabled = true;
                txtPhone1.Enabled = true;
                txtPhone2.Enabled = true;
                txtPosition.Enabled = true;
                txtSalary.Enabled = true;
                txtEmail.Enabled = true;
                cboGender.Enabled = true;
                dtpDOB.Enabled = true;
                dtpSWD.Enabled = true;
                btnEdit.Click += btnCancel_Click;
                txtName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnEdit.Text = @"Edit";
            btnEdit.Name = @"btnEdit";
            btnEdit.Click -= btnCancel_Click;
            WorkerForm_Shown(this, new EventArgs());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _worker.Update(Worker.Id, txtName.Text, cboGender.Text, dtpDOB.Value, Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone1.Text,
                    txtPhone2.Text, txtEmail.Text, txtPosition.Text, Convert.ToInt32(txtSalary.Text), dtpSWD.Value);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(7);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(7);
                WorkerListForm.WorkerListForm_Shown(this, new EventArgs());
                Close();
            }
            catch
            {
                CheckData();
            }
        }

        private void dtpDOB_Leave(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Now.Year - dtpDOB.Value.Year).ToString();
            txtAddress.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var showDeleteMsg = MessageBox.Show(@"Are you sure want to delete this?", @"Delete",
                MessageBoxButtons.YesNo);

            if (showDeleteMsg == DialogResult.Yes)
            {
                _worker.Delete(Worker.Id);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(7);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(7);
                WorkerListForm.WorkerListForm_Shown(WorkerListForm, new EventArgs());
                Close();
            }
            if (showDeleteMsg == DialogResult.No)
            {
                WorkerForm_Shown(this,new EventArgs());
            }
        }

        private void CheckAccount()
        {
            var check= _account.CheckAccount(Worker.Id);
            if (check == 0)
            {
                btnAcc.Text = @"Create Account";
                btnAcc.Name = @"btnCreate";
                btnAcc.Click += CreateAccount_Click;
            }
            else
            {
                btnAcc.Text = @"Update Account";
                btnAcc.Name = @"btnUpdate";
                btnAcc.Click += UpdateAccount_Click;
            }
        }

        private void CreateAccount_Click(object sender, EventArgs e)
        {
            var createform = new CreateAccount {Workers = Worker,WorkerForm = this};
            createform.ShowDialog();
        }

        private void UpdateAccount_Click(object sender, EventArgs e)
        {
            var updateform=new UpdateAccount{Account = _account.Selection(Worker),WorkerForm = this};
            updateform.ShowDialog();
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Now.Year - dtpDOB.Value.Year).ToString();
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            cboGender.Focus();
        }

        private void cboGender_Leave(object sender, EventArgs e)
        {
            dtpDOB.Focus();
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            txtPhone1.Focus();
        }

        private void txtPhone1_Leave(object sender, EventArgs e)
        {
            txtPhone2.Focus();
        }

        private void txtPhone2_Leave(object sender, EventArgs e)
        {
            txtEmail.Focus();
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
    }
}
