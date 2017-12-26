using System;
using System.Drawing;
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
        private bool _mouseDown;
        private Point _lastLocation;

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

        private void tblLogin_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tblLogin_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tblLogin_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _mouseDown = false;
        }
    }
}
