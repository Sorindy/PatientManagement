using System;
using Hospital_Entity_Framework;
using Account = PatientManagement.Class.Account;
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class UpdateAccount : Form
    {
        public UpdateAccount()
        {
            InitializeComponent();
        }

        internal Hospital_Entity_Framework.Account Account;
        private readonly Account _account=new Account();
        internal WorkerForm WorkerForm;

        private void UpdateAccount_Shown(object sender, EventArgs e)
        {
            txtUserName.Focus();

            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
            txtPassword.MaxLength = 18;
            txtConfirm.MaxLength = 18;

            txtUserName.Text = Account.UserName;
            txtPassword.Text = Account.Password;
            txtConfirm.Text = Account.Password;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _account.Update(Account.Id,txtUserName.Text,txtPassword.Text);
                Close();
            }
            catch
            {
                txtUserName.Text ="";
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
