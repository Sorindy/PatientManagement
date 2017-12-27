using System;
using System.Drawing;
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
        private bool _mouseDown;
        private Point _lastLocation;

        internal void Clear()
        {
            txtUserName.Text = "";
            txtUserName.Focus();
            txtPassword.Text = "";
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Maximized;
            Clear();
            tblLogin.BackColor = Color.FromArgb(255,Color.CornflowerBlue);
            tblLogin.BackColor = Color.FromArgb(255, Color.CornflowerBlue);
            tblControl.BackColor = Color.FromArgb(0, Color.AntiqueWhite);
            panel1.BackColor = Color.FromArgb(0, Color.AntiqueWhite);
            txtPassword.PasswordChar = '*';
            txtUserName.Focus();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            _account = _login.LoginAccount(txtUserName.Text, txtPassword.Text);
            if (_account != null)
            {
                var form = new CatelogForm
                {
                    Account = _account,
                    LoginForm = this
                };
                form.Show();
                Hide();
            }
            else
            {
                Clear();
                MessageBox.Show(@"Pleas input correct UserName and Password");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lbLogin_Click(object sender, EventArgs e)
        {
            _account = _login.LoginAccount(txtUserName.Text, txtPassword.Text);
            if (_account != null)
            {
                var form = new CatelogForm
                {
                    Account = _account,
                    LoginForm = this
                };
                form.Show();
                Hide();
            }
            else
            {
                Clear();
                MessageBox.Show(@"Pleas input correct UserName and Password");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this,new EventArgs());
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }

        private void picMazimize_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Maximized;
        }

        private void picNormal_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Normal;
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                _mouseDown = true;
                _lastLocation = e.Location;
            }
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                if (_mouseDown)
                {
                    Location = new Point(
                        Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                    Update();
                }
            }
        }

        private void tableLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                _mouseDown = false;
            }
        }

    }
}
