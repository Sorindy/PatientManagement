using System;
using Hospital_Entity_Framework;
using Account = PatientManagement.Class.Account;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        internal Worker Workers;
        private readonly Account _account=new Account();
        internal WorkerForm WorkerForm;

        private void CreateAccount_Shown(object sender, EventArgs e)
        {
            txtConfirm.Text = "";
            txtPassword.Text = "";
            txtUserName.Text = "";

            txtUserName.Focus();

            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
            txtPassword.MaxLength = 18;
            txtConfirm.MaxLength = 18;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtConfirm.Text == txtPassword.Text && txtConfirm.Text != null && txtPassword.Text != null)
            {
                _account.Insert(Workers.Id, txtUserName.Text, txtPassword.Text);
                Close();
                WorkerForm.WorkerForm_Shown(WorkerForm,new EventArgs());
                WorkerForm.Worker = Workers;
            }
            else
            {
                txtConfirm.Text = "";
                txtPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
