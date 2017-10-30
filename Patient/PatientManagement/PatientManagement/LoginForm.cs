using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PatientManagement.Class;
using Account = Hospital_Entity_Framework.Account;

namespace PatientManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private readonly Login _login=new Login();
        private Account _account;

        private void Clear()
        {
            txtUserName.Text = "";
            txtUserName.Focus();
            txtPassword.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Clear();
            LoginPanel.BackColor = Color.FromArgb(220,Color.LimeGreen);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            _account = _login.LoginAccount(txtUserName.Text, txtPassword.Text);
            if (_account != null)
            {
                var form = new CatalogForm();
                form.Account = _account;
                form.LoginForm = this;
                form.Show();
                Hide();
            }
            else
            {
                Clear();
                MessageBox.Show(@"Pleas input correct UserName and Password");
            }
        }

    }
}
