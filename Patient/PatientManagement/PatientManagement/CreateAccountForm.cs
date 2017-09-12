using System;
using System.Windows.Forms;
using PatientManagement.Class;
using Worker = Hospital_Entity_Framework.Worker;

/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/

namespace PatientManagement
{
    public partial class CreateAccountForm : Form
    {
        public Worker Workers;
        public WorkerForm WorkerForm;
        public Account Account=new Account();
        private Hospital_Entity_Framework.Account _account=new Hospital_Entity_Framework.Account();
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            txtConfirm.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";

            txtUsername.Focus();

            txtPassword.PasswordChar = '*';
            txtConfirm.PasswordChar = '*';
            txtPassword.MaxLength = 18;
            txtConfirm.MaxLength = 18;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtConfirm.Text == txtPassword.Text && txtConfirm.Text != null && txtPassword.Text != null)
                {
                    Account.Insert(Account.AutoId(),Workers.Id,txtUsername.Text,txtPassword.Text);
                    WorkerForm.Show();
                    Close();
                }
                else
                {
                    txtConfirm.Text = "";
                    txtPassword.Text = "";
                    txtPassword.Focus();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}