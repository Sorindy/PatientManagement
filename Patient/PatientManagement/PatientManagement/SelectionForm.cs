using System;
using System.Windows.Forms;
using PatientManagement.Class;
using Account = Hospital_Entity_Framework.Account;

namespace PatientManagement
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
        }

        private readonly Login _login=new Login();
        internal Account Account;
        internal LoginForm LoginForm;

        private void SelectionForm_Shown(object sender, EventArgs e)
        {
            Controls.Add(_login.ButtonToForm(Account));
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {

        }

    }
}
