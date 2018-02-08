using System;
using System.Windows.Forms;

namespace PatientManagement
{
    public partial class TitleInput : Form
    {
        public TitleInput()
        {
            InitializeComponent();
        }

        internal MedicalsForm MedicalForm;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "")
            {
                MedicalForm.Title = txtTitle.Text;
                Close();
            }
            else
            {
                MessageBox.Show(@"Please input Title.", @"Empty Title");
                txtTitle.Focus();
            }
        }
    }
}
