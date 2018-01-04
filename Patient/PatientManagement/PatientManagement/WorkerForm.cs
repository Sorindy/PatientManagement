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
            tableLayoutPanel1.TabStop = false;
            tableLayoutPanel2.TabStop = false;
            tableLayoutPanel3.TabStop = false;
            tableLayoutPanel4.TabStop = false;
            tableLayoutPanel5.TabStop = false;
            tableLayoutPanel6.TabStop = false;
            tableLayoutPanel8.TabStop = false;
            tableLayoutPanel10.TabStop = false;
            tableLayoutPanel12.TabStop = false;
            tableLayoutPanel14.TabStop = false;
            tableLayoutPanel16.TabStop = false;
            tableLayoutPanel18.TabStop = false;
            txtAge.TabStop = false;
        }

        internal Worker Worker;
        private readonly Class.Worker _worker=new Class.Worker();
        private readonly Account _account=new Account();
        internal WorkerListForm WorkerListForm;

        private void CheckData()
        {
            if (txtfName.Text.Trim() == "" || txtfName.Text == null)
            {
                MessageBox.Show(@"Please fill First Name.");
                txtfName.Focus();
                return;
            }
            if (txtlName.Text.Trim() == "" || txtlName.Text == null)
            {
                MessageBox.Show(@"Please fill Last Name.");
                txtlName.Focus();
                return;
            }
            if (txtAddress.Text.Trim() == "" || txtAddress.Text == null)
            {
                MessageBox.Show(@"Please fill Address.");
                txtAddress.Focus();
                return;
            }
            if (txtPhone1.Text.Trim() == "" || txtPhone1.Text == null)
            {
                MessageBox.Show(@"Please fill Phone1.");
                txtfName.Focus();
                return;
            }
            if (txtPhone1.Text.Trim() == "" || txtPhone1.Text == null)
            {
                txtPhone1.Text = @"None";
                return;
            }
            if (txtEmail.Text.Trim() == "" || txtEmail.Text == null)
            {
                txtEmail.Text = @"None";
                return;
            }
            if (cboPosition.Text.Trim() == "" || cboPosition.Text == null)
            {
                MessageBox.Show(@"Please fill Position.");
                cboPosition.Focus();
                return;
            }
            if (txtSalary.Text.Trim() == "" || txtSalary.Text == null)
            {
                MessageBox.Show(@"Please fill Salary");
                txtSalary.Focus();
                return;
            }
            if (dtpSWD.Value.Date == DateTime.Now.AddDays(1))
            {
                MessageBox.Show(@"You can't hire " + txtfName.Text + @" over today.");
                return;
            }
            if (dtpDOB.Value.Date == DateTime.Today)
            {
                MessageBox.Show(@"Make sure " + txtfName.Text + @" date of birth correct.");
            }
        }

        internal void WorkerForm_Shown(object sender, EventArgs e)
        {
            txtfName.Text = Worker.FirstName;
            txtlName.Text = Worker.LastName;
            txtAge.Text = Worker.Age.ToString();
            txtAddress.Text = Worker.Address;
            txtPhone1.Text = Worker.Phone1;
            txtPhone2.Text = Worker.Phone2;
            txtEmail.Text = Worker.Email;
            txtSalary.Text = Worker.Salary.ToString();
            cboGender.Text = Worker.Gender;
            dtpDOB.Value = Worker.DOB;
            cboPosition.Text = Worker.Position;
            if (Worker.StartWorkDate != null) dtpSWD.Value = (DateTime) Worker.StartWorkDate;

            txtfName.Enabled = false;
            txtlName.Enabled = false;
            txtAge.Enabled = false;
            txtAddress.Enabled = false;
            txtPhone1.Enabled = false;
            txtPhone1.Enabled = false;
            cboPosition.Enabled = false;
            txtSalary.Enabled = false;
            txtEmail.Enabled = false;
            cboGender.Enabled = false;
            dtpDOB.Enabled = false;
            dtpSWD.Enabled = false;

            btnUpdate.Enabled = false;
            CheckAccount();
            btnCategory.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            WorkerListForm.dgvListWorker.Columns.RemoveAt(8);
            WorkerListForm.dgvListWorker.Columns.RemoveAt(8);
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
                txtfName.Enabled = true;
                txtlName.Enabled = true;
                txtAge.Enabled = true;
                txtAddress.Enabled = true;
                txtPhone1.Enabled = true;
                txtPhone1.Enabled = true;
                cboPosition.Enabled = true;
                txtSalary.Enabled = true;
                txtEmail.Enabled = true;
                cboGender.Enabled = true;
                dtpDOB.Enabled = true;
                dtpSWD.Enabled = true;
                btnEdit.Click += btnCancel_Click;
                txtfName.Focus();
                cboPosition_TextChanged(this, new EventArgs());
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
                _worker.Update(Worker.Id, txtfName.Text,txtlName.Text, cboGender.Text, dtpDOB.Value, Convert.ToByte(txtAge.Text), txtAddress.Text, txtPhone1.Text,
                    txtPhone2.Text, txtEmail.Text, cboGender.Text, Convert.ToInt32(txtSalary.Text), dtpSWD.Value);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(8);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(8);
                WorkerListForm.WorkerListForm_Shown(this, new EventArgs());
                Close();
            }
            catch
            {
                CheckData(); 
                MessageBox.Show(@"Please checking again .", @"Error");
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
                WorkerListForm.dgvListWorker.Columns.RemoveAt(8);
                WorkerListForm.dgvListWorker.Columns.RemoveAt(8);
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

        private void cboPosition_TextChanged(object sender, EventArgs e)
        {
            btnCategory.Enabled = cboPosition.Text == @"Doctor";
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            var form = new CategorySelection {Account = _worker.Account(Worker.Id)};
            form.ShowDialog();
        }
    }
}
