using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using PatientManagement.Class;

namespace PatientManagement
{
    public partial class WorkerForm : Form
    {
        public WorkerForm()
        {
            InitializeComponent();
        }

        readonly Worker _worker=new Worker();
        protected Hospital_Entity_Framework.Worker Wk;
        private readonly Account _account=new Account();

        private void WorkerForm_Load(object sender, EventArgs e)
        {            
                dgvWorker.DataSource = _worker.ShowAll();
                Clears();
                txtID.Text = _worker.AutoId();
                btnNew.Hide();
        }

        private void Clears()
        {
            txtName.Text = "";
            txtAge.Text = "";
            cboGender.Text = @"Female";
            txtAddress.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";
            txtSalary.Text = "";
            txtPosition.Text = "";
            txtSearch.Text = "";
            txtSearch.Enabled = false;
            btnSearch.Visible = true;
            btnStop.Visible = false;
            dgvWorker.ReadOnly = true;
            dgvWorker.Enabled = false;
            btnEdit.Visible = true;
            btnUpdate.Visible = false;
            btnDelete.Enabled = false;
            dtpSWD.Value=DateTime.Today;
            dtpDOB.Value=DateTime.Today;
            btnCreateAcc.Visible = true;
            btnUpdateAcc.Visible = false;
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
            if   (txtSalary.Text.Trim() == "" || txtSalary.Text == null)
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

        private void FormRefresh(object sender, EventArgs e)
        {
            WorkerForm_Load(this,e);
            MouseLeave -= new EventHandler(FormRefresh);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if (dgvWorker.CurrentRow != null)
                {
                    _worker.Delete(dgvWorker.CurrentRow.Cells[0].Value.ToString());
                    MouseLeave +=new EventHandler(FormRefresh);
                
                    _worker.Delete(dgvWorker.CurrentRow.Cells[0].Value.ToString());
                }
        }

        private void dgvWorker_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWorker.CurrentRow != null)
            {
                var getid = dgvWorker.CurrentRow.Cells[0].Value.ToString();
                Wk = _worker.SelectedChange(getid);
            }


            txtID.Text = Wk.Id ;
                txtName.Text = Wk.Name;
                cboGender.Text = Wk.Gender;
                dtpDOB.Value= Wk.DOB;
                txtAge.Text = Wk.Age.ToString();
                txtAddress.Text = Wk.Address;
                txtPhone1.Text = Wk.Phone1;
                txtPhone2.Text = Wk.Phone2;
                txtEmail.Text = Wk.Email;
                txtPosition.Text = Wk.Position;
                txtSalary.Text = Wk.Salary.ToString();
                dtpSWD.Value = Wk.StartWorkDate.GetValueOrDefault();

                if (_account.CheckAccount(txtID.Text) == txtID.Text)
                {
                    btnUpdateAcc.Visible = true;
                    btnCreateAcc.Visible = false;
                }
                else
                {
                    btnUpdateAcc.Visible = false;
                    btnCreateAcc.Visible = true;
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _worker.Insert(txtID.Text, txtName.Text, cboGender.Text, dtpDOB.Value.Date, Convert.ToInt16(txtAge.Text), txtAddress.Text, txtPhone1.Text,
                    txtPhone2.Text, txtEmail.Text, txtPosition.Text, Convert.ToInt32(txtSalary.Text), dtpSWD.Value.Date);
                MouseLeave += new EventHandler(FormRefresh);
            }
            catch
            {
                CheckData();
            }
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            txtAge.Text = (DateTime.Today.Year - dtpDOB.Value.Year).ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvWorker.DataSource = _worker.Search(txtSearch.Text);
                Refresh();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            WorkerForm_Load(this,e);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Enabled = true;
            btnStop.Visible = true;
            btnSearch.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnDelete.Enabled = true;
            btnEdit.Visible = false;
            btnUpdate.Visible = true;
            dgvWorker.ReadOnly = false;
            dgvWorker.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
                _worker.Update(txtID.Text, txtName.Text, cboGender.Text, dtpDOB.Value.Date, Convert.ToInt16(txtAge.Text), txtAddress.Text, txtPhone1.Text,
                    txtPhone2.Text, txtEmail.Text, txtPosition.Text, Convert.ToInt32(txtSalary.Text), dtpSWD.Value.Date);
            MouseLeave += new EventHandler(FormRefresh);
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            var formAcc = new CreateAccountForm {Workers = Wk};
            formAcc.Show();
            formAcc.WorkerForm = this;
            Hide();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdateAcc_Click(object sender, EventArgs e)
        {
            var updateAcc = new UpdateAccountForm {Workers = Wk};
            updateAcc.Show();
                updateAcc.WorkerForm = this;
                Hide();
        }
    }       
}
