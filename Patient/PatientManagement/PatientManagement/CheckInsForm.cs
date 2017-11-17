using System;
using PatientManagement.Class;
using Form = System.Windows.Forms.Form;
using Patient = Hospital_Entity_Framework.Patient;
using WaitingList = Hospital_Entity_Framework.WaitingList;

namespace PatientManagement
{
    public partial class CheckInsForm : Form
    {
        public CheckInsForm()
        {
            InitializeComponent();
        }
        private readonly CheckIn _chkIn = new CheckIn();
        internal WaitingList WaitingList;
        internal Patient Patient;

        private void CheckInsForm_Shown(object sender, EventArgs e)
        {
            pnlShowService.Controls.Clear();
            pnlSelection.Controls.Clear();
            pnlShowService.Controls.Add(_chkIn.ShowService());
            pnlSelection.Enabled = false;
            pnlShowService.Enabled = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(Patient==null)return;
            _chkIn.SubmitService(Patient.Id,DateTime.Now.TimeOfDay);
            ClearControl();
        }

        private void tblSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new Search { CheckInsForm = this };
            searchForm.ShowDialog();
            if (Patient == null) return;
            txtName.Text = Patient.Name;
            txtGender.Text = Patient.Gender;
            pnlSelection.Enabled = true;
            pnlShowService.Enabled = true;
        }

        private void picboxSearch_Click(object sender, EventArgs e)
        {
            var searchForm = new Search{CheckInsForm = this};
            searchForm.ShowDialog();
            if (Patient == null) return;
            txtName.Text = Patient.Name;
            txtGender.Text = Patient.Gender;
            pnlSelection.Enabled = true;
            pnlShowService.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var searchForm = new Search { CheckInsForm = this };
            searchForm.ShowDialog();
            if (Patient == null) return;
            txtName.Text = Patient.Name;
            txtGender.Text = Patient.Gender;
            pnlShowService.Enabled = true;
            pnlSelection.Enabled = true;
        }

        internal void ClearControl()
        {
            txtName.Text = "";
            txtGender.Text = "";
            pnlSelection.Controls.Clear();
            pnlSelection.Enabled = false;
            pnlShowService.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControl();
        }
    }
}
