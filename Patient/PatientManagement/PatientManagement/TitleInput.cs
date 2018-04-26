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
        internal HistorysForm HistoryForm;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "")
            {
                if(MedicalForm!=null) MedicalForm.Title = txtTitle.Text;
                if (HistoryForm != null) HistoryForm.Title = txtTitle.Text;
                Close();
            }
            else
            {
                MessageBox.Show(@"Please input Title.", @"Empty Title");
                txtTitle.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MedicalForm != null) MedicalForm.Title = "";
            if (HistoryForm != null) HistoryForm.Title = "";
            Close();
        }
    }
}
