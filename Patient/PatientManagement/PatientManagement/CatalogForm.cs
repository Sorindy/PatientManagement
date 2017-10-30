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
using Form = System.Windows.Forms.Form;

namespace PatientManagement
{
    public partial class CatalogForm : Form
    {
        public CatalogForm()
        {
            InitializeComponent();
        }

        public LoginForm LoginForm;
        public Account Account;
        private readonly Login _login = new Login();

        private void CatalogForm_Shown(object sender, EventArgs e)
        {
            Size = SystemInformation.PrimaryMonitorSize;
            Location = new Point(0, 0);
            flpnButtonForm.Controls.Clear();
            flpnButtonForm.Controls.Add(_login.ButtonToForm(Account));
        }

    }
}
