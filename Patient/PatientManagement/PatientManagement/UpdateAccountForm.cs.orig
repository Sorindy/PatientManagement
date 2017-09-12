using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;
using PatientManagement.Class;
using Worker = Hospital_Entity_Framework.Worker;

namespace PatientManagement
{
    public partial class UpdateAccountForm : Form
    {
        public UpdateAccountForm()
        {
            InitializeComponent();
        }

        public Worker Workers;
        public WorkerForm WorkerForm;
        public Account Account=new Account();
        private Hospital_Entity_Framework.Account _account=new Hospital_Entity_Framework.Account();

        private void UpdateAccountForm_Load(object sender, EventArgs e)
        {
            _account= Account.Selection(Workers);
           
            txtUsername.Text = _account.UserName;
            txtPassword.Text = _account.Password;
            txtConfirm.Text = _account.Password;

            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirm.Text == txtPassword.Text && txtConfirm.Text != null && txtPassword.Text != null)
                {
                    Account.Update(_account.Id,txtUsername.Text, txtPassword.Text);
                    Close();
                    WorkerForm.Show();
                }
                else
                {
                    txtPassword.Text = "";
                    txtConfirm.Text = "";
                    txtPassword.Focus();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
