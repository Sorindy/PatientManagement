using System;
/*using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class UpdateAccountForm : Form
    {
        public UpdateAccountForm()
        {
            InitializeComponent();
        }

        public Worker Worker;
        public Account acc=new Account();
        public WorkerForm WorkerForm;

        private void UpdateAccountForm_Load(object sender, EventArgs e)
        {
            acc.Worker = Worker;
            acc.Selection_Account();
           
            txtUsername.Text = acc.UserName;
            txtPassword.Text = acc.Password;
            txtConfirm.Text = acc.Password;

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
                    acc.Update_Account(txtUsername.Text, txtPassword.Text);
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
