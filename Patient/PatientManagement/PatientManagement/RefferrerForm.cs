using System;
using PatientManagement.Class;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class RefferrerForm : Form
    {
        private readonly Refferrer _refferrer = new Refferrer();
        internal Hospital_Entity_Framework.Referrer Refferrer;

        public RefferrerForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
         _refferrer.Insert(txtName.Text,txtSpeacailly.Text,txtWorkPlace.Text,txtPhone1.Text,txtPhone2.Text,txtEmail.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _refferrer.Update(Refferrer.Id, txtName.Text, txtSpeacailly.Text, txtWorkPlace.Text, txtPhone1.Text,
                txtPhone2.Text, txtEmail.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtSpeacailly.Text = "";
            txtWorkPlace.Text = "";
            txtPhone1.Text = "";
            txtPhone2.Text = "";
            txtEmail.Text = "";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
