using System;
using System.Drawing;
using System.Windows.Forms;
using PatientManagement.Class;
using Account = Hospital_Entity_Framework.Account;

namespace PatientManagement
{
    public partial class CatelogForm : Form
    {
        public CatelogForm()
        {
            InitializeComponent();
        }

        private readonly Login _login=new Login();
        internal LoginForm LoginForm;
        internal Account Account;
        private bool _mouseDown;
        private Point _lastLocation;

        private void CatelogForm_Shown(object sender, EventArgs e)
        {
            txtUserName.Text = Account.Worker.FirstName+@"  "+Account.Worker.LastName;
            timer1.Enabled = true;
            timer1_Tick(this,new EventArgs());
            //MaximizeForm();
            WindowState=FormWindowState.Maximized;
            pnlLeftFill.Controls.Clear();
            pnlLeftFill.Controls.Add(_login.ButtonToForm(Account));
        }

        //private void MaximizeForm()
        //{
        //    FormBorderStyle =FormBorderStyle.None;
        //    Left = Top = 0;
        //    Width = Screen.PrimaryScreen.WorkingArea.Width;
        //    Height = Screen.PrimaryScreen.WorkingArea.Height;
        //}

        private void tblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //private void picMinimize_Click(object sender, EventArgs e)
        //{
        //    WindowState=FormWindowState.Minimized;
        //}

        //private void picMazimize_Click(object sender, EventArgs e)
        //{
        //    WindowState=FormWindowState.Maximized;
        //    FormBorderStyle=FormBorderStyle.None;
        //}

        //private void pictureBox1_Click_1(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Normal;
        //    FormBorderStyle=FormBorderStyle.Sizable;
        //}

        private void panelLogout_Click(object sender, EventArgs e)
        {
            Close();
            LoginForm.Show();
            LoginForm.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        
        {
            lblDatetime.Text = DateTime.Now.ToLongDateString()+@"   " + DateTime.Now.ToLongTimeString();
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void tableLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }

        private void lblDatetime_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseDown = true;
            _lastLocation = e.Location;
        }

        private void lblDatetime_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                Location = new Point(
                    Location.X - _lastLocation.X + e.X, (Location.Y - _lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void lblDatetime_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
        }
    }
}
